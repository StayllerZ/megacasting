namespace MEGACASTING.Vues
{
    partial class Partenaire
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
            this.dataGridViewPartenaire = new System.Windows.Forms.DataGridView();
            this.Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartenaire)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPartenaire
            // 
            this.dataGridViewPartenaire.AllowUserToAddRows = false;
            this.dataGridViewPartenaire.AllowUserToDeleteRows = false;
            this.dataGridViewPartenaire.AllowUserToResizeColumns = false;
            this.dataGridViewPartenaire.AllowUserToResizeRows = false;
            this.dataGridViewPartenaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPartenaire.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPartenaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPartenaire.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPartenaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartenaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identifiant,
            this.Nom,
            this.Mail,
            this.Telephone});
            this.dataGridViewPartenaire.GridColor = System.Drawing.Color.Black;
            this.dataGridViewPartenaire.Location = new System.Drawing.Point(88, 72);
            this.dataGridViewPartenaire.Name = "dataGridViewPartenaire";
            this.dataGridViewPartenaire.ReadOnly = true;
            this.dataGridViewPartenaire.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPartenaire.RowHeadersVisible = false;
            this.dataGridViewPartenaire.RowHeadersWidth = 51;
            this.dataGridViewPartenaire.RowTemplate.Height = 29;
            this.dataGridViewPartenaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPartenaire.Size = new System.Drawing.Size(495, 323);
            this.dataGridViewPartenaire.TabIndex = 0;
            this.dataGridViewPartenaire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartenaire_CellClick);
            // 
            // Identifiant
            // 
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.MinimumWidth = 6;
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.ReadOnly = true;
            this.Identifiant.Width = 85;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 90;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mail.HeaderText = "Mail";
            this.Mail.MinimumWidth = 6;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            this.Telephone.Width = 125;
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
            this.buttonAjouter.TabIndex = 1;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
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
            this.buttonSupprimer.TabIndex = 2;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
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
            this.buttonModifier.TabIndex = 3;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(722, 160);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMail.Location = new System.Drawing.Point(722, 211);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(125, 27);
            this.textBoxMail.TabIndex = 6;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTel.Location = new System.Drawing.Point(722, 256);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(125, 27);
            this.textBoxTel.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(627, 167);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Nom :";
            // 
            // labelMail
            // 
            this.labelMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(627, 211);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(45, 20);
            this.labelMail.TabIndex = 10;
            this.labelMail.Text = "Mail :";
            // 
            // labelTel
            // 
            this.labelTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(627, 256);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(85, 20);
            this.labelTel.TabIndex = 11;
            this.labelTel.Text = "Telephone :";
            // 
            // Partenaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 555);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dataGridViewPartenaire);
            this.Name = "Partenaire";
            this.Text = "Partenaire";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartenaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewPartenaire;
        private Button buttonAjouter;
        private Button buttonSupprimer;
        private Button buttonModifier;
        private TextBox textBoxName;
        private TextBox textBoxMail;
        private TextBox textBoxTel;
        private Label labelName;
        private Label labelMail;
        private Label labelTel;
        private DataGridViewTextBoxColumn Identifiant;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewTextBoxColumn Telephone;
    }
}