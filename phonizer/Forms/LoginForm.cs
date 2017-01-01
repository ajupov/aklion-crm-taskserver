using Phonizer.Helpers;
using Phonizer.Models;
using Phonizer.Services;
using System;
using System.Windows.Forms;
using phonizer.Content;
using Phonizer.Enums;
using Phonizer.Static;

namespace Phonizer.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            try
            {
                InitializeComponent();
                Context.LoginForm = this;
                Context.CallsDataGridView = dataGridViewCalls;
                InitializeSettings();
                InitializeNetworkInterfaces();
            }
            catch (Exception)
            {
                Toast.AlertError(Strings.AutorizationSettingsError);
            }
        }

        private WoCommerceDbService WoCommerceDbService { get; set; }

        private LocalDbService LocalDbService { get; set; }

        private ServerService ServerService { get; set; }

        private async void ButtonConnectClick(object sender, EventArgs e)
        {
            //checkBoxOnlyLocal.Checked = true;
            textBoxSearch.Text = "+79374453807";

            try
            {
                SetUiVisibility(UiVisibilityMode.HiddenMode);

                var ip = ((ComboBoxItem) NetworkInterfaceComboBox.SelectedItem).Value.ToString();

                var localDbSettings = new DbSettings
                {
                    Address = textBoxAddressLocal.Text,
                    Name = textBoxNameLocal.Text
                };

                var woCommerceDbSettings = new DbSettings
                {
                    Address = textBoxAddressWc.Text,
                    Name = textBoxNameWc.Text,
                    Login = textBoxLoginWc.Text,
                    Password = textBoxPasswordWc.Text
                };

                if (checkBoxRemember.Checked)
                {
                    SettingsService.SaveSettings(woCommerceDbSettings, localDbSettings);
                }

                if (!checkBoxOnlyLocal.Checked)
                {
                    WoCommerceDbService = new WoCommerceDbService(woCommerceDbSettings);
                }

                LocalDbService = new LocalDbService(localDbSettings);

                if (LocalDbService.IsConnectionSuccess() &&
                    (checkBoxOnlyLocal.Checked || WoCommerceDbService.IsConnectionSuccess()))
                {
                    ServerService = new ServerService(ip, checkBoxOnlyLocal.Checked);
                    ServerService.StartServer();
                    textBoxIp.Text = ip;

                    if (!checkBoxOnlyLocal.Checked)
                    {
                        Context.CurrentMaxId = await WoCommerceDbService.GetMaxOrderId();
                        timerOrderCheck.Enabled = true;
                    }
                    SetUiVisibility(UiVisibilityMode.WorkingMode);
                }
                else
                {
                    Toast.AlertError(Strings.ServerConnectError);
                    SetUiVisibility(UiVisibilityMode.SettingsMode);
                }
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
                SetUiVisibility(UiVisibilityMode.SettingsMode);
            }
        }

        private void InitializeSettings()
        {
            try
            {
                var woCommerceDbSettings = SettingsService.LoadWoCommerceDbSettings();
                textBoxAddressWc.Text = woCommerceDbSettings.Address;
                textBoxNameWc.Text = woCommerceDbSettings.Name;
                textBoxLoginWc.Text = woCommerceDbSettings.Login;
                textBoxPasswordWc.Text = woCommerceDbSettings.Password;

                var localDbSettings = SettingsService.LoaLocalDbSettings();
                textBoxAddressLocal.Text = localDbSettings.Address;
                textBoxNameLocal.Text = localDbSettings.Name;
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }

        private void InitializeNetworkInterfaces()
        {
            var interfaces = Network.GetNetworkInterfaces();

            if (interfaces.Count != 0)
            {
                interfaces.ForEach(i => NetworkInterfaceComboBox.Items.Add(i));
            }
            else
            {
                NetworkInterfaceComboBox.Items.Add(new ComboBoxItem
                {
                    Text = Strings.EmptyNetworkInterfaces,
                    Value = string.Empty
                });
            }

            NetworkInterfaceComboBox.SelectedIndex = 0;
        }

        private async void TimerOrderCheckTick(object sender, EventArgs e)
        {
            try
            {
                await MyBusinessService.GetOrderFromSite(LocalDbService, WoCommerceDbService, dataGridViewOrders).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }

        private void LoginFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var result = MessageBox.Show(Strings.CloseWindowQuestion, Strings.CloseWindowTitle,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    return;
                }
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }

        private void SetUiVisibility(UiVisibilityMode mode)
        {
            switch (mode)
            {
                case UiVisibilityMode.SettingsMode:
                    groupBoxWС.Show();
                    groupBoxLocal.Show();
                    groupBoxNetwork.Show();
                    groupBoxConnect.Show();
                    groupBoxSearch.Hide();
                    groupBoxInfo.Hide();
                    groupBoxOrders.Hide();
                    groupBoxCalls.Hide();
                    groupBoxSync.Hide();
                    break;
                case UiVisibilityMode.WorkingMode:
                    groupBoxWС.Hide();
                    groupBoxLocal.Hide();
                    groupBoxNetwork.Hide();
                    groupBoxConnect.Hide();
                    groupBoxSearch.Show();
                    groupBoxInfo.Show();
                    groupBoxOrders.Show();
                    groupBoxCalls.Show();
                    groupBoxSync.Show();
                    break;
                case UiVisibilityMode.HiddenMode:
                    groupBoxWС.Hide();
                    groupBoxLocal.Hide();
                    groupBoxNetwork.Hide();
                    groupBoxConnect.Hide();
                    groupBoxSearch.Hide();
                    groupBoxInfo.Hide();
                    groupBoxOrders.Hide();
                    groupBoxCalls.Hide();
                    break;
            }
        }

        private async void ButtonSearchClick(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxNameLocal.Text))
                {
                    await MyBusinessService.FindByPhone(LocalDbService, WoCommerceDbService, checkBoxOnlyLocal.Checked,
                        textBoxSearch.Text).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }

        private void TextBoxNameLocalClick(object sender, EventArgs e)
        {
            try
            {
                var openDialog = new OpenFileDialog
                {
                    Filter = Strings.OpenDialogFilter
                };

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxNameLocal.Text = openDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }

        private async void ButtonSyncClick(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxOnlyLocal.Checked)
                {
                    Toast.AlertError("Переподключитесь без режима \"Только локально\"");
                    return;
                }

                var startDate = dateTimePickerStartDate.Value;
                var endDate = dateTimePickerEndDate.Value;

                if (startDate >= endDate)
                {
                    Toast.AlertError("Дата начала должна быть меньше даты окончания");
                    return;
                }
                
                await MyBusinessService.Synchronization(LocalDbService, WoCommerceDbService, startDate, endDate).ConfigureAwait(false);

                Toast.AlertMessage("Синхронизация завершена");
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }
    }
}