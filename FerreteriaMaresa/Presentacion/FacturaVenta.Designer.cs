
namespace Presentacion
{
    partial class FacturaVenta
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
            this.encabezadoventa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.piedepaginaventa = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.encabezadoventa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.piedepaginaventa);
            this.panel1.Controls.Add(this.encabezadoventa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 794);
            this.panel1.TabIndex = 4;
            // 
            // encabezadoventa
            // 
            this.encabezadoventa.Controls.Add(this.label1);
            this.encabezadoventa.Dock = System.Windows.Forms.DockStyle.Top;
            this.encabezadoventa.Location = new System.Drawing.Point(0, 0);
            this.encabezadoventa.Name = "encabezadoventa";
            this.encabezadoventa.Size = new System.Drawing.Size(716, 100);
            this.encabezadoventa.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(237, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 159;
            this.label1.Text = "Ferreteria Maresa";
            // 
            // piedepaginaventa
            // 
            this.piedepaginaventa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.piedepaginaventa.Location = new System.Drawing.Point(0, 694);
            this.piedepaginaventa.Name = "piedepaginaventa";
            this.piedepaginaventa.Size = new System.Drawing.Size(716, 100);
            this.piedepaginaventa.TabIndex = 162;
            // 
            // FacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 794);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaVenta";
            this.Text = "FacturaVenta";
            this.panel1.ResumeLayout(false);
            this.encabezadoventa.ResumeLayout(false);
            this.encabezadoventa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel encabezadoventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel piedepaginaventa;
    }
}