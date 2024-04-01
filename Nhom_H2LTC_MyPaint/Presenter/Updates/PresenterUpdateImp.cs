using Nhom_H2LTC_MyPaint.Model;
using Nhom_H2LTC_MyPaint.Utils;
using Nhom_H2LTC_MyPaint.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_H2LTC_MyPaint.Presenter.Updates
{
    public class PresenterUpdateImp : PresenterUpdate
    {
        ViewPaint viewPaint;

        DataManager dataManager;
        public PresenterUpdateImp(ViewPaint viewPaint)
        {
            this.viewPaint = viewPaint;
            dataManager = DataManager.getInstance();
        }
        public void onClickSelectColor(Color color, Graphics g)
        {
            dataManager.colorCurrent = color;
            viewPaint.setColor(color);
            foreach (var item in dataManager.shapeList)
            {
                if (item.isSelected)
                {
                    item.color = color;
                    viewPaint.setDrawing(item, g);
                }
            }
        }

        public void onClickSelectFill(Button btn, Graphics g)
        {
            dataManager.isFill = !dataManager.isFill;
            if (btn.BackColor.Equals(Color.LightCyan))
                viewPaint.setColor(btn, SystemColors.Control);
            else
                viewPaint.setColor(btn, Color.LightCyan);
        }

        public void onClickSelectFill(System.Windows.Controls.Button btn, Graphics g)
        {
            throw new NotImplementedException();
        }

        public void onClickSelectMode()
        {
            dataManager.offAllShapeSelected();
            viewPaint.refreshDrawing();
            dataManager.currentShape = CurrentShape.Void;
            viewPaint.setCursor(Cursors.Default);
        }

        public void onClickSelectSize(int size)
        {
            dataManager.lineSize = size;
        }
    }
}
