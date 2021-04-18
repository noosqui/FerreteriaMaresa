
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new Presentacion.Reporte.CrystalReport1();
            this.piedepaginaventa = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.encabezadoventa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.piedepaginaventa.SuspendLayout();
            this.encabezadoventa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(35)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.piedepaginaventa);
            this.panel1.Controls.Add(this.encabezadoventa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 1100);
            this.panel1.TabIndex = 4;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 100);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1131, 890);
            this.crystalReportViewer1.TabIndex = 163;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // piedepaginaventa
            // 
            this.piedepaginaventa.AutoScroll = true;
            this.piedepaginaventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.piedepaginaventa.Controls.Add(this.btnSalir);
            this.piedepaginaventa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.piedepaginaventa.Location = new System.Drawing.Point(0, 990);
            this.piedepaginaventa.Name = "piedepaginaventa";
            this.piedepaginaventa.Size = new System.Drawing.Size(1131, 110);
            this.piedepaginaventa.TabIndex = 162;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(431, 21);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 64);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // encabezadoventa
            // 
            this.encabezadoventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.encabezadoventa.Controls.Add(this.label1);
            this.encabezadoventa.Dock = System.Windows.Forms.DockStyle.Top;
            this.encabezadoventa.Location = new System.Drawing.Point(0, 0);
            this.encabezadoventa.Name = "encabezadoventa";
            this.encabezadoventa.Size = new System.Drawing.Size(1131, 100);
            this.encabezadoventa.TabIndex = 161;
            this.encabezadoventa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.encabezadoventa_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(444, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 159;
            this.label1.Text = "Ferreteria Maresa";
            // 
            // FacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1131, 1100);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaVenta";
            this.Text = "FacturaVenta";
            this.Load += new System.EventHandler(this.FacturaVenta_Load);
            this.panel1.ResumeLayout(false);
            this.piedepaginaventa.ResumeLayout(false);
            this.encabezadoventa.ResumeLayout(false);
            this.encabezadoventa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel encabezadoventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel piedepaginaventa;
        private System.Windows.Forms.Button btnSalir;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Reporte.CrystalReport1 CrystalReport11;
    }
}