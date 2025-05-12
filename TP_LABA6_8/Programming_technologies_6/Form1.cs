using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Programming_technologies_6.Emitter;
using static Programming_technologies_6.Particle;

namespace Programming_technologies_6
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        GravityPoint point1; // добавил поле под первую точку
        GravityPoint point2; // добавил поле под вторую точку
        Emitter.RadarPoint radar;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.Red,
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);


            // привязываем гравитоны к полям
            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };
            radar = new Emitter.RadarPoint()
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2
            };
            emitter.impactPoints.Add(radar);



        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            radar.ResetCounter();
            emitter.UpdateState(); // тут теперь обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }

            picDisplay.Invalidate();
        }
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            // а тут передаем положение мыши, в положение гравитона
            point2.X = e.X;
            point2.Y = e.Y;
            radar.X = e.X;
            radar.Y = e.Y;

        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
            lblSpreading.Text = $"{tbSpreading.Value}°";
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            radar.ChangeRadius(e.Delta > 0 ? 10 : -10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMultiplier = tbSpeed.Value / 10f;
        }

        private void chkDebug_CheckedChanged(object sender, EventArgs e)
        {
            emitter.DebugMode = chkDebug.Checked;
        }
    }
}
