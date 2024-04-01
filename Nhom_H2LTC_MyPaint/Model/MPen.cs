using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nhom_H2LTC_MyPaint.Model
{
    public class MPen : MCurve
    {
        public bool isEraser { get; set; }

        public MPen()
        {
            name = "Pen";
        }

        public MPen(Color color)
        {
            name = "Pen";
            this.color = color;
        }
    }
}
