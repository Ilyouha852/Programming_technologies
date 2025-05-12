using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_LABA4_3
{
    public partial class Form1 : Form
    {
        List<SpaceObject> spaceObjectList = new List<SpaceObject>()
        {
            new Planet { name = "Земля", radius = 6371, hasAtmosphere = true, gravity = 9.81 },
            new Planet { name = "Марс", radius = 3389, hasAtmosphere = true, gravity = 3.71 },
            new Planet { name = "Юпитер", radius = 69911, hasAtmosphere = true, gravity = 24.79 },
            new Planet { name = "Сатурн", radius = 58232, hasAtmosphere = true, gravity = 10.44 },
            new Planet { name = "Венера", radius = 6051, hasAtmosphere = true, gravity = 8.87 },
            new Star { name = "Солнце", density = 1.41, color = "Yellow", tempeature = 5778 },
            new Star { name = "Сириус", density = 1.98, color = "Blue", tempeature = 9940 },
            new Star { name = "Альфа Центавра-А", density = 1.52, color = "Yellow", tempeature = 5790 },
            new Star { name = "Бетельгейзе", density = 0.38, color = "Red", tempeature = 3500 },
            new Star { name = "Ригель", density = 1.12, color = "Blue", tempeature = 12000 },
            new Comet { name = "Комета Галлея", periodOfPassageThroughTheSolarSystem = 76 },
            new Comet { name = "NEOWISE", periodOfPassageThroughTheSolarSystem = 6800 },
            new Comet { name = "Комета Хейла — Боппа", periodOfPassageThroughTheSolarSystem = 2533 },
            new Comet { name = "Хякутакэ", periodOfPassageThroughTheSolarSystem = 17000 },
            new Comet { name = "Комета ISON", periodOfPassageThroughTheSolarSystem = 11000 }
        };

        List<SpaceObject> spaceObjectListCopy = new List<SpaceObject>();

        public Form1()
        {
            spaceObjectListCopy = spaceObjectList.ToList();
            InitializeComponent();
            ShowInfo();
        }

        private void RefillSpaceObjectList()
        {
            txtOut.Clear();
            spaceObjectListCopy = spaceObjectList.ToList();
        }

        private SpaceObject ExtractNextSpaceObject()
        {
            if (spaceObjectListCopy.Count == 0)
                return null;

            var nextObject = spaceObjectListCopy[0];
            spaceObjectListCopy.RemoveAt(0);
            return nextObject;
        }

        private void ShowInfo()
        {           
            int planetsCount = 0;
            int starsCount = 0;
            int cometsCount = 0;

            foreach (var spaceObject in this.spaceObjectListCopy)
            {
                if (spaceObject is Planet)
                {
                    planetsCount += 1;
                }
                else if (spaceObject is Star)
                {
                    starsCount += 1;
                }
                else if (spaceObject is Comet)
                {
                    cometsCount += 1;
                }
            }

            txtInfo.Text = "Planet\tStar\tComet";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", planetsCount, starsCount, cometsCount);
        }

        private void btnRefill_Click_1(object sender, EventArgs e)
        {
            RefillSpaceObjectList();
            ShowInfo();
        }

        private void btnGet_Click_1(object sender, EventArgs e)
        {
            var spaceObject = ExtractNextSpaceObject();
            if (spaceObject == null)
            {
                MessageBox.Show("В автомате не осталось объектов");
                return;
            }

            if (spaceObject is Planet planet)
            {
                txtOut.AppendText($"Название планеты: {planet.name}\nРадиус: {planet.radius}\nГравитация: {planet.gravity}\nАтмосфера: {planet.hasAtmosphere}\n\n");
            }
            else if (spaceObject is Star star)
            {
                txtOut.AppendText($"Название звезды: {star.name}\nПлотность: {star.density}\nЦвет: {star.color}\nТемпература: {star.tempeature}\n\n");
            }
            else if (spaceObject is Comet comet)
            {
                txtOut.AppendText($"Название кометы: {comet.name}\nПериод прохождения через Солнечную систему: {comet.periodOfPassageThroughTheSolarSystem}\n\n");
            }

            ShowInfo();
        }
    }
}