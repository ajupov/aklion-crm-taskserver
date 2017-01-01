using System;
using System.Drawing;
using System.Windows.Forms;
using Phonizer.Enums;
using Phonizer.Helpers;

namespace Phonizer.Forms
{
    public partial class InfoForm : Form
    {
        public InfoForm(EventType eventType, string message)
        {
            try
            {
                InitializeComponent();
                InitializeInfo(eventType, message);
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }

        private void InitializeInfo(EventType eventType, string message)
        {
            switch (eventType)
            {
                case EventType.NewOrder:
                    textBoxTitle.BackColor = BackColor = Color.Yellow;
                    textBoxTitle.Text = "Поступил заказ";
                    break;
                case EventType.NewCall:
                    textBoxTitle.BackColor = BackColor = Color.LightGreen;
                    textBoxTitle.Text = "Поступил звонок";
                    break;
                case EventType.SearchByPhone:
                    textBoxTitle.BackColor = BackColor = Color.LightSkyBlue;
                    textBoxTitle.Text = "Запрос номера";
                    break;
                case EventType.ShowOrder:
                    break;
                case EventType.ShowCall:
                    break;
            }

            textBoxMessage.Text = message;
        }

        private void ButtonCloseClick(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }

        public void Shift()
        {
            Location = new Point(Location.X, Location.Y + Height + 2);
        }
    }
}