using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TP_LABA5_1.Objects
{
    internal class Circle : BaseObject
    {
        private float radius;

        public Circle(float x, float y, float radius) : base(x, y, 0)
        {
            this.radius = radius;
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = new GraphicsPath();
            path.AddEllipse(-radius, -radius, 2 * radius, 2 * radius);
            return path;
        }

        public override void Render(Graphics g)
        {
            using (var brush = new SolidBrush(Color.Red))
            {
                g.FillEllipse(brush, -radius, -radius, 2 * radius, 2 * radius);
            }
        }

        public float Radius => radius;
    }
}

