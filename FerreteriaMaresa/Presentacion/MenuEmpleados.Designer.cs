
namespace Presentacion
{
    partial class MenuEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmpleados));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.btCnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.TituloFormularioHijo = new System.Windows.Forms.Label();
            this.iconCurrentChildfo = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.ReporteVentas = new FontAwesome.Sharp.IconButton();
            this.ReporteInventario = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildfo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1064, 477);
            this.panelDesktop.TabIndex = 7;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(220, 75);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(1064, 9);
            this.panelSombra.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btCnCerrar);
            this.panel1.Controls.Add(this.TituloFormularioHijo);
            this.panel1.Controls.Add(this.iconCurrentChildfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 75);
            this.panel1.TabIndex = 5;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 22;
            this.btnMinimizar.Location = new System.Drawing.Point(969, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 31);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 23;
            this.btnMaximizar.Location = new System.Drawing.Point(997, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 41);
            this.btnMaximizar.TabIndex = 9;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btCnCerrar
            // 
            this.btCnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btCnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btCnCerrar.IconColor = System.Drawing.Color.White;
            this.btCnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCnCerrar.IconSize = 26;
            this.btCnCerrar.Location = new System.Drawing.Point(1026, 12);
            this.btCnCerrar.Name = "btCnCerrar";
            this.btCnCerrar.Size = new System.Drawing.Size(26, 41);
            this.btCnCerrar.TabIndex = 8;
            this.btCnCerrar.TabStop = false;
            this.btCnCerrar.Click += new System.EventHandler(this.btCnCerrar_Click);
            // 
            // TituloFormularioHijo
            // 
            this.TituloFormularioHijo.AutoSize = true;
            this.TituloFormularioHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFormularioHijo.ForeColor = System.Drawing.Color.White;
            this.TituloFormularioHijo.Location = new System.Drawing.Point(89, 22);
            this.TituloFormularioHijo.Name = "TituloFormularioHijo";
            this.TituloFormularioHijo.Size = new System.Drawing.Size(86, 31);
            this.TituloFormularioHijo.TabIndex = 1;
            this.TituloFormularioHijo.Text = "Home";
            // 
            // iconCurrentChildfo
            // 
            this.iconCurrentChildfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildfo.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildfo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildfo.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildfo.IconSize = 51;
            this.iconCurrentChildfo.Location = new System.Drawing.Point(17, 12);
            this.iconCurrentChildfo.Name = "iconCurrentChildfo";
            this.iconCurrentChildfo.Size = new System.Drawing.Size(53, 51);
            this.iconCurrentChildfo.TabIndex = 0;
            this.iconCurrentChildfo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 4;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.ReporteVentas);
            this.panelSubMenu.Controls.Add(this.ReporteInventario);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSubMenu.Location = new System.Drawing.Point(33, 275);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(187, 286);
            this.panelSubMenu.TabIndex = 18;
            // 
            // ReporteVentas
            // 
            this.ReporteVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReporteVentas.FlatAppearance.BorderSize = 0;
            this.ReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteVentas.ForeColor = System.Drawing.Color.White;
            this.ReporteVentas.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.ReporteVentas.IconColor = System.Drawing.Color.White;
            this.ReporteVentas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ReporteVentas.IconSize = 25;
            this.ReporteVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReporteVentas.Location = new System.Drawing.Point(0, 40);
            this.ReporteVentas.Name = "ReporteVentas";
            this.ReporteVentas.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.ReporteVentas.Size = new System.Drawing.Size(187, 40);
            this.ReporteVentas.TabIndex = 17;
            this.ReporteVentas.Text = "Reporte Ventas";
            this.ReporteVentas.UseVisualStyleBackColor = true;
            // 
            // ReporteInventario
            // 
            this.ReporteInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReporteInventario.FlatAppearance.BorderSize = 0;
            this.ReporteInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReporteInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteInventario.ForeColor = System.Drawing.Color.White;
            this.ReporteInventario.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.ReporteInventario.IconColor = System.Drawing.Color.White;
            this.ReporteInventario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ReporteInventario.IconSize = 25;
            this.ReporteInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReporteInventario.Location = new System.Drawing.Point(0, 0);
            this.ReporteInventario.Name = "ReporteInventario";
            this.ReporteInventario.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.ReporteInventario.Size = new System.Drawing.Size(187, 40);
            this.ReporteInventario.TabIndex = 16;
            this.ReporteInventario.Text = "Reporte Inventario";
            this.ReporteInventario.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 40;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 230);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Size = new System.Drawing.Size(220, 45);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click_1);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 40;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 185);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVentas.Size = new System.Drawing.Size(220, 45);
            this.btnVentas.TabIndex = 10;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.btnInventario.IconColor = System.Drawing.Color.White;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 40;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 140);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInventario.Size = new System.Drawing.Size(220, 45);
            this.btnInventario.TabIndex = 9;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(-24, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(269, 114);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "MenuEmpleados";
            this.Text = "MenuEmpleados";
            this.Load += new System.EventHandler(this.MenuEmpleados_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildfo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TituloFormularioHijo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildfo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSubMenu;
        private FontAwesome.Sharp.IconButton ReporteVentas;
        private FontAwesome.Sharp.IconButton ReporteInventario;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInventario;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private FontAwesome.Sharp.IconPictureBox btCnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}