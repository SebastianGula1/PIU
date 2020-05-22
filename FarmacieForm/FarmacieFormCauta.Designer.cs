namespace FarmacieForm
{
    partial class FarmacieFormCauta
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblIntroducereNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblMesajCauta = new System.Windows.Forms.Label();
            this.BtnCauta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(23, 25);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 45);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_click);
            // 
            // lblIntroducereNume
            // 
            this.lblIntroducereNume.AutoSize = true;
            this.lblIntroducereNume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroducereNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblIntroducereNume.Location = new System.Drawing.Point(297, 102);
            this.lblIntroducereNume.Name = "lblIntroducereNume";
            this.lblIntroducereNume.Size = new System.Drawing.Size(352, 21);
            this.lblIntroducereNume.TabIndex = 30;
            this.lblIntroducereNume.Text = "Introduceti numele medicamentului cautat";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(320, 144);
            this.txtNume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(298, 20);
            this.txtNume.TabIndex = 31;
            // 
            // lblMesajCauta
            // 
            this.lblMesajCauta.AutoSize = true;
            this.lblMesajCauta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesajCauta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblMesajCauta.Location = new System.Drawing.Point(317, 278);
            this.lblMesajCauta.Name = "lblMesajCauta";
            this.lblMesajCauta.Size = new System.Drawing.Size(0, 17);
            this.lblMesajCauta.TabIndex = 32;
            // 
            // BtnCauta
            // 
            this.BtnCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.BtnCauta.FlatAppearance.BorderSize = 2;
            this.BtnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCauta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCauta.Location = new System.Drawing.Point(405, 462);
            this.BtnCauta.Name = "BtnCauta";
            this.BtnCauta.Size = new System.Drawing.Size(109, 46);
            this.BtnCauta.TabIndex = 34;
            this.BtnCauta.Text = "Cauta";
            this.BtnCauta.UseVisualStyleBackColor = false;
            this.BtnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // FarmacieFormCauta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1040, 616);
            this.Controls.Add(this.BtnCauta);
            this.Controls.Add(this.lblMesajCauta);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblIntroducereNume);
            this.Controls.Add(this.btnClose);
            this.Name = "FarmacieFormCauta";
            this.Text = "FarmacieFormCauta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblIntroducereNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblMesajCauta;
        private System.Windows.Forms.Button BtnCauta;
    }
}