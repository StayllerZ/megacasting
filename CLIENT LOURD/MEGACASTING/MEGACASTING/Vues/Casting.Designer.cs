﻿namespace MEGACASTING.Vues
{
    partial class Casting
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
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.Libelle,
            this.Debut,
            this.Fin,
            this.Reference,
            this.Ville,
            this.AgeMin,
            this.AgeMax,
            this.Date,
            this.Desc,
            this.Client,
            this.Metier,
            this.Contrat});
            this.dataGridViewClient.GridColor = System.Drawing.Color.Black;
            this.dataGridViewClient.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClient.RowHeadersVisible = false;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 29;
            this.dataGridViewClient.Size = new System.Drawing.Size(795, 343);
            this.dataGridViewClient.TabIndex = 2;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // Identifiant
            // 
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.MinimumWidth = 6;
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.ReadOnly = true;
            this.Identifiant.Width = 65;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.MinimumWidth = 6;
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            this.Libelle.Width = 65;
            // 
            // Debut
            // 
            this.Debut.HeaderText = "Debut";
            this.Debut.MinimumWidth = 6;
            this.Debut.Name = "Debut";
            this.Debut.ReadOnly = true;
            this.Debut.Width = 65;
            // 
            // Fin
            // 
            this.Fin.HeaderText = "Fin";
            this.Fin.MinimumWidth = 6;
            this.Fin.Name = "Fin";
            this.Fin.ReadOnly = true;
            this.Fin.Width = 65;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.MinimumWidth = 6;
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 50;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.MinimumWidth = 6;
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            this.Ville.Width = 65;
            // 
            // AgeMin
            // 
            this.AgeMin.HeaderText = "AgeMin";
            this.AgeMin.MinimumWidth = 6;
            this.AgeMin.Name = "AgeMin";
            this.AgeMin.ReadOnly = true;
            this.AgeMin.Width = 50;
            // 
            // AgeMax
            // 
            this.AgeMax.HeaderText = "AgeMax";
            this.AgeMax.MinimumWidth = 6;
            this.AgeMax.Name = "AgeMax";
            this.AgeMax.ReadOnly = true;
            this.AgeMax.Width = 50;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 65;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Desc";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 65;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 65;
            // 
            // Metier
            // 
            this.Metier.HeaderText = "Metier";
            this.Metier.MinimumWidth = 6;
            this.Metier.Name = "Metier";
            this.Metier.ReadOnly = true;
            this.Metier.Width = 65;
            // 
            // Contrat
            // 
            this.Contrat.HeaderText = "Contrat";
            this.Contrat.MinimumWidth = 6;
            this.Contrat.Name = "Contrat";
            this.Contrat.ReadOnly = true;
            this.Contrat.Width = 55;
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(813, 51);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(813, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(813, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(813, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(813, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(813, 216);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Location = new System.Drawing.Point(813, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.Location = new System.Drawing.Point(813, 282);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 27);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.Location = new System.Drawing.Point(813, 315);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 27);
            this.textBox8.TabIndex = 15;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouter.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAjouter.Location = new System.Drawing.Point(166, 437);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(167, 61);
            this.buttonAjouter.TabIndex = 16;
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
            this.buttonModifier.Location = new System.Drawing.Point(375, 437);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(167, 61);
            this.buttonModifier.TabIndex = 17;
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
            this.buttonSupprimer.Location = new System.Drawing.Point(569, 437);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(167, 61);
            this.buttonSupprimer.TabIndex = 18;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox9.Location = new System.Drawing.Point(813, 348);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 27);
            this.textBox9.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox10.Location = new System.Drawing.Point(813, 381);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 27);
            this.textBox10.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox11.Location = new System.Drawing.Point(813, 414);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(125, 27);
            this.textBox11.TabIndex = 21;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox12.Location = new System.Drawing.Point(813, 447);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(125, 27);
            this.textBox12.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(813, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 23;
            // 
            // Casting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 555);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridViewClient);
            this.Name = "Casting";
            this.Text = "Casting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewClient;
        private TextBox textBoxID;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private DataGridViewTextBoxColumn Identifiant;
        private DataGridViewTextBoxColumn Libelle;
        private DataGridViewTextBoxColumn Debut;
        private DataGridViewTextBoxColumn Fin;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Ville;
        private DataGridViewTextBoxColumn AgeMin;
        private DataGridViewTextBoxColumn AgeMax;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn Client;
        private DataGridViewTextBoxColumn Metier;
        private DataGridViewTextBoxColumn Contrat;
        private ComboBox comboBox1;
    }
}