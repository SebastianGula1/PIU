namespace FarmacieForm
{
    partial class FarmacieFormAdauga
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
            this.lblValabil = new System.Windows.Forms.Label();
            this.cmbValabil = new System.Windows.Forms.ComboBox();
            this.boxFarmacie = new System.Windows.Forms.GroupBox();
            this.chkBluePharm = new System.Windows.Forms.CheckBox();
            this.chkDona = new System.Windows.Forms.CheckBox();
            this.chkHelpNet = new System.Windows.Forms.CheckBox();
            this.chkSensiBlue = new System.Windows.Forms.CheckBox();
            this.chkCatena = new System.Windows.Forms.CheckBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.boxTip = new System.Windows.Forms.GroupBox();
            this.radioBtnNecunoscut = new System.Windows.Forms.RadioButton();
            this.radioBtnInjectie = new System.Windows.Forms.RadioButton();
            this.radioBtnUnguent = new System.Windows.Forms.RadioButton();
            this.radioBtnSirop = new System.Windows.Forms.RadioButton();
            this.radioBtnPilula = new System.Windows.Forms.RadioButton();
            this.lblFarmacie = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.boxFarmacie.SuspendLayout();
            this.boxTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValabil
            // 
            this.lblValabil.AutoSize = true;
            this.lblValabil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblValabil.Location = new System.Drawing.Point(251, 455);
            this.lblValabil.Name = "lblValabil";
            this.lblValabil.Size = new System.Drawing.Size(64, 13);
            this.lblValabil.TabIndex = 27;
            this.lblValabil.Text = "Valabilitatea";
            // 
            // cmbValabil
            // 
            this.cmbValabil.FormattingEnabled = true;
            this.cmbValabil.Items.AddRange(new object[] {
            "Valabil",
            "Nevalabil"});
            this.cmbValabil.Location = new System.Drawing.Point(372, 474);
            this.cmbValabil.Name = "cmbValabil";
            this.cmbValabil.Size = new System.Drawing.Size(197, 21);
            this.cmbValabil.TabIndex = 26;
            // 
            // boxFarmacie
            // 
            this.boxFarmacie.Controls.Add(this.chkBluePharm);
            this.boxFarmacie.Controls.Add(this.chkDona);
            this.boxFarmacie.Controls.Add(this.chkHelpNet);
            this.boxFarmacie.Controls.Add(this.chkSensiBlue);
            this.boxFarmacie.Controls.Add(this.chkCatena);
            this.boxFarmacie.Location = new System.Drawing.Point(360, 334);
            this.boxFarmacie.Name = "boxFarmacie";
            this.boxFarmacie.Size = new System.Drawing.Size(215, 118);
            this.boxFarmacie.TabIndex = 25;
            this.boxFarmacie.TabStop = false;
            // 
            // chkBluePharm
            // 
            this.chkBluePharm.AutoSize = true;
            this.chkBluePharm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkBluePharm.Location = new System.Drawing.Point(50, 75);
            this.chkBluePharm.Name = "chkBluePharm";
            this.chkBluePharm.Size = new System.Drawing.Size(77, 17);
            this.chkBluePharm.TabIndex = 18;
            this.chkBluePharm.Text = "BluePharm";
            this.chkBluePharm.UseVisualStyleBackColor = true;
            // 
            // chkDona
            // 
            this.chkDona.AutoSize = true;
            this.chkDona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkDona.Location = new System.Drawing.Point(122, 52);
            this.chkDona.Name = "chkDona";
            this.chkDona.Size = new System.Drawing.Size(52, 17);
            this.chkDona.TabIndex = 3;
            this.chkDona.Text = "Dona";
            this.chkDona.UseVisualStyleBackColor = true;
            // 
            // chkHelpNet
            // 
            this.chkHelpNet.AutoSize = true;
            this.chkHelpNet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkHelpNet.Location = new System.Drawing.Point(6, 52);
            this.chkHelpNet.Name = "chkHelpNet";
            this.chkHelpNet.Size = new System.Drawing.Size(65, 17);
            this.chkHelpNet.TabIndex = 2;
            this.chkHelpNet.Text = "HelpNet";
            this.chkHelpNet.UseVisualStyleBackColor = true;
            // 
            // chkSensiBlue
            // 
            this.chkSensiBlue.AutoSize = true;
            this.chkSensiBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkSensiBlue.Location = new System.Drawing.Point(121, 19);
            this.chkSensiBlue.Name = "chkSensiBlue";
            this.chkSensiBlue.Size = new System.Drawing.Size(67, 17);
            this.chkSensiBlue.TabIndex = 1;
            this.chkSensiBlue.Text = "SensiBlu";
            this.chkSensiBlue.UseVisualStyleBackColor = true;
            // 
            // chkCatena
            // 
            this.chkCatena.AutoSize = true;
            this.chkCatena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkCatena.Location = new System.Drawing.Point(6, 19);
            this.chkCatena.Name = "chkCatena";
            this.chkCatena.Size = new System.Drawing.Size(60, 17);
            this.chkCatena.TabIndex = 0;
            this.chkCatena.Text = "Catena";
            this.chkCatena.UseVisualStyleBackColor = true;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblTip.Location = new System.Drawing.Point(274, 182);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(33, 13);
            this.lblTip.TabIndex = 24;
            this.lblTip.Text = "Tipul ";
            // 
            // boxTip
            // 
            this.boxTip.Controls.Add(this.radioBtnNecunoscut);
            this.boxTip.Controls.Add(this.radioBtnInjectie);
            this.boxTip.Controls.Add(this.radioBtnUnguent);
            this.boxTip.Controls.Add(this.radioBtnSirop);
            this.boxTip.Controls.Add(this.radioBtnPilula);
            this.boxTip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxTip.Location = new System.Drawing.Point(352, 201);
            this.boxTip.Name = "boxTip";
            this.boxTip.Size = new System.Drawing.Size(223, 127);
            this.boxTip.TabIndex = 23;
            this.boxTip.TabStop = false;
            // 
            // radioBtnNecunoscut
            // 
            this.radioBtnNecunoscut.AutoSize = true;
            this.radioBtnNecunoscut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.radioBtnNecunoscut.Location = new System.Drawing.Point(47, 73);
            this.radioBtnNecunoscut.Name = "radioBtnNecunoscut";
            this.radioBtnNecunoscut.Size = new System.Drawing.Size(83, 17);
            this.radioBtnNecunoscut.TabIndex = 16;
            this.radioBtnNecunoscut.TabStop = true;
            this.radioBtnNecunoscut.Text = "Necunoscut";
            this.radioBtnNecunoscut.UseVisualStyleBackColor = true;
            // 
            // radioBtnInjectie
            // 
            this.radioBtnInjectie.AutoSize = true;
            this.radioBtnInjectie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.radioBtnInjectie.Location = new System.Drawing.Point(132, 50);
            this.radioBtnInjectie.Name = "radioBtnInjectie";
            this.radioBtnInjectie.Size = new System.Drawing.Size(59, 17);
            this.radioBtnInjectie.TabIndex = 15;
            this.radioBtnInjectie.TabStop = true;
            this.radioBtnInjectie.Text = "Injectie";
            this.radioBtnInjectie.UseVisualStyleBackColor = true;
            // 
            // radioBtnUnguent
            // 
            this.radioBtnUnguent.AutoSize = true;
            this.radioBtnUnguent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.radioBtnUnguent.Location = new System.Drawing.Point(6, 50);
            this.radioBtnUnguent.Name = "radioBtnUnguent";
            this.radioBtnUnguent.Size = new System.Drawing.Size(66, 17);
            this.radioBtnUnguent.TabIndex = 15;
            this.radioBtnUnguent.TabStop = true;
            this.radioBtnUnguent.Text = "Unguent";
            this.radioBtnUnguent.UseVisualStyleBackColor = true;
            // 
            // radioBtnSirop
            // 
            this.radioBtnSirop.AutoSize = true;
            this.radioBtnSirop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.radioBtnSirop.Location = new System.Drawing.Point(132, 16);
            this.radioBtnSirop.Name = "radioBtnSirop";
            this.radioBtnSirop.Size = new System.Drawing.Size(49, 17);
            this.radioBtnSirop.TabIndex = 15;
            this.radioBtnSirop.TabStop = true;
            this.radioBtnSirop.Text = "Sirop";
            this.radioBtnSirop.UseVisualStyleBackColor = true;
            // 
            // radioBtnPilula
            // 
            this.radioBtnPilula.AutoSize = true;
            this.radioBtnPilula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.radioBtnPilula.Location = new System.Drawing.Point(6, 16);
            this.radioBtnPilula.Name = "radioBtnPilula";
            this.radioBtnPilula.Size = new System.Drawing.Size(50, 17);
            this.radioBtnPilula.TabIndex = 0;
            this.radioBtnPilula.TabStop = true;
            this.radioBtnPilula.Text = "Pilula";
            this.radioBtnPilula.UseVisualStyleBackColor = true;
            // 
            // lblFarmacie
            // 
            this.lblFarmacie.AutoSize = true;
            this.lblFarmacie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblFarmacie.Location = new System.Drawing.Point(260, 307);
            this.lblFarmacie.Name = "lblFarmacie";
            this.lblFarmacie.Size = new System.Drawing.Size(50, 13);
            this.lblFarmacie.TabIndex = 22;
            this.lblFarmacie.Text = "Farmacia";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(352, 157);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(197, 20);
            this.txtPret.TabIndex = 21;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblPret.Location = new System.Drawing.Point(267, 135);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(34, 13);
            this.lblPret.TabIndex = 20;
            this.lblPret.Text = "Pretul";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblNume.Location = new System.Drawing.Point(260, 89);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 19;
            this.lblNume.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(335, 104);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(197, 20);
            this.txtNume.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 34);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_click);
            // 
            // FarmacieFormAdauga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(826, 598);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblValabil);
            this.Controls.Add(this.cmbValabil);
            this.Controls.Add(this.boxFarmacie);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.boxTip);
            this.Controls.Add(this.lblFarmacie);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FarmacieFormAdauga";
            this.Text = "FarmacieFormAdauga";
            this.boxFarmacie.ResumeLayout(false);
            this.boxFarmacie.PerformLayout();
            this.boxTip.ResumeLayout(false);
            this.boxTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValabil;
        private System.Windows.Forms.ComboBox cmbValabil;
        private System.Windows.Forms.GroupBox boxFarmacie;
        private System.Windows.Forms.CheckBox chkBluePharm;
        private System.Windows.Forms.CheckBox chkDona;
        private System.Windows.Forms.CheckBox chkHelpNet;
        private System.Windows.Forms.CheckBox chkSensiBlue;
        private System.Windows.Forms.CheckBox chkCatena;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.GroupBox boxTip;
        private System.Windows.Forms.RadioButton radioBtnNecunoscut;
        private System.Windows.Forms.RadioButton radioBtnInjectie;
        private System.Windows.Forms.RadioButton radioBtnUnguent;
        private System.Windows.Forms.RadioButton radioBtnSirop;
        private System.Windows.Forms.RadioButton radioBtnPilula;
        private System.Windows.Forms.Label lblFarmacie;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnClose;
    }
}