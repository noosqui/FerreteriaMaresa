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
            this.li = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.Label();
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
            this.txtcantidad_unidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.cbbCategorias = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnModificarM = new System.Windows.Forms.Button();
            this.btnGuardarM = new System.Windows.Forms.Button();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnModificarC = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lc = new System.Windows.Forms.Label();
            this.lm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabInventari.SuspendLayout();
            this.panel_Inventario.SuspendLayout();
            this.tabAgrega.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(160, 180);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(814, 370);
            this.dgvInventario.TabIndex = 23;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "INVENTARIO";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(254, 39);
            this.txtcodigo.MaxLength = 9;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(58, 20);
            this.txtcodigo.TabIndex = 33;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged_1);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // li
            // 
            this.li.AutoSize = true;
            this.li.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.li.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.li.Location = new System.Drawing.Point(149, 39);
            this.li.Name = "li";
            this.li.Size = new System.Drawing.Size(81, 16);
            this.li.TabIndex = 32;
            this.li.Text = "ID Producto:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(254, 89);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(171, 20);
            this.txtnombre.TabIndex = 31;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged_1);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ln.Location = new System.Drawing.Point(172, 90);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(60, 16);
            this.ln.TabIndex = 30;
            this.ln.Text = "Nombre:";
            // 
            // btnActivos
            // 
            this.btnActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnActivos.FlatAppearance.BorderSize = 0;
            this.btnActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivos.Location = new System.Drawing.Point(12, 307);
            this.btnActivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(123, 57);
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
            this.btnTodos.Location = new System.Drawing.Point(7, 406);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(123, 56);
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
            this.btnInactivos.Location = new System.Drawing.Point(12, 199);
            this.btnInactivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnInactivos.Name = "btnInactivos";
            this.btnInactivos.Size = new System.Drawing.Size(123, 53);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 602);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInventari);
            this.tabControl.Controls.Add(this.tabAgrega);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1036, 602);
            this.tabControl.TabIndex = 73;
            // 
            // tabInventari
            // 
            this.tabInventari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabInventari.Controls.Add(this.panel_Inventario);
            this.tabInventari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabInventari.Location = new System.Drawing.Point(4, 22);
            this.tabInventari.Margin = new System.Windows.Forms.Padding(2);
            this.tabInventari.Name = "tabInventari";
            this.tabInventari.Padding = new System.Windows.Forms.Padding(2);
            this.tabInventari.Size = new System.Drawing.Size(1028, 576);
            this.tabInventari.TabIndex = 0;
            this.tabInventari.Text = "Inventario";
            // 
            // panel_Inventario
            // 
            this.panel_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panel_Inventario.Controls.Add(this.lm);
            this.panel_Inventario.Controls.Add(this.lc);
            this.panel_Inventario.Controls.Add(this.btncancelar);
            this.panel_Inventario.Controls.Add(this.btnInactivos);
            this.panel_Inventario.Controls.Add(this.cmbCategoria);
            this.panel_Inventario.Controls.Add(this.dgvInventario);
            this.panel_Inventario.Controls.Add(this.btnActivos);
            this.panel_Inventario.Controls.Add(this.cmbMarca);
            this.panel_Inventario.Controls.Add(this.btnTodos);
            this.panel_Inventario.Controls.Add(this.li);
            this.panel_Inventario.Controls.Add(this.txtcodigo);
            this.panel_Inventario.Controls.Add(this.txtnombre);
            this.panel_Inventario.Controls.Add(this.ln);
            this.panel_Inventario.Location = new System.Drawing.Point(2, 2);
            this.panel_Inventario.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Inventario.Name = "panel_Inventario";
            this.panel_Inventario.Size = new System.Drawing.Size(1031, 582);
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
            this.cmbCategoria.Location = new System.Drawing.Point(699, 90);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(199, 21);
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
            this.cmbMarca.Location = new System.Drawing.Point(461, 90);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(212, 21);
            this.cmbMarca.TabIndex = 68;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // tabAgrega
            // 
            this.tabAgrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabAgrega.Controls.Add(this.panel3);
            this.tabAgrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabAgrega.Location = new System.Drawing.Point(4, 22);
            this.tabAgrega.Margin = new System.Windows.Forms.Padding(2);
            this.tabAgrega.Name = "tabAgrega";
            this.tabAgrega.Padding = new System.Windows.Forms.Padding(2);
            this.tabAgrega.Size = new System.Drawing.Size(1028, 576);
            this.tabAgrega.TabIndex = 1;
            this.tabAgrega.Text = "Agregar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.txtcantidad_unidad);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtStock);
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Controls.Add(this.la);
            this.panel3.Controls.Add(this.dgvAgregar);
            this.panel3.Controls.Add(this.btnmodificar);
            this.panel3.Controls.Add(this.cbbCategorias);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbbEstado);
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
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 578);
            this.panel3.TabIndex = 75;
            // 
            // txtcantidad_unidad
            // 
            this.txtcantidad_unidad.Enabled = false;
            this.txtcantidad_unidad.Location = new System.Drawing.Point(584, 18);
            this.txtcantidad_unidad.Name = "txtcantidad_unidad";
            this.txtcantidad_unidad.Size = new System.Drawing.Size(171, 20);
            this.txtcantidad_unidad.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(430, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 16);
            this.label12.TabIndex = 94;
            this.label12.Text = "Cantidad por unidad:";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(567, 200);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(103, 20);
            this.txtStock.TabIndex = 93;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(162, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(103, 20);
            this.txtid.TabIndex = 92;
            this.txtid.Visible = false;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.la.Location = new System.Drawing.Point(31, 22);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(83, 16);
            this.la.TabIndex = 91;
            this.la.Text = "Id Inventario:";
            this.la.Visible = false;
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.AllowUserToAddRows = false;
            this.dgvAgregar.AllowUserToDeleteRows = false;
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(16, 265);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.ReadOnly = true;
            this.dgvAgregar.RowHeadersVisible = false;
            this.dgvAgregar.RowHeadersWidth = 51;
            this.dgvAgregar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregar.Size = new System.Drawing.Size(1005, 191);
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
            this.btnmodificar.Location = new System.Drawing.Point(363, 479);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(123, 53);
            this.btnmodificar.TabIndex = 89;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // cbbCategorias
            // 
            this.cbbCategorias.Enabled = false;
            this.cbbCategorias.FormattingEnabled = true;
            this.cbbCategorias.Location = new System.Drawing.Point(791, 203);
            this.cbbCategorias.Name = "cbbCategorias";
            this.cbbCategorias.Size = new System.Drawing.Size(175, 21);
            this.cbbCategorias.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(701, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 87;
            this.label11.Text = "Categorias:";
            // 
            // cbbEstado
            // 
            this.cbbEstado.Enabled = false;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbbEstado.Location = new System.Drawing.Point(791, 68);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(126, 21);
            this.cbbEstado.TabIndex = 86;
            // 
            // cbbMarca
            // 
            this.cbbMarca.Enabled = false;
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(145, 201);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(164, 21);
            this.cbbMarca.TabIndex = 84;
            // 
            // cbbProveedor
            // 
            this.cbbProveedor.Enabled = false;
            this.cbbProveedor.FormattingEnabled = true;
            this.cbbProveedor.Location = new System.Drawing.Point(185, 140);
            this.cbbProveedor.Name = "cbbProveedor";
            this.cbbProveedor.Size = new System.Drawing.Size(171, 21);
            this.cbbProveedor.TabIndex = 83;
            this.cbbProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbProveedor_KeyPress);
            // 
            // txtVenta
            // 
            this.txtVenta.Enabled = false;
            this.txtVenta.Location = new System.Drawing.Point(567, 146);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(103, 20);
            this.txtVenta.TabIndex = 82;
            this.txtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenta_KeyPress);
            // 
            // txtCompra
            // 
            this.txtCompra.Enabled = false;
            this.txtCompra.Location = new System.Drawing.Point(567, 80);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(103, 20);
            this.txtCompra.TabIndex = 81;
            this.txtCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompra_KeyPress);
            // 
            // txtNomInventario
            // 
            this.txtNomInventario.Enabled = false;
            this.txtNomInventario.Location = new System.Drawing.Point(110, 83);
            this.txtNomInventario.Name = "txtNomInventario";
            this.txtNomInventario.Size = new System.Drawing.Size(171, 20);
            this.txtNomInventario.TabIndex = 80;
            this.txtNomInventario.TextChanged += new System.EventHandler(this.txtNomInventario_TextChanged);
            this.txtNomInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomInventario_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(701, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 79;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(430, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "STOCK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(430, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 77;
            this.label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(31, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Nombre Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(430, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Precio Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
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
            this.btnGuardar.Location = new System.Drawing.Point(880, 479);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 53);
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
            this.btnAgregar.Location = new System.Drawing.Point(64, 479);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 53);
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
            this.btnEliminar.Location = new System.Drawing.Point(610, 479);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 53);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtIdMarca);
            this.tabPage1.Controls.Add(this.btnModificarM);
            this.tabPage1.Controls.Add(this.btnGuardarM);
            this.tabPage1.Controls.Add(this.btnAgregarM);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dgvMarca);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtNombreMarca);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1028, 576);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Marca";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.txtIdCategoria);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.btnModificarC);
            this.tabPage2.Controls.Add(this.btnGuardarC);
            this.tabPage2.Controls.Add(this.btnAgregarC);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.dgvCategoria);
            this.tabPage2.Controls.Add(this.txtNombreC);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1028, 576);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Categoria";
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Enabled = false;
            this.txtNombreMarca.Location = new System.Drawing.Point(604, 92);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(171, 20);
            this.txtNombreMarca.TabIndex = 81;
            this.txtNombreMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMarca_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(518, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 82;
            this.label13.Text = "Marca:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(487, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 74;
            this.label14.Text = "Categoria:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Enabled = false;
            this.txtNombreC.Location = new System.Drawing.Point(594, 72);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(171, 20);
            this.txtNombreC.TabIndex = 82;
            this.txtNombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(306, 135);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.RowHeadersVisible = false;
            this.dgvMarca.RowHeadersWidth = 51;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(274, 287);
            this.dgvMarca.TabIndex = 91;
            this.dgvMarca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellClick);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(342, 107);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(350, 326);
            this.dgvCategoria.TabIndex = 91;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            // 
            // btnModificarM
            // 
            this.btnModificarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificarM.FlatAppearance.BorderSize = 0;
            this.btnModificarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarM.Location = new System.Drawing.Point(400, 442);
            this.btnModificarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarM.Name = "btnModificarM";
            this.btnModificarM.Size = new System.Drawing.Size(123, 53);
            this.btnModificarM.TabIndex = 95;
            this.btnModificarM.Text = "MODIFICAR";
            this.btnModificarM.UseVisualStyleBackColor = false;
            this.btnModificarM.Click += new System.EventHandler(this.btnModificarM_Click);
            // 
            // btnGuardarM
            // 
            this.btnGuardarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardarM.FlatAppearance.BorderSize = 0;
            this.btnGuardarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarM.Location = new System.Drawing.Point(856, 442);
            this.btnGuardarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarM.Name = "btnGuardarM";
            this.btnGuardarM.Size = new System.Drawing.Size(123, 53);
            this.btnGuardarM.TabIndex = 94;
            this.btnGuardarM.Text = "GUARDAR";
            this.btnGuardarM.UseVisualStyleBackColor = false;
            this.btnGuardarM.Visible = false;
            this.btnGuardarM.Click += new System.EventHandler(this.btnGuardarM_Click);
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarM.FlatAppearance.BorderSize = 0;
            this.btnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarM.Location = new System.Drawing.Point(42, 442);
            this.btnAgregarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(123, 53);
            this.btnAgregarM.TabIndex = 92;
            this.btnAgregarM.Text = "AGREGAR";
            this.btnAgregarM.UseVisualStyleBackColor = false;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(87, 359);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 53);
            this.button4.TabIndex = 93;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // btnModificarC
            // 
            this.btnModificarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificarC.FlatAppearance.BorderSize = 0;
            this.btnModificarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarC.Location = new System.Drawing.Point(453, 456);
            this.btnModificarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarC.Name = "btnModificarC";
            this.btnModificarC.Size = new System.Drawing.Size(123, 53);
            this.btnModificarC.TabIndex = 95;
            this.btnModificarC.Text = "MODIFICAR";
            this.btnModificarC.UseVisualStyleBackColor = false;
            this.btnModificarC.Click += new System.EventHandler(this.btnModificarC_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardarC.FlatAppearance.BorderSize = 0;
            this.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarC.Location = new System.Drawing.Point(859, 456);
            this.btnGuardarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(123, 53);
            this.btnGuardarC.TabIndex = 94;
            this.btnGuardarC.Text = "GUARDAR";
            this.btnGuardarC.UseVisualStyleBackColor = false;
            this.btnGuardarC.Visible = false;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarC.FlatAppearance.BorderSize = 0;
            this.btnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarC.Location = new System.Drawing.Point(56, 456);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(123, 53);
            this.btnAgregarC.TabIndex = 92;
            this.btnAgregarC.Text = "AGREGAR";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(40, 325);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 53);
            this.button8.TabIndex = 93;
            this.button8.Text = "ELIMINAR";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Enabled = false;
            this.txtIdMarca.Location = new System.Drawing.Point(146, 88);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(171, 20);
            this.txtIdMarca.TabIndex = 96;
            this.txtIdMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMarca_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(60, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 16);
            this.label15.TabIndex = 97;
            this.label15.Text = "Id Marca";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(95, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 96;
            this.label16.Text = "Id Categoria:";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Enabled = false;
            this.txtIdCategoria.Location = new System.Drawing.Point(191, 72);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(171, 20);
            this.txtIdCategoria.TabIndex = 97;
            this.txtIdCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancelar.Location = new System.Drawing.Point(900, 39);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(99, 28);
            this.btncancelar.TabIndex = 70;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lc
            // 
            this.lc.AutoSize = true;
            this.lc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lc.Location = new System.Drawing.Point(752, 46);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(70, 16);
            this.lc.TabIndex = 71;
            this.lc.Text = "Categoria:";
            // 
            // lm
            // 
            this.lm.AutoSize = true;
            this.lm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lm.Location = new System.Drawing.Point(519, 39);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(56, 16);
            this.lm.TabIndex = 72;
            this.lm.Text = "Marcas:";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1036, 602);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label li;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label ln;
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
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtcantidad_unidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.Button btnModificarM;
        private System.Windows.Forms.Button btnGuardarM;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnModificarC;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lm;
        private System.Windows.Forms.Label lc;
        private System.Windows.Forms.Button btncancelar;
    }
}
