using System.Drawing;
using System.Windows.Forms;

namespace Guilty_Gear_Strive_Mod_Manager
{
    public static class InputDialog
    {
        public static void ShowInputDialog(ref string input)
        {
            Size size = new Size(200, 70);
            Form inputBox = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                ClientSize = size,
                Text = "Name"
            };

            TextBox textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, 5),
                Text = input
            };
            inputBox.Controls.Add(textBox);

            Button okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = "&OK",
                Location = new Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = "&Cancel",
                Location = new Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            inputBox.ShowDialog();
            input = textBox.Text;
            inputBox.Dispose();
        }
    }
}
