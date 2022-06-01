using System.Drawing;
using System.Windows.Forms;

namespace Guilty_Gear_Strive_Mod_Manager
{
    public class ScalableCheckBox : CheckBox
    {
        public ScalableCheckBox() => TextAlign = ContentAlignment.MiddleLeft;
        public override bool AutoSize
        {
            get => base.AutoSize;

            set => base.AutoSize = value;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            int h = ClientSize.Height - 2;
            Rectangle rc = new Rectangle(new Point(0, 1), new Size(h, h));
            ControlPaint.DrawCheckBox(pevent.Graphics, rc,
                Checked ? ButtonState.Checked : ButtonState.Normal);
        }

    }
}
