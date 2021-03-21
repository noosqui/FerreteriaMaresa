
namespace Presentacion
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.btCnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.TituloFormularioHijo = new System.Windows.Forms.Label();
            this.iconCurrentChildfo = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.ReporteProveedor = new FontAwesome.Sharp.IconButton();
            this.ReporteVentas = new FontAwesome.Sharp.IconButton();
            this.ReporteInventario = new FontAwesome.Sharp.IconButton();
            this.btnReporteCompras = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildfo)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.btnEmpleado);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 661);
            this.panelMenu.TabIndex = 0;
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
            this.btnVentas.Location = new System.Drawing.Point(0, 230);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVentas.Size = new System.Drawing.Size(220, 45);
            this.btnVentas.TabIndex = 10;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 40;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 185);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCompras.Size = new System.Drawing.Size(220, 45);
            this.btnCompras.TabIndex = 8;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnEmpleado.IconColor = System.Drawing.Color.White;
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEmpleado.IconSize = 40;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 140);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(220, 45);
            this.btnEmpleado.TabIndex = 7;
            this.btnEmpleado.Text = " Empleados";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.panel1.Size = new System.Drawing.Size(1164, 81);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 22;
            this.btnMinimizar.Location = new System.Drawing.Point(1069, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 31);
            this.btnMinimizar.TabIndex = 7;
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
            this.btnMaximizar.Location = new System.Drawing.Point(1097, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 41);
            this.btnMaximizar.TabIndex = 6;
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
            this.btCnCerrar.Location = new System.Drawing.Point(1126, 12);
            this.btCnCerrar.Name = "btCnCerrar";
            this.btCnCerrar.Size = new System.Drawing.Size(26, 41);
            this.btCnCerrar.TabIndex = 2;
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
            this.TituloFormularioHijo.Click += new System.EventHandler(this.TituloFormularioHijo_Click);
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
            this.iconCurrentChildfo.Click += new System.EventHandler(this.iconCurrentChildfo_Click);
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(220, 81);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(1164, 9);
            this.panelSombra.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1164, 571);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 275);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 45);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Inventario";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.btnReportes.Location = new System.Drawing.Point(0, 320);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Size = new System.Drawing.Size(220, 45);
            this.btnReportes.TabIndex = 101;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click_1);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.ReporteProveedor);
            this.panelSubMenu.Controls.Add(this.ReporteVentas);
            this.panelSubMenu.Controls.Add(this.ReporteInventario);
            this.panelSubMenu.Controls.Add(this.btnReporteCompras);
            this.panelSubMenu.Controls.Add(this.iconButton4);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSubMenu.Location = new System.Drawing.Point(50, 365);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(170, 296);
            this.panelSubMenu.TabIndex = 102;
            this.panelSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubMenu_Paint_1);
            // 
            // ReporteProveedor
            // 
            this.ReporteProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReporteProveedor.FlatAppearance.BorderSize = 0;
            this.ReporteProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReporteProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteProveedor.ForeColor = System.Drawing.Color.White;
            this.ReporteProveedor.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.ReporteProveedor.IconColor = System.Drawing.Color.White;
            this.ReporteProveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ReporteProveedor.IconSize = 17;
            this.ReporteProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReporteProveedor.Location = new System.Drawing.Point(0, 160);
            this.ReporteProveedor.Name = "ReporteProveedor";
            this.ReporteProveedor.Size = new System.Drawing.Size(170, 40);
            this.ReporteProveedor.TabIndex = 18;
            this.ReporteProveedor.Text = "Reporte Proveedores";
            this.ReporteProveedor.UseVisualStyleBackColor = true;
            this.ReporteProveedor.Click += new System.EventHandler(this.ReporteProveedor_Click_1);
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
            this.ReporteVentas.IconSize = 17;
            this.ReporteVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReporteVentas.Location = new System.Drawing.Point(0, 120);
            this.ReporteVentas.Name = "ReporteVentas";
            this.ReporteVentas.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.ReporteVentas.Size = new System.Drawing.Size(170, 40);
            this.ReporteVentas.TabIndex = 17;
            this.ReporteVentas.Text = "Reporte Ventas";
            this.ReporteVentas.UseVisualStyleBackColor = true;
            this.ReporteVentas.Click += new System.EventHandler(this.ReporteVentas_Click_1);
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
            this.ReporteInventario.IconSize = 17;
            this.ReporteInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReporteInventario.Location = new System.Drawing.Point(0, 80);
            this.ReporteInventario.Name = "ReporteInventario";
            this.ReporteInventario.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.ReporteInventario.Size = new System.Drawing.Size(170, 40);
            this.ReporteInventario.TabIndex = 16;
            this.ReporteInventario.Text = "Reporte Inventario";
            this.ReporteInventario.UseVisualStyleBackColor = true;
            this.ReporteInventario.Click += new System.EventHandler(this.ReporteInventario_Click_1);
            // 
            // btnReporteCompras
            // 
            this.btnReporteCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteCompras.FlatAppearance.BorderSize = 0;
            this.btnReporteCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCompras.ForeColor = System.Drawing.Color.White;
            this.btnReporteCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnReporteCompras.IconColor = System.Drawing.Color.White;
            this.btnReporteCompras.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnReporteCompras.IconSize = 17;
            this.btnReporteCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCompras.Location = new System.Drawing.Point(0, 40);
            this.btnReporteCompras.Name = "btnReporteCompras";
            this.btnReporteCompras.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.btnReporteCompras.Size = new System.Drawing.Size(170, 40);
            this.btnReporteCompras.TabIndex = 15;
            this.btnReporteCompras.Text = "Reporte Compras";
            this.btnReporteCompras.UseVisualStyleBackColor = true;
            this.btnReporteCompras.Click += new System.EventHandler(this.btnReporteCompras_Click_1);
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 17;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(170, 40);
            this.iconButton4.TabIndex = 14;
            this.iconButton4.Text = "Reporte Empleados";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click_1);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildfo)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildfo;
        private System.Windows.Forms.Label TituloFormularioHijo;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btCnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnReportes;
        private System.Windows.Forms.Panel panelSubMenu;
        private FontAwesome.Sharp.IconButton ReporteProveedor;
        private FontAwesome.Sharp.IconButton ReporteVentas;
        private FontAwesome.Sharp.IconButton ReporteInventario;
        private FontAwesome.Sharp.IconButton btnReporteCompras;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}