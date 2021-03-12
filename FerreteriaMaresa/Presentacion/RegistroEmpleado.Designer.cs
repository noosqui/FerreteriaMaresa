
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
            this.label8 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region_empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal_empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais_empeados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcodigoemp = new System.Windows.Forms.TextBox();
            this.txtnombreemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.region = new System.Windows.Forms.TextBox();
            this.codpost = new System.Windows.Forms.TextBox();
            this.pais = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(23, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Id Empleado:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_empleado,
            this.nom_empleado,
            this.apellido_empleado,
            this.correo_empleado,
            this.direccion_empleado,
            this.ciudad_empleados,
            this.region_empleados,
            this.codigo_postal_empleados,
            this.pais_empeados,
            this.telefono_empleado});
            this.dgvEmpleados.Location = new System.Drawing.Point(16, 353);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.Size = new System.Drawing.Size(1395, 185);
            this.dgvEmpleados.TabIndex = 24;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "Id Empleado";
            this.id_empleado.MinimumWidth = 6;
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Width = 125;
            // 
            // nom_empleado
            // 
            this.nom_empleado.HeaderText = "Nombre";
            this.nom_empleado.MinimumWidth = 6;
            this.nom_empleado.Name = "nom_empleado";
            this.nom_empleado.Width = 125;
            // 
            // apellido_empleado
            // 
            this.apellido_empleado.HeaderText = "Apellido";
            this.apellido_empleado.MinimumWidth = 6;
            this.apellido_empleado.Name = "apellido_empleado";
            this.apellido_empleado.Width = 125;
            // 
            // correo_empleado
            // 
            this.correo_empleado.HeaderText = "Correo";
            this.correo_empleado.MinimumWidth = 6;
            this.correo_empleado.Name = "correo_empleado";
            this.correo_empleado.Width = 125;
            // 
            // direccion_empleado
            // 
            this.direccion_empleado.HeaderText = "Direccion";
            this.direccion_empleado.MinimumWidth = 6;
            this.direccion_empleado.Name = "direccion_empleado";
            this.direccion_empleado.Width = 125;
            // 
            // ciudad_empleados
            // 
            this.ciudad_empleados.HeaderText = "Ciudad";
            this.ciudad_empleados.MinimumWidth = 6;
            this.ciudad_empleados.Name = "ciudad_empleados";
            this.ciudad_empleados.Width = 125;
            // 
            // region_empleados
            // 
            this.region_empleados.HeaderText = "Region";
            this.region_empleados.MinimumWidth = 6;
            this.region_empleados.Name = "region_empleados";
            this.region_empleados.Width = 125;
            // 
            // codigo_postal_empleados
            // 
            this.codigo_postal_empleados.HeaderText = "Codigo Postal";
            this.codigo_postal_empleados.MinimumWidth = 6;
            this.codigo_postal_empleados.Name = "codigo_postal_empleados";
            this.codigo_postal_empleados.Width = 125;
            // 
            // pais_empeados
            // 
            this.pais_empeados.HeaderText = "Pais";
            this.pais_empeados.MinimumWidth = 6;
            this.pais_empeados.Name = "pais_empeados";
            this.pais_empeados.Width = 125;
            // 
            // telefono_empleado
            // 
            this.telefono_empleado.HeaderText = "Telefono";
            this.telefono_empleado.MinimumWidth = 6;
            this.telefono_empleado.Name = "telefono_empleado";
            this.telefono_empleado.Width = 125;
            // 
            // txtcodigoemp
            // 
            this.txtcodigoemp.Location = new System.Drawing.Point(144, 319);
            this.txtcodigoemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigoemp.Name = "txtcodigoemp";
            this.txtcodigoemp.Size = new System.Drawing.Size(148, 22);
            this.txtcodigoemp.TabIndex = 89;
            this.txtcodigoemp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnombreemp
            // 
            this.txtnombreemp.Location = new System.Drawing.Point(395, 315);
            this.txtnombreemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombreemp.Name = "txtnombreemp";
            this.txtnombreemp.Size = new System.Drawing.Size(148, 22);
            this.txtnombreemp.TabIndex = 87;
            this.txtnombreemp.TextChanged += new System.EventHandler(this.txtnombreemp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(307, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(575, 305);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 41);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(456, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 46);
            this.label1.TabIndex = 90;
            this.label1.Text = "Registro de Empleados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(64, 561);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(311, 69);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
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
            this.btnEliminar.Location = new System.Drawing.Point(1020, 561);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(311, 69);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(701, 561);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(311, 69);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.Location = new System.Drawing.Point(383, 561);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(311, 69);
            this.btnMostrar.TabIndex = 36;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(244, 123);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(229, 22);
            this.nombre.TabIndex = 23;
            // 
            // Apellido
            // 
            this.Apellido.Enabled = false;
            this.Apellido.Location = new System.Drawing.Point(244, 177);
            this.Apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(229, 22);
            this.Apellido.TabIndex = 27;
            // 
            // correo
            // 
            this.correo.Enabled = false;
            this.correo.Location = new System.Drawing.Point(244, 233);
            this.correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(229, 22);
            this.correo.TabIndex = 29;
            // 
            // direccion
            // 
            this.direccion.Enabled = false;
            this.direccion.Location = new System.Drawing.Point(631, 119);
            this.direccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(229, 22);
            this.direccion.TabIndex = 73;
            // 
            // ciudad
            // 
            this.ciudad.Enabled = false;
            this.ciudad.Location = new System.Drawing.Point(631, 180);
            this.ciudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(229, 22);
            this.ciudad.TabIndex = 77;
            // 
            // region
            // 
            this.region.Enabled = false;
            this.region.Location = new System.Drawing.Point(631, 235);
            this.region.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(229, 22);
            this.region.TabIndex = 79;
            // 
            // codpost
            // 
            this.codpost.Enabled = false;
            this.codpost.Location = new System.Drawing.Point(1075, 122);
            this.codpost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codpost.Name = "codpost";
            this.codpost.Size = new System.Drawing.Size(229, 22);
            this.codpost.TabIndex = 81;
            // 
            // pais
            // 
            this.pais.Enabled = false;
            this.pais.Location = new System.Drawing.Point(1075, 180);
            this.pais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(229, 22);
            this.pais.TabIndex = 83;
            // 
            // telefono
            // 
            this.telefono.Enabled = false;
            this.telefono.Location = new System.Drawing.Point(1075, 235);
            this.telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(229, 22);
            this.telefono.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(895, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 25);
            this.label12.TabIndex = 99;
            this.label12.Text = "Pais:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(895, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 98;
            this.label11.Text = "Codigo Postal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(507, 233);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 97;
            this.label10.Text = "Region:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(507, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 96;
            this.label9.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(895, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(507, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 94;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(125, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 93;
            this.label4.Text = "RTN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(125, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(125, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Nombre:";
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnhabilitar.FlatAppearance.BorderSize = 0;
            this.btnhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhabilitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhabilitar.Location = new System.Drawing.Point(1292, 303);
            this.btnhabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(119, 41);
            this.btnhabilitar.TabIndex = 88;
            this.btnhabilitar.Text = "Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = false;
            // 
            // RegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1427, 651);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigoemp);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.txtnombreemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.codpost);
            this.Controls.Add(this.region);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroEmpleado";
            this.Text = "RegistroEmpleado";
            this.Load += new System.EventHandler(this.RegistroEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn region_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_empeados;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_empleado;
        private System.Windows.Forms.TextBox txtcodigoemp;
        private System.Windows.Forms.TextBox txtnombreemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.TextBox region;
        private System.Windows.Forms.TextBox codpost;
        private System.Windows.Forms.TextBox pais;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhabilitar;
    }
}