using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using Nhom_H2LTC_MyPaint.Model;
using Nhom_H2LTC_MyPaint.Utils;

namespace Nhom_H2LTC_MyPaint.View
{
    public interface ViewPaint
    {
        void refreshDrawing();
        void setCursor(Cursor cursor);
        void setColor(Color color);
        void setColor(Button btn, Color color);
        void setDrawing(Model.Shape shape, Graphics g);
        void setDrawingLineSelected(Model.Shape shape, Brush brush, Graphics g);
        void setDrawingCurveSelected(List<Point> points, Brush brush, Graphics g);
        void setDrawingRegionRectangle(Pen p, System.Drawing.Rectangle rectangle, Graphics g);
        void movingShape(Model.Shape shape, Point distance);
        void movingControlPoint(Model.Shape shape, Point pointCurrent, Point previous, int indexPoint);
    }
}
