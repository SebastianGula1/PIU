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
            this.btnCautaPagina = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.lblMesajF = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnAdauga.Click += new System.EventHandler(this.btnAdaugaPagina_Click);
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
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisarePagina_Click);
            // 
            // btnCautaPagina
            // 
            this.btnCautaPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnCautaPagina.FlatAppearance.BorderSize = 0;
            this.btnCautaPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautaPagina.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btnCautaPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnCautaPagina.Image")));
            this.btnCautaPagina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCautaPagina.Location = new System.Drawing.Point(0, 266);
            this.btnCautaPagina.Name = "btnCautaPagina";
            this.btnCautaPagina.Size = new System.Drawing.Size(199, 77);
            this.btnCautaPagina.TabIndex = 8;
            this.btnCautaPagina.Text = "Cauta";
            this.btnCautaPagina.UseVisualStyleBackColor = false;
            this.btnCautaPagina.Click += new System.EventHandler(this.btnCautaPagina_Click);
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
            this.panel1.Controls.Add(this.btnCautaPagina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 536);
            this.panel1.TabIndex = 21;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblCopyright.Location = new System.Drawing.Point(0, 516);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Padding = new System.Windows.Forms.Padding(35, 3, 0, 0);
            this.lblCopyright.Size = new System.Drawing.Size(125, 20);
            this.lblCopyright.TabIndex = 23;
            this.lblCopyright.Text = " ©  GGS 2020";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.lblLogoText);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 105);
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
            // lblMesajF
            // 
            this.lblMesajF.AutoSize = true;
            this.lblMesajF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblMesajF.Location = new System.Drawing.Point(350, 546);
            this.lblMesajF.Name = "lblMesajF";
            this.lblMesajF.Size = new System.Drawing.Size(0, 21);
            this.lblMesajF.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(202, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 536);
            this.panel3.TabIndex = 40;
            // 
            // FarmacieForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(870, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblMesajF);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMesaj);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FarmacieForm";
            this.Text = "PharmacyApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnCautaPagina;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblMesajF;
        private System.Windows.Forms.Panel panel3;
    }
}

