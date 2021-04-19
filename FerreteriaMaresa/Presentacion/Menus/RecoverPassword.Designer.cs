
namespace Presentacion
{
    partial class RecoverPassword
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnVerCont = new FontAwesome.Sharp.IconButton();
            this.btnVerConf = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.btCnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegresar.Location = new System.Drawing.Point(24, 195);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(127, 33);
            this.btnRegresar.TabIndex = 86;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtpassword.Location = new System.Drawing.Point(159, 67);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(199, 29);
            this.txtpassword.TabIndex = 85;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(175, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 88;
            this.label4.Text = "Nueva Contraseña:";
            // 
            // btCnCerrar
            // 
            this.btCnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btCnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btCnCerrar.IconColor = System.Drawing.Color.White;
            this.btCnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCnCerrar.IconSize = 26;
            this.btCnCerrar.Location = new System.Drawing.Point(490, 2);
            this.btCnCerrar.Name = "btCnCerrar";
            this.btCnCerrar.Size = new System.Drawing.Size(26, 33);
            this.btCnCerrar.TabIndex = 87;
            this.btCnCerrar.TabStop = false;
            this.btCnCerrar.Click += new System.EventHandler(this.btCnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(164, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "Confirmar contraseña:";
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtconfirmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtconfirmpass.Location = new System.Drawing.Point(159, 150);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Size = new System.Drawing.Size(199, 29);
            this.txtconfirmpass.TabIndex = 89;
            this.txtconfirmpass.UseSystemPasswordChar = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.DimGray;
            this.btnContinuar.Location = new System.Drawing.Point(368, 195);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(127, 33);
            this.btnContinuar.TabIndex = 92;
            this.btnContinuar.Text = "Confirmar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerCont
            // 
            this.btnVerCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVerCont.FlatAppearance.BorderSize = 0;
            this.btnVerCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCont.ForeColor = System.Drawing.Color.Transparent;
            this.btnVerCont.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerCont.IconColor = System.Drawing.Color.White;
            this.btnVerCont.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerCont.Location = new System.Drawing.Point(368, 68);
            this.btnVerCont.Name = "btnVerCont";
            this.btnVerCont.Size = new System.Drawing.Size(41, 31);
            this.btnVerCont.TabIndex = 93;
            this.btnVerCont.UseVisualStyleBackColor = false;
            this.btnVerCont.Click += new System.EventHandler(this.btnVerCont_Click);
            // 
            // btnVerConf
            // 
            this.btnVerConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVerConf.FlatAppearance.BorderSize = 0;
            this.btnVerConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerConf.ForeColor = System.Drawing.Color.Transparent;
            this.btnVerConf.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerConf.IconColor = System.Drawing.Color.White;
            this.btnVerConf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerConf.Location = new System.Drawing.Point(368, 150);
            this.btnVerConf.Name = "btnVerConf";
            this.btnVerConf.Size = new System.Drawing.Size(41, 31);
            this.btnVerConf.TabIndex = 94;
            this.btnVerConf.UseVisualStyleBackColor = false;
            this.btnVerConf.Click += new System.EventHandler(this.btnVerConf_Click);
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(518, 257);
            this.Controls.Add(this.btnVerConf);
            this.Controls.Add(this.btnVerCont);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCnCerrar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtpassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoverPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverPassword";
            this.Load += new System.EventHandler(this.RecoverPassword_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btCnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btCnCerrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.Button btnContinuar;
        private FontAwesome.Sharp.IconButton btnVerCont;
        private FontAwesome.Sharp.IconButton btnVerConf;
        public System.Windows.Forms.TextBox txtpassword;
    }
}