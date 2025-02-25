using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_LABA3
{
    public partial class Form1 : Form
    {
        private HSVColor currentColor;

        public Form1()
        {
            InitializeComponent();
            // Инициализируем цвет (например, чисто красный: Hue=0, Saturation=1, Value=1)
            currentColor = new HSVColor(0, 1, 1);
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Обновление меток с информацией о текущем цвете
            lblHSV.Text = currentColor.ToString();
            Color rgb = currentColor.ToRGB();
            lblRGB.Text = $"RGB({rgb.R}, {rgb.G}, {rgb.B})";
            panelColor.BackColor = rgb;
        }

        // Обработчики событий кнопок.
        // Для каждой операции считываем изменение из текстового поля и применяем его.

        private void btnAddRed_Click(object sender, EventArgs e)
        {
            int delta = int.Parse(txtRedDelta.Text);
            currentColor.ModifyRed(delta);
            UpdateUI();
        }

        private void btnSubRed_Click(object sender, EventArgs e)
        {
            int delta = int.Parse(txtRedDelta.Text);
            currentColor.ModifyRed(-delta);
            UpdateUI();
        }

        private void btnAddGreen_Click(object sender, EventArgs e)
        {
            int delta = int.Parse(txtGreenDelta.Text);
            currentColor.ModifyGreen(delta);
            UpdateUI();
        }

        private void btnSubGreen_Click(object sender, EventArgs e)
        {
            int delta = int.Parse(txtGreenDelta.Text);
            currentColor.ModifyGreen(-delta);
            UpdateUI();
        }

        private void btnAddBlue_Click(object sender, EventArgs e)
        {
            int delta = int.Parse(txtBlueDelta.Text);
            currentColor.ModifyBlue(delta);
            UpdateUI();
        }

        private void btnSubBlue_Click(object sender, EventArgs e)
        {
            int delta = int.Parse(txtBlueDelta.Text);
            currentColor.ModifyBlue(-delta);
            UpdateUI();
        }

        private void btnAddSat_Click(object sender, EventArgs e)
        {
            double delta = double.Parse(txtSatDelta.Text);
            currentColor.ModifySaturation(delta);
            UpdateUI();
        }

        private void btnSubSat_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSatDelta.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double delta))
            {
                currentColor.ModifySaturation(-delta);
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Введите корректное числовое значение для изменения насыщенности.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddVal_Click(object sender, EventArgs e)
        {
            double delta = double.Parse(txtValDelta.Text);
            currentColor.ModifyValue(delta);
            UpdateUI();
        }

        private void btnSubVal_Click(object sender, EventArgs e)
        {
            double delta = double.Parse(txtValDelta.Text);
            currentColor.ModifyValue(-delta);
            UpdateUI();
        }
    }

        public class HSVColor
        {
            // Hue в градусах [0,360), Saturation и Value в диапазоне [0,1]
            public double Hue { get; set; }
            public double Saturation { get; set; }
            public double Value { get; set; }

            public HSVColor(double hue, double saturation, double value)
            {
                Hue = hue;
                Saturation = saturation;
                Value = value;
            }

            // Преобразование HSV в RGB
            public Color ToRGB()
            {
                double h = Hue;
                double s = Saturation;
                double v = Value;

                int hi = (int)Math.Floor(h / 60) % 6;
                double f = (h / 60) - Math.Floor(h / 60);
                double p = v * (1 - s);
                double q = v * (1 - f * s);
                double t = v * (1 - (1 - f) * s);

                double r = 0, g = 0, b = 0;
                switch (hi)
                {
                    case 0: r = v; g = t; b = p; break;
                    case 1: r = q; g = v; b = p; break;
                    case 2: r = p; g = v; b = t; break;
                    case 3: r = p; g = q; b = v; break;
                    case 4: r = t; g = p; b = v; break;
                    case 5: r = v; g = p; b = q; break;
                }
                return Color.FromArgb(
                    (int)(r * 255),
                    (int)(g * 255),
                    (int)(b * 255)
                );
            }

            // Обратное преобразование RGB в HSV
            public void FromRGB(Color color)
            {
                double r = color.R / 255.0;
                double g = color.G / 255.0;
                double b = color.B / 255.0;

                double max = Math.Max(r, Math.Max(g, b));
                double min = Math.Min(r, Math.Min(g, b));
                double delta = max - min;

                double h = 0;
                if (delta == 0)
                    h = 0;
                else if (max == r)
                    h = 60 * (((g - b) / delta) % 6);
                else if (max == g)
                    h = 60 * (((b - r) / delta) + 2);
                else if (max == b)
                    h = 60 * (((r - g) / delta) + 4);

                if (h < 0)
                    h += 360;

                double s = (max == 0) ? 0 : delta / max;
                double v = max;

                Hue = h;
                Saturation = s;
                Value = v;
            }

            // Операции изменения отдельных компонентов в RGB-пространстве:
            public void ModifyRed(int delta)
            {
                Color rgb = ToRGB();
                int newRed = Math.Min(255, Math.Max(0, rgb.R + delta));
                Color newColor = Color.FromArgb(newRed, rgb.G, rgb.B);
                FromRGB(newColor);
            }

            public void ModifyGreen(int delta)
            {
                Color rgb = ToRGB();
                int newGreen = Math.Min(255, Math.Max(0, rgb.G + delta));
                Color newColor = Color.FromArgb(rgb.R, newGreen, rgb.B);
                FromRGB(newColor);
            }

            public void ModifyBlue(int delta)
            {
                Color rgb = ToRGB();
                int newBlue = Math.Min(255, Math.Max(0, rgb.B + delta));
                Color newColor = Color.FromArgb(rgb.R, rgb.G, newBlue);
                FromRGB(newColor);
            }

            // Изменение насыщенности (Saturation)
            public void ModifySaturation(double delta)
            {
                Saturation = Math.Min(1.0, Math.Max(0.0, Saturation + delta));
            }

            // Изменение яркости (Value)
            public void ModifyValue(double delta)
            {
                Value = Math.Min(1.0, Math.Max(0.0, Value + delta));
            }

            public override string ToString()
            {
                return $"HSV({Hue:F2}, {Saturation:F2}, {Value:F2})";
            }
        }
    }
