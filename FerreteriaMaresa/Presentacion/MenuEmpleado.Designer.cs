namespace Presentacion
{
    partial class MenuEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmpleado));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SubMenuReportes = new System.Windows.Forms.Panel();
            this.btnReporteVE = new System.Windows.Forms.Button();
            this.btnReporteIE = new System.Windows.Forms.Button();
            this.btnReportesE = new System.Windows.Forms.Button();
            this.btnVentaProducto = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SubMenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown_1);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1232, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1263, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1232, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1201, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.SubMenuReportes);
            this.MenuVertical.Controls.Add(this.btnReportesE);
            this.MenuVertical.Controls.Add(this.btnVentaProducto);
            this.MenuVertical.Controls.Add(this.btnInventario);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 565);
            this.MenuVertical.TabIndex = 1;
            // 
            // SubMenuReportes
            // 
            this.SubMenuReportes.Controls.Add(this.btnReporteVE);
            this.SubMenuReportes.Controls.Add(this.btnReporteIE);
            this.SubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuReportes.Location = new System.Drawing.Point(0, 269);
            this.SubMenuReportes.Name = "SubMenuReportes";
            this.SubMenuReportes.Size = new System.Drawing.Size(220, 65);
            this.SubMenuReportes.TabIndex = 6;
            this.SubMenuReportes.Visible = false;
            // 
            // btnReporteVE
            // 
            this.btnReporteVE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteVE.FlatAppearance.BorderSize = 0;
            this.btnReporteVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReporteVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporteVE.Location = new System.Drawing.Point(0, 30);
            this.btnReporteVE.Name = "btnReporteVE";
            this.btnReporteVE.Size = new System.Drawing.Size(220, 30);
            this.btnReporteVE.TabIndex = 8;
            this.btnReporteVE.Text = "REPORTE VENTA";
            this.btnReporteVE.UseVisualStyleBackColor = true;
            this.btnReporteVE.Click += new System.EventHandler(this.btnReporteVE_Click);
            // 
            // btnReporteIE
            // 
            this.btnReporteIE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteIE.FlatAppearance.BorderSize = 0;
            this.btnReporteIE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReporteIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteIE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteIE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporteIE.Location = new System.Drawing.Point(0, 0);
            this.btnReporteIE.Name = "btnReporteIE";
            this.btnReporteIE.Size = new System.Drawing.Size(220, 30);
            this.btnReporteIE.TabIndex = 6;
            this.btnReporteIE.Text = "REPORTE INVENTARIO";
            this.btnReporteIE.UseVisualStyleBackColor = true;
            this.btnReporteIE.Click += new System.EventHandler(this.btnReporteIE_Click);
            // 
            // btnReportesE
            // 
            this.btnReportesE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesE.FlatAppearance.BorderSize = 0;
            this.btnReportesE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportesE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportesE.Location = new System.Drawing.Point(0, 224);
            this.btnReportesE.Name = "btnReportesE";
            this.btnReportesE.Size = new System.Drawing.Size(220, 45);
            this.btnReportesE.TabIndex = 3;
            this.btnReportesE.Text = "REPORTES";
            this.btnReportesE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesE.UseVisualStyleBackColor = true;
            this.btnReportesE.Click += new System.EventHandler(this.btnReportesE_Click);
            // 
            // btnVentaProducto
            // 
            this.btnVentaProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentaProducto.FlatAppearance.BorderSize = 0;
            this.btnVentaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnVentaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnVentaProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentaProducto.Location = new System.Drawing.Point(0, 179);
            this.btnVentaProducto.Name = "btnVentaProducto";
            this.btnVentaProducto.Size = new System.Drawing.Size(220, 45);
            this.btnVentaProducto.TabIndex = 2;
            this.btnVentaProducto.Text = "VENTA PRODUCTO";
            this.btnVentaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaProducto.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventario.Location = new System.Drawing.Point(0, 134);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(220, 45);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 565);
            this.panelContenedor.TabIndex = 6;
            // 
            // MenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuEmpleado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuEmpleado_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.SubMenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReportesE;
        private System.Windows.Forms.Button btnVentaProducto;
        private System.Windows.Forms.Panel SubMenuReportes;
        private System.Windows.Forms.Button btnReporteVE;
        private System.Windows.Forms.Button btnReporteIE;
        private System.Windows.Forms.Panel panelContenedor;
    }
}