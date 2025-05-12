using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LABA4_3
{

    public class SpaceObject { }
    public class Planet : SpaceObject
    {
        public string name = "";
        public int radius = 0;
        public bool hasAtmosphere = false;
        public double gravity = 0.0;
    }

    public class Star : SpaceObject
    {
        public string name = "";
        public double density = 0.0;
        public string color = "";
        public int tempeature = 0;
    }

    public class Comet : SpaceObject
    {
        public string name = "";
        public int periodOfPassageThroughTheSolarSystem = 0;
    }

}