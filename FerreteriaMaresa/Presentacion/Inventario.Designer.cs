namespace Presentacion
{
    partial class Inventario
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnInactivos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInventari = new System.Windows.Forms.TabPage();
            this.panel_Inventario = new System.Windows.Forms.Panel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.tabAgrega = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.cbbCategorias = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.cbbStock = new System.Windows.Forms.ComboBox();
            this.cbbMarca = new System.Windows.Forms.ComboBox();
            this.cbbProveedor = new System.Windows.Forms.ComboBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtNomInventario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabInventari.SuspendLayout();
            this.panel_Inventario.SuspendLayout();
            this.tabAgrega.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(214, 221);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(1086, 456);
            this.dgvInventario.TabIndex = 23;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(561, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "INVENTARIO";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(339, 48);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.MaxLength = 9;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(76, 22);
            this.txtcodigo.TabIndex = 33;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged_1);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(199, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID Producto:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(339, 109);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(227, 22);
            this.txtnombre.TabIndex = 31;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged_1);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(229, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nombre:";
            // 
            // btnActivos
            // 
            this.btnActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnActivos.FlatAppearance.BorderSize = 0;
            this.btnActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivos.Location = new System.Drawing.Point(16, 378);
            this.btnActivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(164, 70);
            this.btnActivos.TabIndex = 58;
            this.btnActivos.Text = "ACTIVOS";
            this.btnActivos.UseVisualStyleBackColor = false;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            this.btnActivos.StyleChanged += new System.EventHandler(this.btnActivos_StyleChanged);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTodos.Location = new System.Drawing.Point(9, 500);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(164, 69);
            this.btnTodos.TabIndex = 59;
            this.btnTodos.Text = "TODOS";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnInactivos
            // 
            this.btnInactivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnInactivos.FlatAppearance.BorderSize = 0;
            this.btnInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInactivos.Location = new System.Drawing.Point(16, 245);
            this.btnInactivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInactivos.Name = "btnInactivos";
            this.btnInactivos.Size = new System.Drawing.Size(164, 65);
            this.btnInactivos.TabIndex = 60;
            this.btnInactivos.Text = "INACTIVOS";
            this.btnInactivos.UseVisualStyleBackColor = false;
            this.btnInactivos.Click += new System.EventHandler(this.btnInactivos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 741);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInventari);
            this.tabControl.Controls.Add(this.tabAgrega);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1381, 741);
            this.tabControl.TabIndex = 73;
            // 
            // tabInventari
            // 
            this.tabInventari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabInventari.Controls.Add(this.panel_Inventario);
            this.tabInventari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabInventari.Location = new System.Drawing.Point(4, 25);
            this.tabInventari.Name = "tabInventari";
            this.tabInventari.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventari.Size = new System.Drawing.Size(1373, 712);
            this.tabInventari.TabIndex = 0;
            this.tabInventari.Text = "Inventario";
            // 
            // panel_Inventario
            // 
            this.panel_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panel_Inventario.Controls.Add(this.btnInactivos);
            this.panel_Inventario.Controls.Add(this.cmbCategoria);
            this.panel_Inventario.Controls.Add(this.dgvInventario);
            this.panel_Inventario.Controls.Add(this.btnActivos);
            this.panel_Inventario.Controls.Add(this.cmbMarca);
            this.panel_Inventario.Controls.Add(this.btnTodos);
            this.panel_Inventario.Controls.Add(this.label8);
            this.panel_Inventario.Controls.Add(this.txtcodigo);
            this.panel_Inventario.Controls.Add(this.txtnombre);
            this.panel_Inventario.Controls.Add(this.label7);
            this.panel_Inventario.Location = new System.Drawing.Point(2, 3);
            this.panel_Inventario.Name = "panel_Inventario";
            this.panel_Inventario.Size = new System.Drawing.Size(1375, 716);
            this.panel_Inventario.TabIndex = 74;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "ABRAZADERA",
            "ACEITES Y LUBRICANTES",
            "HIDRO LAVADORAS",
            "TOLDOS",
            "BICICLETAS",
            "ACCESORIOS DE AUTOMOTRIZ",
            "ACCESORIOS PARA PUERTA",
            "ADHESIVOS Y PEGAMENTOS",
            "TENSORES",
            "PINTURAS, ANTICORROSIVOS",
            "LAMINA DESPLEGADA",
            "CEMENTO",
            "CANALETA",
            "BAÑERAS",
            "SECADOR DE MANO",
            "EQUIPO DE FONTANERÍA"});
            this.cmbCategoria.Location = new System.Drawing.Point(932, 111);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(264, 24);
            this.cmbCategoria.TabIndex = 69;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "SANTUL",
            "TRUPER",
            "CHEVRON",
            "AKSI",
            "ELECLITE",
            "FLYING EAGLE"});
            this.cmbMarca.Location = new System.Drawing.Point(615, 111);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(281, 24);
            this.cmbMarca.TabIndex = 68;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // tabAgrega
            // 
            this.tabAgrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabAgrega.Controls.Add(this.panel3);
            this.tabAgrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabAgrega.Location = new System.Drawing.Point(4, 25);
            this.tabAgrega.Name = "tabAgrega";
            this.tabAgrega.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgrega.Size = new System.Drawing.Size(1373, 712);
            this.tabAgrega.TabIndex = 1;
            this.tabAgrega.Text = "Agregar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.dgvAgregar);
            this.panel3.Controls.Add(this.btnmodificar);
            this.panel3.Controls.Add(this.cbbCategorias);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbbEstado);
            this.panel3.Controls.Add(this.cbbStock);
            this.panel3.Controls.Add(this.cbbMarca);
            this.panel3.Controls.Add(this.cbbProveedor);
            this.panel3.Controls.Add(this.txtVenta);
            this.panel3.Controls.Add(this.txtCompra);
            this.panel3.Controls.Add(this.txtNomInventario);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1372, 711);
            this.panel3.TabIndex = 75;
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(21, 249);
            this.dgvAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.RowHeadersWidth = 51;
            this.dgvAgregar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregar.Size = new System.Drawing.Size(1340, 312);
            this.dgvAgregar.TabIndex = 90;
            this.dgvAgregar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregar_CellClick);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodificar.Location = new System.Drawing.Point(779, 589);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(164, 65);
            this.btnmodificar.TabIndex = 89;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // cbbCategorias
            // 
            this.cbbCategorias.FormattingEnabled = true;
            this.cbbCategorias.Items.AddRange(new object[] {
            "ABRAZADERA",
            "ACEITES Y LUBRICANTES",
            "HIDRO LAVADORAS",
            "TOLDOS",
            "BICICLETAS",
            "ACCESORIOS DE AUTOMOTRIZ",
            "ACCESORIOS PARA PUERTA",
            "ADHESIVOS Y PEGAMENTOS",
            "TENSORES",
            "PINTURAS, ANTICORROSIVOS",
            "LAMINA DESPLEGADA",
            "CEMENTO",
            "CANALETA",
            "BAÑERAS",
            "SECADOR DE MANO",
            "EQUIPO DE FONTANERIA"});
            this.cbbCategorias.Location = new System.Drawing.Point(1076, 159);
            this.cbbCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategorias.Name = "cbbCategorias";
            this.cbbCategorias.Size = new System.Drawing.Size(232, 24);
            this.cbbCategorias.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(961, 159);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 87;
            this.label11.Text = "Categorias:";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbbEstado.Location = new System.Drawing.Point(1112, 76);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(167, 24);
            this.cbbEstado.TabIndex = 86;
            // 
            // cbbStock
            // 
            this.cbbStock.FormattingEnabled = true;
            this.cbbStock.Items.AddRange(new object[] {
            "0"});
            this.cbbStock.Location = new System.Drawing.Point(723, 177);
            this.cbbStock.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStock.Name = "cbbStock";
            this.cbbStock.Size = new System.Drawing.Size(136, 24);
            this.cbbStock.TabIndex = 85;
            // 
            // cbbMarca
            // 
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Items.AddRange(new object[] {
            "SANTUL",
            "TRUPER",
            "CHEVRON",
            "AKSI",
            "ELECLITE",
            "FLYING EAGLE",
            "TESA",
            "STANLEY",
            "RAWPLUG",
            "AMIG",
            "PEGAMIX",
            "ADMIX",
            "ICO",
            "LANCO",
            "KORAZA",
            "FERRETERIA MARESA",
            "BIJAO",
            "NORTE",
            "RHINOCERONTE",
            "ALUM",
            "ASTRA",
            "DREAMLINE",
            "GENEBRE",
            "OPUS"});
            this.cbbMarca.Location = new System.Drawing.Point(193, 181);
            this.cbbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(217, 24);
            this.cbbMarca.TabIndex = 84;
            // 
            // cbbProveedor
            // 
            this.cbbProveedor.FormattingEnabled = true;
            this.cbbProveedor.Items.AddRange(new object[] {
            "SANTUL",
            "TRUPER",
            "CHEVRON",
            "AKSI",
            "ELECLITE",
            "FLYING EAGLE"});
            this.cbbProveedor.Location = new System.Drawing.Point(203, 109);
            this.cbbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbbProveedor.Name = "cbbProveedor";
            this.cbbProveedor.Size = new System.Drawing.Size(281, 24);
            this.cbbProveedor.TabIndex = 83;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(723, 109);
            this.txtVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(136, 22);
            this.txtVenta.TabIndex = 82;
            this.txtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenta_KeyPress);
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(723, 26);
            this.txtCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(136, 22);
            this.txtCompra.TabIndex = 81;
            this.txtCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompra_KeyPress);
            // 
            // txtNomInventario
            // 
            this.txtNomInventario.Location = new System.Drawing.Point(146, 28);
            this.txtNomInventario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomInventario.Name = "txtNomInventario";
            this.txtNomInventario.Size = new System.Drawing.Size(227, 22);
            this.txtNomInventario.TabIndex = 80;
            this.txtNomInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomInventario_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(960, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 79;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(571, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "STOCK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(571, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(41, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Nombre Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(571, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Precio Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(1165, 589);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(164, 65);
            this.btnGuardar.TabIndex = 72;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(85, 589);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 65);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(432, 589);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 65);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1381, 741);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabInventari.ResumeLayout(false);
            this.panel_Inventario.ResumeLayout(false);
            this.panel_Inventario.PerformLayout();
            this.tabAgrega.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnInactivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInventari;
        private System.Windows.Forms.Panel panel_Inventario;
        private System.Windows.Forms.TabPage tabAgrega;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.ComboBox cbbStock;
        private System.Windows.Forms.ComboBox cbbMarca;
        private System.Windows.Forms.ComboBox cbbProveedor;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtNomInventario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCategorias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.Button btnmodificar;
    }
}
