namespace MEGACASTING.Vues
{
    partial class Client
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxSiret = new System.Windows.Forms.TextBox();
            this.labelSiret = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelContrat = new System.Windows.Forms.Label();
            this.comboBoxContract = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.AllowUserToResizeColumns = false;
            this.dataGridViewClient.AllowUserToResizeRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identifiant,
            this.Nom,
            this.Mail,
            this.Telephone,
            this.Login,
            this.Password,
            this.Url,
            this.Siret,
            this.City,
            this.Contrat});
            this.dataGridViewClient.GridColor = System.Drawing.Color.Black;
            this.dataGridViewClient.Location = new System.Drawing.Point(31, 56);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClient.RowHeadersVisible = false;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 29;
            this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClient.Size = new System.Drawing.Size(672, 343);
            this.dataGridViewClient.TabIndex = 1;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartenaire_CellClick);
            // 
            // Identifiant
            // 
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.MinimumWidth = 6;
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.ReadOnly = true;
            this.Identifiant.Width = 65;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 65;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.MinimumWidth = 6;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 65;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            this.Telephone.Width = 65;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 50;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 65;
            // 
            // Url
            // 
            this.Url.HeaderText = "Url";
            this.Url.MinimumWidth = 6;
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Width = 50;
            // 
            // Siret
            // 
            this.Siret.HeaderText = "Siret";
            this.Siret.MinimumWidth = 6;
            this.Siret.Name = "Siret";
            this.Siret.ReadOnly = true;
            this.Siret.Width = 50;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 65;
            // 
            // Contrat
            // 
            this.Contrat.HeaderText = "Contrat";
            this.Contrat.MinimumWidth = 6;
            this.Contrat.Name = "Contrat";
            this.Contrat.ReadOnly = true;
            this.Contrat.Width = 65;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouter.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAjouter.Location = new System.Drawing.Point(172, 461);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(167, 61);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModifier.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonModifier.FlatAppearance.BorderSize = 0;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.ForeColor = System.Drawing.Color.Transparent;
            this.buttonModifier.Location = new System.Drawing.Point(396, 461);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(167, 61);
            this.buttonModifier.TabIndex = 4;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSupprimer.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSupprimer.Location = new System.Drawing.Point(627, 461);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(167, 61);
            this.buttonSupprimer.TabIndex = 5;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(817, 56);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(817, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMail.Location = new System.Drawing.Point(817, 133);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(125, 27);
            this.textBoxMail.TabIndex = 8;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTel.Location = new System.Drawing.Point(817, 171);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(125, 27);
            this.textBoxTel.TabIndex = 9;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(726, 56);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 20);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID :";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(726, 93);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Nom :";
            // 
            // labelMail
            // 
            this.labelMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(726, 133);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(45, 20);
            this.labelMail.TabIndex = 12;
            this.labelMail.Text = "Mail :";
            // 
            // labelTel
            // 
            this.labelTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(726, 171);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(85, 20);
            this.labelTel.TabIndex = 13;
            this.labelTel.Text = "Telephone :";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.Location = new System.Drawing.Point(817, 208);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(125, 27);
            this.textBoxLogin.TabIndex = 14;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(726, 208);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 20);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Login :";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(726, 240);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 20);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(817, 240);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxPassword.TabIndex = 17;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUrl.Location = new System.Drawing.Point(817, 273);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(125, 27);
            this.textBoxUrl.TabIndex = 18;
            // 
            // labelUrl
            // 
            this.labelUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(726, 273);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(35, 20);
            this.labelUrl.TabIndex = 19;
            this.labelUrl.Text = "Url :";
            // 
            // textBoxSiret
            // 
            this.textBoxSiret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSiret.Location = new System.Drawing.Point(817, 308);
            this.textBoxSiret.Name = "textBoxSiret";
            this.textBoxSiret.Size = new System.Drawing.Size(125, 27);
            this.textBoxSiret.TabIndex = 20;
            // 
            // labelSiret
            // 
            this.labelSiret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSiret.AutoSize = true;
            this.labelSiret.Location = new System.Drawing.Point(726, 308);
            this.labelSiret.Name = "labelSiret";
            this.labelSiret.Size = new System.Drawing.Size(46, 20);
            this.labelSiret.TabIndex = 21;
            this.labelSiret.Text = "Siret :";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCity.Location = new System.Drawing.Point(817, 343);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(125, 27);
            this.textBoxCity.TabIndex = 22;
            // 
            // labelCity
            // 
            this.labelCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(726, 343);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(41, 20);
            this.labelCity.TabIndex = 23;
            this.labelCity.Text = "City :";
            // 
            // labelContrat
            // 
            this.labelContrat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContrat.AutoSize = true;
            this.labelContrat.Location = new System.Drawing.Point(726, 379);
            this.labelContrat.Name = "labelContrat";
            this.labelContrat.Size = new System.Drawing.Size(65, 20);
            this.labelContrat.TabIndex = 25;
            this.labelContrat.Text = "Contrat :";
            // 
            // comboBoxContract
            // 
            this.comboBoxContract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContract.FormattingEnabled = true;
            this.comboBoxContract.Location = new System.Drawing.Point(817, 377);
            this.comboBoxContract.Name = "comboBoxContract";
            this.comboBoxContract.Size = new System.Drawing.Size(125, 28);
            this.comboBoxContract.TabIndex = 28;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 555);
            this.Controls.Add(this.comboBoxContract);
            this.Controls.Add(this.labelContrat);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelSiret);
            this.Controls.Add(this.textBoxSiret);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dataGridViewClient);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewClient;
        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxMail;
        private TextBox textBoxTel;
        private Label labelID;
        private Label labelName;
        private Label labelMail;
        private Label labelTel;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUrl;
        private Label labelUrl;
        private TextBox textBoxSiret;
        private Label labelSiret;
        private TextBox textBoxCity;
        private Label labelCity;
        private Label labelContrat;
        private ComboBox comboBoxContract;
        private DataGridViewTextBoxColumn Identifiant;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Url;
        private DataGridViewTextBoxColumn Siret;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Contrat;
    }
}