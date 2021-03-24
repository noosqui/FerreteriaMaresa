namespace Presentacion
{
    partial class RegistroEmpleado
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
            this.txtbuscarid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombreemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtfechan = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.btnrecontratar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtregion = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.txtcodpost = new System.Windows.Forms.TextBox();
            this.txtcodrol = new System.Windows.Forms.TextBox();
            this.txtidentidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscarid
            // 
            this.txtbuscarid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbuscarid.Location = new System.Drawing.Point(696, 345);
            this.txtbuscarid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscarid.Name = "txtbuscarid";
            this.txtbuscarid.Size = new System.Drawing.Size(53, 22);
            this.txtbuscarid.TabIndex = 13;
            this.txtbuscarid.TextChanged += new System.EventHandler(this.txtbuscarid_TextChanged);
            this.txtbuscarid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarid_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(562, 347);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Id Empleado:";
            // 
            // txtnombreemp
            // 
            this.txtnombreemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombreemp.Location = new System.Drawing.Point(880, 345);
            this.txtnombreemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombreemp.Name = "txtnombreemp";
            this.txtnombreemp.Size = new System.Drawing.Size(110, 22);
            this.txtnombreemp.TabIndex = 14;
            this.txtnombreemp.TextChanged += new System.EventHandler(this.txtnombreemp_TextChanged);
            this.txtnombreemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreemp_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(788, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(626, 586);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 41);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(450, 586);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 41);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(296, 586);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 41);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(332, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Correo:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcorreo.Enabled = false;
            this.txtcorreo.Location = new System.Drawing.Point(464, 286);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(176, 22);
            this.txtcorreo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(332, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(332, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombres:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(1019, 334);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 41);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(41, 402);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.Size = new System.Drawing.Size(1317, 150);
            this.dgvEmpleados.TabIndex = 24;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(597, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Empleados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(776, 586);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 41);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.habilitar_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(965, 231);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 25);
            this.label12.TabIndex = 84;
            this.label12.Text = "Pais:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(965, 173);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 82;
            this.label11.Text = "Codigo Postal:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(648, 285);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Region:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(646, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 78;
            this.label9.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(965, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "Telefono:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(13, 119);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 25);
            this.label13.TabIndex = 86;
            this.label13.Text = "Identidad:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(14, 173);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 25);
            this.label14.TabIndex = 88;
            this.label14.Text = "Codigo de Rol:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(14, 231);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 25);
            this.label15.TabIndex = 89;
            this.label15.Text = "Fecha de Nacimiento:";
            // 
            // dtfechan
            // 
            this.dtfechan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtfechan.Enabled = false;
            this.dtfechan.Location = new System.Drawing.Point(18, 277);
            this.dtfechan.Margin = new System.Windows.Forms.Padding(4);
            this.dtfechan.Name = "dtfechan";
            this.dtfechan.Size = new System.Drawing.Size(274, 22);
            this.dtfechan.TabIndex = 2;
            this.dtfechan.Value = new System.DateTime(1992, 1, 1, 0, 0, 0, 0);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(14, 327);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 25);
            this.label16.TabIndex = 92;
            this.label16.Text = "Estado:";
            // 
            // txtestado
            // 
            this.txtestado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtestado.Enabled = false;
            this.txtestado.Location = new System.Drawing.Point(137, 331);
            this.txtestado.Margin = new System.Windows.Forms.Padding(4);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(155, 22);
            this.txtestado.TabIndex = 3;
            // 
            // btnrecontratar
            // 
            this.btnrecontratar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnrecontratar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnrecontratar.FlatAppearance.BorderSize = 0;
            this.btnrecontratar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecontratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecontratar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrecontratar.Location = new System.Drawing.Point(935, 586);
            this.btnrecontratar.Margin = new System.Windows.Forms.Padding(4);
            this.btnrecontratar.Name = "btnrecontratar";
            this.btnrecontratar.Size = new System.Drawing.Size(119, 41);
            this.btnrecontratar.TabIndex = 93;
            this.btnrecontratar.Text = "Contratar";
            this.btnrecontratar.UseVisualStyleBackColor = false;
            this.btnrecontratar.Click += new System.EventHandler(this.btnrecontratar_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(646, 171);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 25);
            this.label17.TabIndex = 94;
            this.label17.Text = "Direccion:";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(462, 175);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(176, 22);
            this.txtnombre.TabIndex = 4;
            // 
            // txtapellido
            // 
            this.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellido.Enabled = false;
            this.txtapellido.Location = new System.Drawing.Point(462, 230);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(176, 22);
            this.txtapellido.TabIndex = 5;
            // 
            // txtregion
            // 
            this.txtregion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtregion.Enabled = false;
            this.txtregion.Location = new System.Drawing.Point(772, 288);
            this.txtregion.Margin = new System.Windows.Forms.Padding(4);
            this.txtregion.Name = "txtregion";
            this.txtregion.Size = new System.Drawing.Size(175, 22);
            this.txtregion.TabIndex = 9;
            // 
            // txtciudad
            // 
            this.txtciudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtciudad.Enabled = false;
            this.txtciudad.Location = new System.Drawing.Point(772, 233);
            this.txtciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(175, 22);
            this.txtciudad.TabIndex = 8;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(772, 175);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(175, 22);
            this.txtdireccion.TabIndex = 7;
            // 
            // txttelefono
            // 
            this.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(1152, 282);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(149, 22);
            this.txttelefono.TabIndex = 12;
            // 
            // txtpais
            // 
            this.txtpais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpais.Enabled = false;
            this.txtpais.Location = new System.Drawing.Point(1152, 227);
            this.txtpais.Margin = new System.Windows.Forms.Padding(4);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(149, 22);
            this.txtpais.TabIndex = 11;
            // 
            // txtcodpost
            // 
            this.txtcodpost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcodpost.Enabled = false;
            this.txtcodpost.Location = new System.Drawing.Point(1152, 177);
            this.txtcodpost.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodpost.Name = "txtcodpost";
            this.txtcodpost.Size = new System.Drawing.Size(149, 22);
            this.txtcodpost.TabIndex = 10;
            // 
            // txtcodrol
            // 
            this.txtcodrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcodrol.Enabled = false;
            this.txtcodrol.Location = new System.Drawing.Point(198, 177);
            this.txtcodrol.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodrol.Name = "txtcodrol";
            this.txtcodrol.Size = new System.Drawing.Size(124, 22);
            this.txtcodrol.TabIndex = 1;
            // 
            // txtidentidad
            // 
            this.txtidentidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidentidad.Enabled = false;
            this.txtidentidad.Location = new System.Drawing.Point(149, 123);
            this.txtidentidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtidentidad.Name = "txtidentidad";
            this.txtidentidad.Size = new System.Drawing.Size(173, 22);
            this.txtidentidad.TabIndex = 0;
            // 
            // RegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1377, 762);
            this.Controls.Add(this.txtidentidad);
            this.Controls.Add(this.txtcodrol);
            this.Controls.Add(this.txtcodpost);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.txtregion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnrecontratar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.dtfechan);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtbuscarid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnombreemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroEmpleado";
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.RegistroEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscarid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnombreemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtfechan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button btnrecontratar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtregion;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.TextBox txtcodpost;
        private System.Windows.Forms.TextBox txtcodrol;
        private System.Windows.Forms.TextBox txtidentidad;
    }
}
