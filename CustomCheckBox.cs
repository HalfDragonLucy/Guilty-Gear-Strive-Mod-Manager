using System.Drawing;
using System.Windows.Forms;

namespace Guilty_Gear_Strive_MM
{
    internal class MyCheckBox : CheckBox
    {
        public MyCheckBox() => TextAlign = ContentAlignment.MiddleLeft;
        public override bool AutoSize
        {
            get => base.AutoSize;
            set => base.AutoSize = false;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int h = ClientSize.Height - 2;
            Rectangle rc = new Rectangle(new Point(0, 1), new Size(h, h));
            ControlPaint.DrawCheckBox(e.Graphics, rc,
                Checked ? ButtonState.Checked : ButtonState.Normal);
        }

    }
}
