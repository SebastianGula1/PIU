namespace FarmacieForm
{
    partial class FarmacieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmacieForm));
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblValabil = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblFarmacie = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.cmbValabil = new System.Windows.Forms.ComboBox();
            this.boxFarmacie = new System.Windows.Forms.GroupBox();
            this.chkBluePharm = new System.Windows.Forms.CheckBox();
            this.chkDona = new System.Windows.Forms.CheckBox();
            this.chkHelpNet = new System.Windows.Forms.CheckBox();
            this.chkSensiBlue = new System.Windows.Forms.CheckBox();
            this.chkCatena = new System.Windows.Forms.CheckBox();
            this.boxTip = new System.Windows.Forms.GroupBox();
            this.radioBtnNecunoscut = new System.Windows.Forms.RadioButton();
            this.radioBtnInjectie = new System.Windows.Forms.RadioButton();
            this.radioBtnUnguent = new System.Windows.Forms.RadioButton();
            this.radioBtnSirop = new System.Windows.Forms.RadioButton();
            this.radioBtnPilula = new System.Windows.Forms.RadioButton();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.dataGridMedicamente = new System.Windows.Forms.DataGridView();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.lblMesajF = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.boxFarmacie.SuspendLayout();
            this.boxTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnAdauga.FlatAppearance.BorderSize = 0;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdauga.Location = new System.Drawing.Point(0, 98);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(199, 82);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnAfisare.FlatAppearance.BorderSize = 0;
            this.btnAfisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfisare.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btnAfisare.Image = ((System.Drawing.Image)(resources.GetObject("btnAfisare.Image")));
            this.btnAfisare.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAfisare.Location = new System.Drawing.Point(0, 176);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(196, 91);
            this.btnAfisare.TabIndex = 7;
            this.btnAfisare.Text = "Afiseaza";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfiseaza_click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnCauta.FlatAppearance.BorderSize = 0;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btnCauta.Image = ((System.Drawing.Image)(resources.GetObject("btnCauta.Image")));
            this.btnCauta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCauta.Location = new System.Drawing.Point(0, 266);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(199, 77);
            this.btnCauta.TabIndex = 8;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnModifica.FlatAppearance.BorderSize = 0;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btnModifica.Image = ((System.Drawing.Image)(resources.GetObject("btnModifica.Image")));
            this.btnModifica.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModifica.Location = new System.Drawing.Point(3, 341);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(194, 91);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(130, 456);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 21);
            this.lblMesaj.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.lblCopyright);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.btnAfisare);
            this.panel1.Controls.Add(this.btnCauta);
            this.panel1.Controls.Add(this.btnModifica);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 598);
            this.panel1.TabIndex = 21;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblCopyright.Location = new System.Drawing.Point(44, 573);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(90, 17);
            this.lblCopyright.TabIndex = 23;
            this.lblCopyright.Text = " ©  GGS 2020";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.lblLogoText);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 100);
            this.panel2.TabIndex = 22;
            // 
            // lblLogoText
            // 
            this.lblLogoText.AutoSize = true;
            this.lblLogoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lblLogoText.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblLogoText.Location = new System.Drawing.Point(3, 30);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(193, 42);
            this.lblLogoText.TabIndex = 0;
            this.lblLogoText.Text = "FarmaAPP";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblNume.Location = new System.Drawing.Point(247, 41);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(57, 21);
            this.lblNume.TabIndex = 23;
            this.lblNume.Text = "Nume";
            // 
            // lblValabil
            // 
            this.lblValabil.AutoSize = true;
            this.lblValabil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblValabil.Location = new System.Drawing.Point(219, 481);
            this.lblValabil.Name = "lblValabil";
            this.lblValabil.Size = new System.Drawing.Size(112, 21);
            this.lblValabil.TabIndex = 31;
            this.lblValabil.Text = "Valabilitatea";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblTip.Location = new System.Drawing.Point(247, 178);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(49, 21);
            this.lblTip.TabIndex = 30;
            this.lblTip.Text = "Tipul ";
            // 
            // lblFarmacie
            // 
            this.lblFarmacie.AutoSize = true;
            this.lblFarmacie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblFarmacie.Location = new System.Drawing.Point(235, 324);
            this.lblFarmacie.Name = "lblFarmacie";
            this.lblFarmacie.Size = new System.Drawing.Size(84, 21);
            this.lblFarmacie.TabIndex = 29;
            this.lblFarmacie.Text = "Farmacia";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblPret.Location = new System.Drawing.Point(247, 100);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(54, 21);
            this.lblPret.TabIndex = 28;
            this.lblPret.Text = "Pretul";
            // 
            // cmbValabil
            // 
            this.cmbValabil.FormattingEnabled = true;
            this.cmbValabil.Items.AddRange(new object[] {
            "Valabil",
            "Nevalabil"});
            this.cmbValabil.Location = new System.Drawing.Point(350, 481);
            this.cmbValabil.Name = "cmbValabil";
            this.cmbValabil.Size = new System.Drawing.Size(223, 29);
            this.cmbValabil.TabIndex = 36;
            // 
            // boxFarmacie
            // 
            this.boxFarmacie.Controls.Add(this.chkBluePharm);
            this.boxFarmacie.Controls.Add(this.chkDona);
            this.boxFarmacie.Controls.Add(this.chkHelpNet);
            this.boxFarmacie.Controls.Add(this.chkSensiBlue);
            this.boxFarmacie.Controls.Add(this.chkCatena);
            this.boxFarmacie.Location = new System.Drawing.Point(350, 316);
            this.boxFarmacie.Name = "boxFarmacie";
            this.boxFarmacie.Size = new System.Drawing.Size(223, 118);
            this.boxFarmacie.TabIndex = 35;
            this.boxFarmacie.TabStop = false;
            // 
            // chkBluePharm
            // 
            this.chkBluePharm.AutoSize = true;
            this.chkBluePharm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkBluePharm.Location = new System.Drawing.Point(50, 75);
            this.chkBluePharm.Name = "chkBluePharm";
            this.chkBluePharm.Size = new System.Drawing.Size(111, 25);
            this.chkBluePharm.TabIndex = 18;
            this.chkBluePharm.Text = "BluePharm";
            this.chkBluePharm.UseVisualStyleBackColor = true;
            this.chkBluePharm.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // chkDona
            // 
            this.chkDona.AutoSize = true;
            this.chkDona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkDona.Location = new System.Drawing.Point(122, 52);
            this.chkDona.Name = "chkDona";
            this.chkDona.Size = new System.Drawing.Size(72, 25);
            this.chkDona.TabIndex = 3;
            this.chkDona.Text = "Dona";
            this.chkDona.UseVisualStyleBackColor = true;
            this.chkDona.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // chkHelpNet
            // 
            this.chkHelpNet.AutoSize = true;
            this.chkHelpNet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkHelpNet.Location = new System.Drawing.Point(6, 52);
            this.chkHelpNet.Name = "chkHelpNet";
            this.chkHelpNet.Size = new System.Drawing.Size(93, 25);
            this.chkHelpNet.TabIndex = 2;
            this.chkHelpNet.Text = "HelpNet";
            this.chkHelpNet.UseVisualStyleBackColor = true;
            this.chkHelpNet.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // chkSensiBlue
            // 
            this.chkSensiBlue.AutoSize = true;
            this.chkSensiBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkSensiBlue.Location = new System.Drawing.Point(121, 19);
            this.chkSensiBlue.Name = "chkSensiBlue";
            this.chkSensiBlue.Size = new System.Drawing.Size(88, 25);
            this.chkSensiBlue.TabIndex = 1;
            this.chkSensiBlue.Text = "SensiBlu";
            this.chkSensiBlue.UseVisualStyleBackColor = true;
            this.chkSensiBlue.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // chkCatena
            // 
            this.chkCatena.AutoSize = true;
            this.chkCatena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.chkCatena.Location = new System.Drawing.Point(6, 19);
            this.chkCatena.Name = "chkCatena";
            this.chkCatena.Size = new System.Drawing.Size(91, 25);
            this.chkCatena.TabIndex = 0;
            this.chkCatena.Text = "Catena";
            this.chkCatena.UseVisualStyleBackColor = true;
            this.chkCatena.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // boxTip
            // 
            this.boxTip.Controls.Add(this.radioBtnNecunoscut);
            this.boxTip.Controls.Add(this.radioBtnInjectie);
            this.boxTip.Controls.Add(this.radioBtnUnguent);
            this.boxTip.Controls.Add(this.radioBtnSirop);
            this.boxTip.Controls.Add(this.radioBtnPilula);
            this.boxTip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxTip.Location = new System.Drawing.Point(349, 164);
            this.boxTip.Name = "boxTip";
            this.boxTip.Size = new System.Drawing.Size(223, 127);
            this.boxTip.TabIndex = 34;
            this.boxTip.TabStop = false;
            // 
            // radioBtnNecunoscut
            // 
            this.radioBtnNecunoscut.AutoSize = true;
            this.radioBtnNecunoscut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.radioBtnNecunoscut.Location = new System.Drawing.Point(47, 73);
            this.radioBtnNecunoscut.Name = "radioBtnNecunoscut";
            this.radioBtnNecunoscut.Size = new System.Drawing.Size(123, 25);
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
            this.radioBtnInjectie.Size = new System.Drawing.Size(86, 25);
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
            this.radioBtnUnguent.Size = new System.Drawing.Size(97, 25);
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
            this.radioBtnSirop.Size = new System.Drawing.Size(65, 25);
            this.radioBtnSirop.TabIndex = 15;
            this.radioBtnSirop.TabStop = true;
            this.radioBtnSirop.Text = "Sirop";
            this.radioBtnSirop.UseVisualStyleBackColor = true;
            // 
            // radioBtnPilula
            // 
            this.radioBtnPilula.AutoSize = true;
            this.radioBtnPilula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.radioBtnPilula.Location = new System.Drawing.Point(6, 19);
            this.radioBtnPilula.Name = "radioBtnPilula";
            this.radioBtnPilula.Size = new System.Drawing.Size(67, 25);
            this.radioBtnPilula.TabIndex = 0;
            this.radioBtnPilula.TabStop = true;
            this.radioBtnPilula.Text = "Pilula";
            this.radioBtnPilula.UseVisualStyleBackColor = true;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(354, 100);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(218, 27);
            this.txtPret.TabIndex = 33;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(354, 38);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(218, 27);
            this.txtNume.TabIndex = 32;
            // 
            // dataGridMedicamente
            // 
            this.dataGridMedicamente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.dataGridMedicamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicamente.Location = new System.Drawing.Point(900, 23);
            this.dataGridMedicamente.Name = "dataGridMedicamente";
            this.dataGridMedicamente.Size = new System.Drawing.Size(543, 487);
            this.dataGridMedicamente.TabIndex = 37;
            // 
            // lstAfisare
            // 
            this.lstAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 21;
            this.lstAfisare.Location = new System.Drawing.Point(602, 23);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(270, 487);
            this.lstAfisare.TabIndex = 38;
            // 
            // lblMesajF
            // 
            this.lblMesajF.AutoSize = true;
            this.lblMesajF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblMesajF.Location = new System.Drawing.Point(350, 546);
            this.lblMesajF.Name = "lblMesajF";
            this.lblMesajF.Size = new System.Drawing.Size(0, 21);
            this.lblMesajF.TabIndex = 39;
            // 
            // FarmacieForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1477, 599);
            this.Controls.Add(this.lblMesajF);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.dataGridMedicamente);
            this.Controls.Add(this.cmbValabil);
            this.Controls.Add(this.boxFarmacie);
            this.Controls.Add(this.boxTip);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblValabil);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblFarmacie);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMesaj);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FarmacieForm";
            this.Text = "PharmacyApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.boxFarmacie.ResumeLayout(false);
            this.boxFarmacie.PerformLayout();
            this.boxTip.ResumeLayout(false);
            this.boxTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnModifica;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblValabil;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblFarmacie;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.ComboBox cmbValabil;
        private System.Windows.Forms.GroupBox boxFarmacie;
        private System.Windows.Forms.CheckBox chkBluePharm;
        private System.Windows.Forms.CheckBox chkDona;
        private System.Windows.Forms.CheckBox chkHelpNet;
        private System.Windows.Forms.CheckBox chkSensiBlue;
        private System.Windows.Forms.CheckBox chkCatena;
        private System.Windows.Forms.GroupBox boxTip;
        private System.Windows.Forms.RadioButton radioBtnNecunoscut;
        private System.Windows.Forms.RadioButton radioBtnInjectie;
        private System.Windows.Forms.RadioButton radioBtnUnguent;
        private System.Windows.Forms.RadioButton radioBtnSirop;
        private System.Windows.Forms.RadioButton radioBtnPilula;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.DataGridView dataGridMedicamente;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Label lblMesajF;
    }
}

