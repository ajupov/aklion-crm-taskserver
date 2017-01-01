namespace Phonizer.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.NetworkInterfaceComboBox = new System.Windows.Forms.ComboBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.timerOrderCheck = new System.Windows.Forms.Timer(this.components);
            this.groupBoxWС = new System.Windows.Forms.GroupBox();
            this.labelServerWC = new System.Windows.Forms.Label();
            this.labelPasswordWC = new System.Windows.Forms.Label();
            this.textBoxLoginWc = new System.Windows.Forms.TextBox();
            this.textBoxPasswordWc = new System.Windows.Forms.TextBox();
            this.labelLoginWC = new System.Windows.Forms.Label();
            this.labelDbWC = new System.Windows.Forms.Label();
            this.textBoxNameWc = new System.Windows.Forms.TextBox();
            this.textBoxAddressWc = new System.Windows.Forms.TextBox();
            this.groupBoxSync = new System.Windows.Forms.GroupBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSync = new System.Windows.Forms.Button();
            this.groupBoxLocal = new System.Windows.Forms.GroupBox();
            this.labelDbLocal = new System.Windows.Forms.Label();
            this.textBoxNameLocal = new System.Windows.Forms.TextBox();
            this.textBoxAddressLocal = new System.Windows.Forms.TextBox();
            this.labelServerLocal = new System.Windows.Forms.Label();
            this.groupBoxNetwork = new System.Windows.Forms.GroupBox();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.checkBoxOnlyLocal = new System.Windows.Forms.CheckBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCalls = new System.Windows.Forms.GroupBox();
            this.dataGridViewCalls = new System.Windows.Forms.DataGridView();
            this.CallsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallsPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxWС.SuspendLayout();
            this.groupBoxSync.SuspendLayout();
            this.groupBoxLocal.SuspendLayout();
            this.groupBoxNetwork.SuspendLayout();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.groupBoxCalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(266, 16);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Checked = true;
            this.checkBoxRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemember.Location = new System.Drawing.Point(9, 19);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(82, 17);
            this.checkBoxRemember.TabIndex = 9;
            this.checkBoxRemember.Text = "Запомнить";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // NetworkInterfaceComboBox
            // 
            this.NetworkInterfaceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NetworkInterfaceComboBox.FormattingEnabled = true;
            this.NetworkInterfaceComboBox.Location = new System.Drawing.Point(9, 24);
            this.NetworkInterfaceComboBox.Name = "NetworkInterfaceComboBox";
            this.NetworkInterfaceComboBox.Size = new System.Drawing.Size(357, 21);
            this.NetworkInterfaceComboBox.TabIndex = 10;
            // 
            // labelIp
            // 
            this.labelIp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIp.Location = new System.Drawing.Point(194, 64);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(0, 20);
            this.labelIp.TabIndex = 13;
            this.labelIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerOrderCheck
            // 
            this.timerOrderCheck.Interval = 5000;
            this.timerOrderCheck.Tick += new System.EventHandler(this.TimerOrderCheckTick);
            // 
            // groupBoxWС
            // 
            this.groupBoxWС.Controls.Add(this.labelServerWC);
            this.groupBoxWС.Controls.Add(this.labelPasswordWC);
            this.groupBoxWС.Controls.Add(this.textBoxLoginWc);
            this.groupBoxWС.Controls.Add(this.textBoxPasswordWc);
            this.groupBoxWС.Controls.Add(this.labelLoginWC);
            this.groupBoxWС.Controls.Add(this.labelDbWC);
            this.groupBoxWС.Controls.Add(this.textBoxNameWc);
            this.groupBoxWС.Controls.Add(this.textBoxAddressWc);
            this.groupBoxWС.Location = new System.Drawing.Point(10, 12);
            this.groupBoxWС.Name = "groupBoxWС";
            this.groupBoxWС.Size = new System.Drawing.Size(380, 72);
            this.groupBoxWС.TabIndex = 2;
            this.groupBoxWС.TabStop = false;
            this.groupBoxWС.Text = "Wordpress БД";
            // 
            // labelServerWC
            // 
            this.labelServerWC.AutoSize = true;
            this.labelServerWC.Location = new System.Drawing.Point(6, 21);
            this.labelServerWC.Name = "labelServerWC";
            this.labelServerWC.Size = new System.Drawing.Size(47, 13);
            this.labelServerWC.TabIndex = 9;
            this.labelServerWC.Text = "Сервер:";
            // 
            // labelPasswordWC
            // 
            this.labelPasswordWC.AutoSize = true;
            this.labelPasswordWC.Location = new System.Drawing.Point(194, 47);
            this.labelPasswordWC.Name = "labelPasswordWC";
            this.labelPasswordWC.Size = new System.Drawing.Size(48, 13);
            this.labelPasswordWC.TabIndex = 16;
            this.labelPasswordWC.Text = "Пароль:";
            // 
            // textBoxLoginWc
            // 
            this.textBoxLoginWc.Location = new System.Drawing.Point(246, 18);
            this.textBoxLoginWc.Name = "textBoxLoginWc";
            this.textBoxLoginWc.Size = new System.Drawing.Size(120, 20);
            this.textBoxLoginWc.TabIndex = 15;
            // 
            // textBoxPasswordWc
            // 
            this.textBoxPasswordWc.Location = new System.Drawing.Point(246, 42);
            this.textBoxPasswordWc.Name = "textBoxPasswordWc";
            this.textBoxPasswordWc.PasswordChar = '*';
            this.textBoxPasswordWc.Size = new System.Drawing.Size(120, 20);
            this.textBoxPasswordWc.TabIndex = 14;
            // 
            // labelLoginWC
            // 
            this.labelLoginWC.AutoSize = true;
            this.labelLoginWC.Location = new System.Drawing.Point(194, 21);
            this.labelLoginWC.Name = "labelLoginWC";
            this.labelLoginWC.Size = new System.Drawing.Size(41, 13);
            this.labelLoginWC.TabIndex = 13;
            this.labelLoginWC.Text = "Логин:";
            // 
            // labelDbWC
            // 
            this.labelDbWC.AutoSize = true;
            this.labelDbWC.Location = new System.Drawing.Point(6, 45);
            this.labelDbWC.Name = "labelDbWC";
            this.labelDbWC.Size = new System.Drawing.Size(51, 13);
            this.labelDbWC.TabIndex = 12;
            this.labelDbWC.Text = "Имя БД:";
            // 
            // textBoxNameWc
            // 
            this.textBoxNameWc.Location = new System.Drawing.Point(68, 42);
            this.textBoxNameWc.Name = "textBoxNameWc";
            this.textBoxNameWc.Size = new System.Drawing.Size(120, 20);
            this.textBoxNameWc.TabIndex = 11;
            // 
            // textBoxAddressWc
            // 
            this.textBoxAddressWc.Location = new System.Drawing.Point(68, 18);
            this.textBoxAddressWc.Name = "textBoxAddressWc";
            this.textBoxAddressWc.Size = new System.Drawing.Size(120, 20);
            this.textBoxAddressWc.TabIndex = 10;
            // 
            // groupBoxSync
            // 
            this.groupBoxSync.Controls.Add(this.labelEndDate);
            this.groupBoxSync.Controls.Add(this.labelStartDate);
            this.groupBoxSync.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxSync.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxSync.Controls.Add(this.buttonSync);
            this.groupBoxSync.Location = new System.Drawing.Point(8, 72);
            this.groupBoxSync.Name = "groupBoxSync";
            this.groupBoxSync.Size = new System.Drawing.Size(775, 48);
            this.groupBoxSync.TabIndex = 0;
            this.groupBoxSync.TabStop = false;
            this.groupBoxSync.Text = "Синхронизация";
            this.groupBoxSync.Visible = false;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(324, 20);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(92, 13);
            this.labelEndDate.TabIndex = 25;
            this.labelEndDate.Text = "Дата окончания:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(8, 20);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(74, 13);
            this.labelStartDate.TabIndex = 24;
            this.labelStartDate.Text = "Дата начала:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(437, 16);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 23;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(103, 16);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 22;
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(658, 15);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(101, 23);
            this.buttonSync.TabIndex = 21;
            this.buttonSync.Text = "Синхронизация";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.ButtonSyncClick);
            // 
            // groupBoxLocal
            // 
            this.groupBoxLocal.Controls.Add(this.labelDbLocal);
            this.groupBoxLocal.Controls.Add(this.textBoxNameLocal);
            this.groupBoxLocal.Controls.Add(this.textBoxAddressLocal);
            this.groupBoxLocal.Controls.Add(this.labelServerLocal);
            this.groupBoxLocal.Location = new System.Drawing.Point(403, 12);
            this.groupBoxLocal.Name = "groupBoxLocal";
            this.groupBoxLocal.Size = new System.Drawing.Size(380, 72);
            this.groupBoxLocal.TabIndex = 2;
            this.groupBoxLocal.TabStop = false;
            this.groupBoxLocal.Text = "Локальная БД";
            // 
            // labelDbLocal
            // 
            this.labelDbLocal.AutoSize = true;
            this.labelDbLocal.Location = new System.Drawing.Point(6, 45);
            this.labelDbLocal.Name = "labelDbLocal";
            this.labelDbLocal.Size = new System.Drawing.Size(62, 13);
            this.labelDbLocal.TabIndex = 12;
            this.labelDbLocal.Text = "Путь к БД:";
            // 
            // textBoxNameLocal
            // 
            this.textBoxNameLocal.Location = new System.Drawing.Point(68, 42);
            this.textBoxNameLocal.Name = "textBoxNameLocal";
            this.textBoxNameLocal.Size = new System.Drawing.Size(298, 20);
            this.textBoxNameLocal.TabIndex = 11;
            this.textBoxNameLocal.Click += new System.EventHandler(this.TextBoxNameLocalClick);
            // 
            // textBoxAddressLocal
            // 
            this.textBoxAddressLocal.Location = new System.Drawing.Point(68, 18);
            this.textBoxAddressLocal.Name = "textBoxAddressLocal";
            this.textBoxAddressLocal.Size = new System.Drawing.Size(298, 20);
            this.textBoxAddressLocal.TabIndex = 10;
            // 
            // labelServerLocal
            // 
            this.labelServerLocal.AutoSize = true;
            this.labelServerLocal.Location = new System.Drawing.Point(6, 21);
            this.labelServerLocal.Name = "labelServerLocal";
            this.labelServerLocal.Size = new System.Drawing.Size(47, 13);
            this.labelServerLocal.TabIndex = 9;
            this.labelServerLocal.Text = "Сервер:";
            // 
            // groupBoxNetwork
            // 
            this.groupBoxNetwork.Controls.Add(this.NetworkInterfaceComboBox);
            this.groupBoxNetwork.Location = new System.Drawing.Point(10, 90);
            this.groupBoxNetwork.Name = "groupBoxNetwork";
            this.groupBoxNetwork.Size = new System.Drawing.Size(380, 56);
            this.groupBoxNetwork.TabIndex = 18;
            this.groupBoxNetwork.TabStop = false;
            this.groupBoxNetwork.Text = "Сетевой интерфейс";
            // 
            // textBoxIp
            // 
            this.textBoxIp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIp.Location = new System.Drawing.Point(6, 19);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.ReadOnly = true;
            this.textBoxIp.Size = new System.Drawing.Size(357, 24);
            this.textBoxIp.TabIndex = 19;
            this.textBoxIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.checkBoxOnlyLocal);
            this.groupBoxConnect.Controls.Add(this.buttonConnect);
            this.groupBoxConnect.Controls.Add(this.checkBoxRemember);
            this.groupBoxConnect.Location = new System.Drawing.Point(403, 96);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(380, 50);
            this.groupBoxConnect.TabIndex = 20;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Подключение";
            // 
            // checkBoxOnlyLocal
            // 
            this.checkBoxOnlyLocal.AutoSize = true;
            this.checkBoxOnlyLocal.Location = new System.Drawing.Point(97, 19);
            this.checkBoxOnlyLocal.Name = "checkBoxOnlyLocal";
            this.checkBoxOnlyLocal.Size = new System.Drawing.Size(76, 17);
            this.checkBoxOnlyLocal.TabIndex = 20;
            this.checkBoxOnlyLocal.Text = "Локально";
            this.checkBoxOnlyLocal.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.labelPhone);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(402, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(380, 54);
            this.groupBoxSearch.TabIndex = 23;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            this.groupBoxSearch.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(266, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(6, 21);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(62, 18);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(198, 20);
            this.textBoxSearch.TabIndex = 17;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.textBoxIp);
            this.groupBoxInfo.Location = new System.Drawing.Point(8, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(382, 54);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Для подключения к серверу укажите IP-адрес: ";
            this.groupBoxInfo.Visible = false;
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.Controls.Add(this.dataGridViewOrders);
            this.groupBoxOrders.Location = new System.Drawing.Point(8, 126);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(775, 265);
            this.groupBoxOrders.TabIndex = 24;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Заказы";
            this.groupBoxOrders.Visible = false;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.CustomerName,
            this.Phone,
            this.Email,
            this.Street,
            this.HouseNumber,
            this.OrderItems,
            this.OrderSum,
            this.Note,
            this.PaymentMethod});
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.Size = new System.Drawing.Size(769, 246);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "№";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата/Время";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Имя";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Street
            // 
            this.Street.HeaderText = "Адрес";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            // 
            // HouseNumber
            // 
            this.HouseNumber.HeaderText = "Добав.";
            this.HouseNumber.Name = "HouseNumber";
            this.HouseNumber.ReadOnly = true;
            // 
            // OrderItems
            // 
            this.OrderItems.HeaderText = "Содержимое заказа";
            this.OrderItems.Name = "OrderItems";
            this.OrderItems.ReadOnly = true;
            // 
            // OrderSum
            // 
            this.OrderSum.HeaderText = "Сумма";
            this.OrderSum.Name = "OrderSum";
            this.OrderSum.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Примечание";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Метод платежа";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // groupBoxCalls
            // 
            this.groupBoxCalls.Controls.Add(this.dataGridViewCalls);
            this.groupBoxCalls.Location = new System.Drawing.Point(10, 397);
            this.groupBoxCalls.Name = "groupBoxCalls";
            this.groupBoxCalls.Size = new System.Drawing.Size(775, 250);
            this.groupBoxCalls.TabIndex = 25;
            this.groupBoxCalls.TabStop = false;
            this.groupBoxCalls.Text = "Запросы номера";
            this.groupBoxCalls.Visible = false;
            // 
            // dataGridViewCalls
            // 
            this.dataGridViewCalls.AllowUserToAddRows = false;
            this.dataGridViewCalls.AllowUserToDeleteRows = false;
            this.dataGridViewCalls.AllowUserToResizeRows = false;
            this.dataGridViewCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CallsDate,
            this.CallsPhone,
            this.CallsName});
            this.dataGridViewCalls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCalls.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCalls.Name = "dataGridViewCalls";
            this.dataGridViewCalls.ReadOnly = true;
            this.dataGridViewCalls.RowHeadersVisible = false;
            this.dataGridViewCalls.Size = new System.Drawing.Size(769, 231);
            this.dataGridViewCalls.TabIndex = 1;
            // 
            // CallsDate
            // 
            this.CallsDate.HeaderText = "Дата/Время";
            this.CallsDate.Name = "CallsDate";
            this.CallsDate.ReadOnly = true;
            // 
            // CallsPhone
            // 
            this.CallsPhone.HeaderText = "Телефон";
            this.CallsPhone.Name = "CallsPhone";
            this.CallsPhone.ReadOnly = true;
            // 
            // CallsName
            // 
            this.CallsName.HeaderText = "Имя";
            this.CallsName.Name = "CallsName";
            this.CallsName.ReadOnly = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 661);
            this.Controls.Add(this.groupBoxSync);
            this.Controls.Add(this.groupBoxCalls);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxLocal);
            this.Controls.Add(this.groupBoxWС);
            this.Controls.Add(this.groupBoxConnect);
            this.Controls.Add(this.groupBoxNetwork);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.groupBoxOrders);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 700);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormClosing);
            this.groupBoxWС.ResumeLayout(false);
            this.groupBoxWС.PerformLayout();
            this.groupBoxSync.ResumeLayout(false);
            this.groupBoxSync.PerformLayout();
            this.groupBoxLocal.ResumeLayout(false);
            this.groupBoxLocal.PerformLayout();
            this.groupBoxNetwork.ResumeLayout(false);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.groupBoxCalls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.ComboBox NetworkInterfaceComboBox;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Timer timerOrderCheck;
        private System.Windows.Forms.GroupBox groupBoxWС;
        private System.Windows.Forms.Label labelPasswordWC;
        private System.Windows.Forms.TextBox textBoxLoginWc;
        private System.Windows.Forms.TextBox textBoxPasswordWc;
        private System.Windows.Forms.Label labelLoginWC;
        private System.Windows.Forms.Label labelDbWC;
        private System.Windows.Forms.TextBox textBoxNameWc;
        private System.Windows.Forms.TextBox textBoxAddressWc;
        private System.Windows.Forms.Label labelServerWC;
        private System.Windows.Forms.GroupBox groupBoxLocal;
        private System.Windows.Forms.Label labelDbLocal;
        private System.Windows.Forms.TextBox textBoxNameLocal;
        private System.Windows.Forms.TextBox textBoxAddressLocal;
        private System.Windows.Forms.Label labelServerLocal;
        private System.Windows.Forms.GroupBox groupBoxNetwork;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.CheckBox checkBoxOnlyLocal;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.GroupBox groupBoxCalls;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.GroupBox groupBoxSync;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DataGridView dataGridViewCalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallsPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallsName;
    }
}

