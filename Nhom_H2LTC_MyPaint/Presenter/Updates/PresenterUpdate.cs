using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Nhom_H2LTC_MyPaint.Presenter.Updates
{
    public interface PresenterUpdate
    {
        void onClickSelectMode();
        void onClickSelectColor(Color color, Graphics g);
        void onClickSelectSize(int size);
        void onClickSelectFill(System.Windows.Forms.Button btn, Graphics g);
    }
}
