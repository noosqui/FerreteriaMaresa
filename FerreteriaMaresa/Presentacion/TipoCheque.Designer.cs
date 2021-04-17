
namespace Presentacion
{
    partial class TipoCheque
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
            this.panel1 = new System.Windows.Forms.Panel();

            this.dtfechan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.rtn = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodPost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();

            this.reegresar = new System.Windows.Forms.Button();

            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));

            this.panel1.Controls.Add(this.reegresar);

            this.panel1.Controls.Add(this.dtfechan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rtn);
            this.panel1.Controls.Add(this.Apellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCodPost);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 453);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 

            // dtfechan
            // 
            this.dtfechan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtfechan.Enabled = false;
            this.dtfechan.Location = new System.Drawing.Point(230, 300);
            this.dtfechan.Name = "dtfechan";
            this.dtfechan.Size = new System.Drawing.Size(206, 20);
            this.dtfechan.TabIndex = 71;
            this.dtfechan.Value = new System.DateTime(1992, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(47, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Fecha:";
            // 
            // rtn
            // 
            this.rtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtn.Enabled = false;
            this.rtn.Location = new System.Drawing.Point(230, 171);
            this.rtn.Name = "rtn";
            this.rtn.Size = new System.Drawing.Size(633, 20);
            this.rtn.TabIndex = 50;
            // 
            // Apellido
            // 
            this.Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Apellido.Enabled = false;
            this.Apellido.Location = new System.Drawing.Point(230, 128);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(633, 20);
            this.Apellido.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "La suma de:";
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(230, 84);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(633, 20);
            this.nombre.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Paguese a la orden de:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;

            this.btnEliminar.Location = new System.Drawing.Point(662, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(201, 71);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Siguiente";

            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(46, 259);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Numero de cheque:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(47, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Numero de cuenta:";
            // 
            // txtCodPost
            // 
            this.txtCodPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodPost.Enabled = false;
            this.txtCodPost.Location = new System.Drawing.Point(693, 36);
            this.txtCodPost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPost.Name = "txtCodPost";
            this.txtCodPost.Size = new System.Drawing.Size(165, 20);
            this.txtCodPost.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(617, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "Monto:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(230, 259);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(633, 20);
            this.txtCiudad.TabIndex = 65;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(230, 213);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(633, 20);
            this.txtDireccion.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(46, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ruta Bancaria:";
            // 

            // reegresar
            // 
            this.reegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.reegresar.FlatAppearance.BorderSize = 0;
            this.reegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.reegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reegresar.Location = new System.Drawing.Point(47, 348);
            this.reegresar.Name = "reegresar";
            this.reegresar.Size = new System.Drawing.Size(201, 71);
            this.reegresar.TabIndex = 72;
            this.reegresar.Text = "Regresar";
            this.reegresar.UseVisualStyleBackColor = false;
            // 

            // TipoCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoCheque";
            this.Text = "TipoCheque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rtn;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodPost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtfechan;

        private System.Windows.Forms.Button reegresar;

    }
}