using System.Drawing;
using System.Windows.Forms;

namespace Guilty_Gear_Strive_Mod_Manager
{
    public static class FontManager
    {
        public static void ChangeFormFont(Form form, FontFamily fontf)
        {
            form.Font = new Font(fontf, form.Font.Size, form.Font.Style);
            foreach (Control control in form.Controls)
            {
                ChangeControlsFonts(control, fontf);
            }
        }

        public static void ChangeUserControlFont(UserControl form, FontFamily fontf)
        {
            form.Font = new Font(fontf, form.Font.Size, form.Font.Style);
            foreach (Control control in form.Controls)
            {
                ChangeControlsFonts(control, fontf);
            }
        }

        private static void ChangeControlsFonts(Control container, FontFamily fontf)
        {
            container.Font = new Font(fontf, container.Font.Size, container.Font.Style);

            foreach (Control ctrl in container.Controls)
            {
                ChangeControlsFonts(ctrl, fontf);
            }
        }
    }
}