using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using phonizer.Content;
using Phonizer.Enums;
using Phonizer.Forms;
using Phonizer.Static;

namespace Phonizer.Helpers
{
    public static class Toast
    {
        private const int MaxFormsCount = 4;
        private static List<InfoForm> InfoForms { get; set; } = new List<InfoForm>();

        public static void AlertError(string message)
        {
            MessageBox.Show(message, Strings.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void AlertMessage(string message)
        {
            MessageBox.Show(message, Strings.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void AlertInfo(EventType eventType, string message)
        {
            Context.LoginForm.Invoke((MethodInvoker)(() =>
            {
                var infoForm = new InfoForm(eventType, message);
                InfoForms.Add(infoForm);
                if (InfoForms.Count > MaxFormsCount)
                {
                    var f = InfoForms[0];
                    InfoForms.RemoveAt(0);
                    f.Close();
                }
                InfoForms.ForEach(f => f.Shift());

                infoForm.Show();
                infoForm.Location = new Point(SystemInformation.PrimaryMonitorSize.Width - infoForm.Width, 0);
            }));
        }
    }
}