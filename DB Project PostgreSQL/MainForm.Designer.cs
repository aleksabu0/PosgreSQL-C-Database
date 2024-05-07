namespace DB_Project_PostgreSQL
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EconomyDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.ButtonQuerry1 = new System.Windows.Forms.Button();
            this.GdpInput = new System.Windows.Forms.TextBox();
            this.checkGdpLarger = new System.Windows.Forms.CheckBox();
            this.filterDropdown = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sortDropdown = new System.Windows.Forms.ComboBox();
            this.sortCheckbox = new System.Windows.Forms.CheckBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.adressInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.updateCountryButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.popTextInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.accountTextInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.debtTextInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.govTextInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.joblessTextInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inflationTextInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.interestTextInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gdpQuarterTextInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gdpYearTextInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gdpTextInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countryTextInput = new System.Windows.Forms.TextBox();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.showInputPanel = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();
            this.deleteCountryPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.deleteCountryNameInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EconomyDataGrid)).BeginInit();
            this.inputPanel.SuspendLayout();
            this.deleteCountryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EconomyDataGrid
            // 
            this.EconomyDataGrid.BackgroundColor = System.Drawing.Color.Ivory;
            this.EconomyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EconomyDataGrid.Location = new System.Drawing.Point(520, 32);
            this.EconomyDataGrid.Name = "EconomyDataGrid";
            this.EconomyDataGrid.Size = new System.Drawing.Size(880, 617);
            this.EconomyDataGrid.TabIndex = 1;
            this.EconomyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(66, 71);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(154, 59);
            this.buttonShowData.TabIndex = 0;
            this.buttonShowData.Text = "Show Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.button_showData_click);
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // ButtonQuerry1
            // 
            this.ButtonQuerry1.Location = new System.Drawing.Point(66, 177);
            this.ButtonQuerry1.Name = "ButtonQuerry1";
            this.ButtonQuerry1.Size = new System.Drawing.Size(154, 59);
            this.ButtonQuerry1.TabIndex = 2;
            this.ButtonQuerry1.Text = "Filter By";
            this.ButtonQuerry1.UseVisualStyleBackColor = true;
            this.ButtonQuerry1.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // GdpInput
            // 
            this.GdpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GdpInput.Location = new System.Drawing.Point(66, 318);
            this.GdpInput.Name = "GdpInput";
            this.GdpInput.Size = new System.Drawing.Size(154, 26);
            this.GdpInput.TabIndex = 3;
            this.GdpInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkGdpLarger
            // 
            this.checkGdpLarger.AutoSize = true;
            this.checkGdpLarger.Location = new System.Drawing.Point(99, 371);
            this.checkGdpLarger.Name = "checkGdpLarger";
            this.checkGdpLarger.Size = new System.Drawing.Size(94, 17);
            this.checkGdpLarger.TabIndex = 4;
            this.checkGdpLarger.Text = "Check if larger";
            this.checkGdpLarger.UseVisualStyleBackColor = true;
            // 
            // filterDropdown
            // 
            this.filterDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDropdown.FormattingEnabled = true;
            this.filterDropdown.Location = new System.Drawing.Point(66, 263);
            this.filterDropdown.Name = "filterDropdown";
            this.filterDropdown.Size = new System.Drawing.Size(154, 28);
            this.filterDropdown.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sort By";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // sortDropdown
            // 
            this.sortDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortDropdown.FormattingEnabled = true;
            this.sortDropdown.Location = new System.Drawing.Point(314, 263);
            this.sortDropdown.Name = "sortDropdown";
            this.sortDropdown.Size = new System.Drawing.Size(154, 28);
            this.sortDropdown.TabIndex = 7;
            this.sortDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sortCheckbox
            // 
            this.sortCheckbox.AutoSize = true;
            this.sortCheckbox.Location = new System.Drawing.Point(352, 318);
            this.sortCheckbox.Name = "sortCheckbox";
            this.sortCheckbox.Size = new System.Drawing.Size(76, 17);
            this.sortCheckbox.TabIndex = 8;
            this.sortCheckbox.Text = "Ascending";
            this.sortCheckbox.UseVisualStyleBackColor = true;
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.updateCountryButton);
            this.inputPanel.Controls.Add(this.label11);
            this.inputPanel.Controls.Add(this.popTextInput);
            this.inputPanel.Controls.Add(this.label10);
            this.inputPanel.Controls.Add(this.accountTextInput);
            this.inputPanel.Controls.Add(this.label9);
            this.inputPanel.Controls.Add(this.debtTextInput);
            this.inputPanel.Controls.Add(this.label8);
            this.inputPanel.Controls.Add(this.govTextInput);
            this.inputPanel.Controls.Add(this.label7);
            this.inputPanel.Controls.Add(this.joblessTextInput);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.inflationTextInput);
            this.inputPanel.Controls.Add(this.label5);
            this.inputPanel.Controls.Add(this.interestTextInput);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.gdpQuarterTextInput);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.gdpYearTextInput);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.gdpTextInput);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.countryTextInput);
            this.inputPanel.Controls.Add(this.addCountryButton);
            this.inputPanel.Location = new System.Drawing.Point(578, 71);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(381, 512);
            this.inputPanel.TabIndex = 9;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(347, 209);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(114, 48);
            this.loginButton.TabIndex = 37;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // adressInput
            // 
            this.adressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressInput.Location = new System.Drawing.Point(326, 162);
            this.adressInput.Name = "adressInput";
            this.adressInput.Size = new System.Drawing.Size(163, 26);
            this.adressInput.TabIndex = 36;
            this.adressInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adressInput.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // passInput
            // 
            this.passInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.Location = new System.Drawing.Point(326, 114);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(163, 26);
            this.passInput.TabIndex = 35;
            this.passInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(326, 72);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(163, 26);
            this.nameInput.TabIndex = 34;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // updateCountryButton
            // 
            this.updateCountryButton.Location = new System.Drawing.Point(230, 445);
            this.updateCountryButton.Name = "updateCountryButton";
            this.updateCountryButton.Size = new System.Drawing.Size(114, 48);
            this.updateCountryButton.TabIndex = 33;
            this.updateCountryButton.Text = "Update Country";
            this.updateCountryButton.UseVisualStyleBackColor = true;
            this.updateCountryButton.Click += new System.EventHandler(this.updateCountryButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Population";
            // 
            // popTextInput
            // 
            this.popTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popTextInput.Location = new System.Drawing.Point(172, 377);
            this.popTextInput.Name = "popTextInput";
            this.popTextInput.Size = new System.Drawing.Size(154, 26);
            this.popTextInput.TabIndex = 31;
            this.popTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Current Account";
            // 
            // accountTextInput
            // 
            this.accountTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextInput.Location = new System.Drawing.Point(172, 345);
            this.accountTextInput.Name = "accountTextInput";
            this.accountTextInput.Size = new System.Drawing.Size(154, 26);
            this.accountTextInput.TabIndex = 29;
            this.accountTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Debt/GDP";
            // 
            // debtTextInput
            // 
            this.debtTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtTextInput.Location = new System.Drawing.Point(172, 313);
            this.debtTextInput.Name = "debtTextInput";
            this.debtTextInput.Size = new System.Drawing.Size(154, 26);
            this.debtTextInput.TabIndex = 27;
            this.debtTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Gov Budget";
            // 
            // govTextInput
            // 
            this.govTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.govTextInput.Location = new System.Drawing.Point(172, 281);
            this.govTextInput.Name = "govTextInput";
            this.govTextInput.Size = new System.Drawing.Size(154, 26);
            this.govTextInput.TabIndex = 25;
            this.govTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Jobless Rate";
            // 
            // joblessTextInput
            // 
            this.joblessTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joblessTextInput.Location = new System.Drawing.Point(172, 249);
            this.joblessTextInput.Name = "joblessTextInput";
            this.joblessTextInput.Size = new System.Drawing.Size(154, 26);
            this.joblessTextInput.TabIndex = 23;
            this.joblessTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Inflation Rate";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // inflationTextInput
            // 
            this.inflationTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inflationTextInput.Location = new System.Drawing.Point(172, 215);
            this.inflationTextInput.Name = "inflationTextInput";
            this.inflationTextInput.Size = new System.Drawing.Size(154, 26);
            this.inflationTextInput.TabIndex = 21;
            this.inflationTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inflationTextInput.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Interest Rate";
            // 
            // interestTextInput
            // 
            this.interestTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestTextInput.Location = new System.Drawing.Point(172, 177);
            this.interestTextInput.Name = "interestTextInput";
            this.interestTextInput.Size = new System.Drawing.Size(154, 26);
            this.interestTextInput.TabIndex = 19;
            this.interestTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "GDP by Quarter";
            // 
            // gdpQuarterTextInput
            // 
            this.gdpQuarterTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdpQuarterTextInput.Location = new System.Drawing.Point(172, 141);
            this.gdpQuarterTextInput.Name = "gdpQuarterTextInput";
            this.gdpQuarterTextInput.Size = new System.Drawing.Size(154, 26);
            this.gdpQuarterTextInput.TabIndex = 17;
            this.gdpQuarterTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "GDP by Year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gdpYearTextInput
            // 
            this.gdpYearTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdpYearTextInput.Location = new System.Drawing.Point(172, 102);
            this.gdpYearTextInput.Name = "gdpYearTextInput";
            this.gdpYearTextInput.Size = new System.Drawing.Size(154, 26);
            this.gdpYearTextInput.TabIndex = 15;
            this.gdpYearTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gdpYearTextInput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "GDP";
            // 
            // gdpTextInput
            // 
            this.gdpTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdpTextInput.Location = new System.Drawing.Point(172, 64);
            this.gdpTextInput.Name = "gdpTextInput";
            this.gdpTextInput.Size = new System.Drawing.Size(154, 26);
            this.gdpTextInput.TabIndex = 13;
            this.gdpTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Country Name";
            // 
            // countryTextInput
            // 
            this.countryTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextInput.Location = new System.Drawing.Point(172, 32);
            this.countryTextInput.Name = "countryTextInput";
            this.countryTextInput.Size = new System.Drawing.Size(154, 26);
            this.countryTextInput.TabIndex = 11;
            this.countryTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addCountryButton
            // 
            this.addCountryButton.Location = new System.Drawing.Point(47, 445);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.Size = new System.Drawing.Size(114, 48);
            this.addCountryButton.TabIndex = 0;
            this.addCountryButton.Text = "Add Country";
            this.addCountryButton.UseVisualStyleBackColor = true;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // showInputPanel
            // 
            this.showInputPanel.Location = new System.Drawing.Point(66, 506);
            this.showInputPanel.Name = "showInputPanel";
            this.showInputPanel.Size = new System.Drawing.Size(154, 59);
            this.showInputPanel.TabIndex = 10;
            this.showInputPanel.Text = "New Country /\r\nUpdate Country";
            this.showInputPanel.UseVisualStyleBackColor = true;
            this.showInputPanel.Click += new System.EventHandler(this.showInputPanel_Click);
            // 
            // deleteCountryButton
            // 
            this.deleteCountryButton.Location = new System.Drawing.Point(289, 506);
            this.deleteCountryButton.Name = "deleteCountryButton";
            this.deleteCountryButton.Size = new System.Drawing.Size(154, 59);
            this.deleteCountryButton.TabIndex = 11;
            this.deleteCountryButton.Text = "Delete Country";
            this.deleteCountryButton.UseVisualStyleBackColor = true;
            this.deleteCountryButton.Click += new System.EventHandler(this.deleteCountryPanelButton_Click);
            // 
            // deleteCountryPanel
            // 
            this.deleteCountryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteCountryPanel.Controls.Add(this.deleteButton);
            this.deleteCountryPanel.Controls.Add(this.label22);
            this.deleteCountryPanel.Controls.Add(this.deleteCountryNameInput);
            this.deleteCountryPanel.Location = new System.Drawing.Point(977, 449);
            this.deleteCountryPanel.Name = "deleteCountryPanel";
            this.deleteCountryPanel.Size = new System.Drawing.Size(381, 134);
            this.deleteCountryPanel.TabIndex = 34;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(138, 67);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 48);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "Delete Country";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(38, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 20);
            this.label22.TabIndex = 12;
            this.label22.Text = "Country Name";
            // 
            // deleteCountryNameInput
            // 
            this.deleteCountryNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCountryNameInput.Location = new System.Drawing.Point(174, 17);
            this.deleteCountryNameInput.Name = "deleteCountryNameInput";
            this.deleteCountryNameInput.Size = new System.Drawing.Size(154, 26);
            this.deleteCountryNameInput.TabIndex = 11;
            this.deleteCountryNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(226, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Username";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(226, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Password";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(226, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Adress";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 675);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.adressInput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.deleteCountryPanel);
            this.Controls.Add(this.deleteCountryButton);
            this.Controls.Add(this.showInputPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.sortCheckbox);
            this.Controls.Add(this.sortDropdown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterDropdown);
            this.Controls.Add(this.checkGdpLarger);
            this.Controls.Add(this.GdpInput);
            this.Controls.Add(this.ButtonQuerry1);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.EconomyDataGrid);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EconomyDataGrid)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.deleteCountryPanel.ResumeLayout(false);
            this.deleteCountryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView EconomyDataGrid;
        private System.Windows.Forms.Button buttonShowData;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Button ButtonQuerry1;
        private System.Windows.Forms.TextBox GdpInput;
        private System.Windows.Forms.CheckBox checkGdpLarger;
        private System.Windows.Forms.ComboBox filterDropdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox sortDropdown;
        private System.Windows.Forms.CheckBox sortCheckbox;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.Button showInputPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox joblessTextInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inflationTextInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox interestTextInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gdpQuarterTextInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gdpYearTextInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gdpTextInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryTextInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox popTextInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox accountTextInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox debtTextInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox govTextInput;
        private System.Windows.Forms.Button updateCountryButton;
        private System.Windows.Forms.Button deleteCountryButton;
        private System.Windows.Forms.Panel deleteCountryPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox deleteCountryNameInput;
        private System.Windows.Forms.TextBox adressInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button loginButton;
    }
}

