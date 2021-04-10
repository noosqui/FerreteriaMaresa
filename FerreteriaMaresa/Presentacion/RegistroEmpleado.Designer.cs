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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtregion = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.txtcodpost = new System.Windows.Forms.TextBox();
            this.txtidentidad = new System.Windows.Forms.TextBox();
            this.rbactivo = new System.Windows.Forms.RadioButton();
            this.rbdespedido = new System.Windows.Forms.RadioButton();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.cbcodrol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.lblconfirmar = new System.Windows.Forms.Label();
            this.chkactivo = new System.Windows.Forms.CheckBox();
            this.chkdespedido = new System.Windows.Forms.CheckBox();
            this.chktodos = new System.Windows.Forms.CheckBox();
            this.txtconfirmarident = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            //
            // txtbuscarid
            //
            this.txtbuscarid.Anchor = System.Windows.Forms.AnchorStyles.None;

            this.txtbuscarid.Location = new System.Drawing.Point(696, 345);

            this.txtbuscarid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscarid.Name = "txtbuscarid";
            this.txtbuscarid.Size = new System.Drawing.Size(154, 22);
            this.txtbuscarid.TabIndex = 66;
            this.txtbuscarid.TextChanged += new System.EventHandler(this.txtbuscarid_TextChanged);
            //
            // label8
            //
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(276, 362);
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
            this.txtnombreemp.Size = new System.Drawing.Size(140, 22);
            this.txtnombreemp.TabIndex = 67;
            this.txtnombreemp.TextChanged += new System.EventHandler(this.txtnombreemp_TextChanged);
            //
            // label7
            //
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(574, 366);
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
            this.btnEliminar.Location = new System.Drawing.Point(955, 682);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 41);
            this.btnEliminar.TabIndex = 24;
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
            this.btnModificar.Location = new System.Drawing.Point(639, 682);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(153, 41);
            this.btnModificar.TabIndex = 22;
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
            this.btnAgregar.Location = new System.Drawing.Point(357, 682);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 41);
            this.btnAgregar.TabIndex = 20;
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
            this.label4.Location = new System.Drawing.Point(1210, 130);
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
            this.txtcorreo.Location = new System.Drawing.Point(1152, 172);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.MaxLength = 60;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(200, 22);
            this.txtcorreo.TabIndex = 13;
            this.txtcorreo.Enter += new System.EventHandler(this.txtcorreo_Enter);
            //
            // label3
            //
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 232);
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
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombres:";
            //
            // btnGuardar
            //
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(498, 682);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 41);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.habilitar_Click);
            //
            // label12
            //
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(805, 172);
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
            this.label11.Location = new System.Drawing.Point(802, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 82;
            this.label11.Text = "ZIP Postal:";
            //
            // label10
            //
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(404, 229);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Departamento:";
            //
            // label9
            //
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(404, 172);
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
            this.label6.Location = new System.Drawing.Point(805, 225);
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
            this.label13.Location = new System.Drawing.Point(13, 62);
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
            this.label14.Location = new System.Drawing.Point(13, 114);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 25);
            this.label14.TabIndex = 88;
            this.label14.Text = "Puesto:";
            //
            // label15
            //
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(404, 66);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 25);
            this.label15.TabIndex = 89;
            this.label15.Text = "Fecha de Nacimiento:";
            //
            // label16
            //
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(1025, 68);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 25);
            this.label16.TabIndex = 92;
            this.label16.Text = "Estado:";
            //
            // btncancelar
            //
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancelar.Location = new System.Drawing.Point(800, 682);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(149, 41);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btnrecontratar_Click);
            //
            // label17
            //
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(404, 118);
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
            this.txtnombre.Location = new System.Drawing.Point(146, 181);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(176, 22);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            //
            // txtapellido
            //
            this.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellido.Enabled = false;
            this.txtapellido.Location = new System.Drawing.Point(146, 236);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.MaxLength = 20;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(176, 22);
            this.txtapellido.TabIndex = 3;
            this.txtapellido.Enter += new System.EventHandler(this.txtapellido_Enter);
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            //
            // txtregion
            //
            this.txtregion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtregion.Enabled = false;
            this.txtregion.Location = new System.Drawing.Point(591, 232);
            this.txtregion.Margin = new System.Windows.Forms.Padding(4);
            this.txtregion.MaxLength = 40;
            this.txtregion.Name = "txtregion";
            this.txtregion.Size = new System.Drawing.Size(175, 22);
            this.txtregion.TabIndex = 8;
            this.txtregion.Enter += new System.EventHandler(this.txtregion_Enter);
            this.txtregion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtregion_KeyPress);
            //
            // txtciudad
            //
            this.txtciudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtciudad.Enabled = false;
            this.txtciudad.Location = new System.Drawing.Point(591, 176);
            this.txtciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtciudad.MaxLength = 50;
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(175, 22);
            this.txtciudad.TabIndex = 7;
            this.txtciudad.Enter += new System.EventHandler(this.txtciudad_Enter);
            this.txtciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtciudad_KeyPress);
            //
            // txtdireccion
            //
            this.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(591, 118);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.MaxLength = 250;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(175, 22);
            this.txtdireccion.TabIndex = 6;
            this.txtdireccion.Enter += new System.EventHandler(this.txtdireccion_Enter);
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            //
            // txttelefono
            //
            this.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(939, 225);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.MaxLength = 20;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(149, 22);
            this.txttelefono.TabIndex = 11;
            this.txttelefono.Enter += new System.EventHandler(this.txttelefono_Enter);
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            //
            // txtpais
            //
            this.txtpais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpais.Enabled = false;
            this.txtpais.Location = new System.Drawing.Point(939, 172);
            this.txtpais.Margin = new System.Windows.Forms.Padding(4);
            this.txtpais.MaxLength = 20;
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(149, 22);
            this.txtpais.TabIndex = 10;
            this.txtpais.Enter += new System.EventHandler(this.txtpais_Enter);
            this.txtpais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpais_KeyPress);
            //
            // txtcodpost
            //
            this.txtcodpost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcodpost.Enabled = false;
            this.txtcodpost.Location = new System.Drawing.Point(939, 113);
            this.txtcodpost.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodpost.MaxLength = 5;
            this.txtcodpost.Name = "txtcodpost";
            this.txtcodpost.Size = new System.Drawing.Size(149, 22);
            this.txtcodpost.TabIndex = 9;
            this.txtcodpost.Enter += new System.EventHandler(this.txtcodpost_Enter);
            this.txtcodpost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodpost_KeyPress);
            //
            // txtidentidad
            //
            this.txtidentidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidentidad.Enabled = false;
            this.txtidentidad.Location = new System.Drawing.Point(149, 66);
            this.txtidentidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtidentidad.MaxLength = 13;
            this.txtidentidad.Name = "txtidentidad";
            this.txtidentidad.Size = new System.Drawing.Size(173, 22);
            this.txtidentidad.TabIndex = 0;
            this.txtidentidad.Enter += new System.EventHandler(this.txtidentidad_Enter);
            this.txtidentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidentidad_KeyPress);
            //
            // rbactivo
            //
            this.rbactivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbactivo.AutoSize = true;
            this.rbactivo.Enabled = false;
            this.rbactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbactivo.Location = new System.Drawing.Point(1134, 73);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(67, 21);
            this.rbactivo.TabIndex = 12;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activo";
            this.rbactivo.UseVisualStyleBackColor = true;
            //
            // rbdespedido
            //
            this.rbdespedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbdespedido.AutoSize = true;
            this.rbdespedido.Enabled = false;
            this.rbdespedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbdespedido.Location = new System.Drawing.Point(1244, 73);
            this.rbdespedido.Name = "rbdespedido";
            this.rbdespedido.Size = new System.Drawing.Size(97, 21);
            this.rbdespedido.TabIndex = 12;
            this.rbdespedido.TabStop = true;
            this.rbdespedido.Text = "Despedido";
            this.rbdespedido.UseVisualStyleBackColor = true;
            //
            // dgvEmpleados
            //
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.Location = new System.Drawing.Point(18, 405);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1334, 255);
            this.dgvEmpleados.TabIndex = 97;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            //
            // cbcodrol
            //
            this.cbcodrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbcodrol.Enabled = false;
            this.cbcodrol.FormattingEnabled = true;
            this.cbcodrol.Location = new System.Drawing.Point(149, 118);
            this.cbcodrol.Name = "cbcodrol";
            this.cbcodrol.Size = new System.Drawing.Size(173, 24);
            this.cbcodrol.TabIndex = 1;
            this.cbcodrol.SelectedIndexChanged += new System.EventHandler(this.cbcodrol_SelectedIndexChanged);
            //
            // label1
            //
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(572, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 99;
            this.label1.Text = "Buscar Empleado";
            //
            // dtfecha
            //
            this.dtfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtfecha.Enabled = false;
            this.dtfecha.Location = new System.Drawing.Point(672, 71);
            this.dtfecha.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(295, 22);
            this.dtfecha.TabIndex = 5;
            this.dtfecha.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            //
            // lblconfirmar
            //
            this.lblconfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblconfirmar.AutoSize = true;
            this.lblconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblconfirmar.Location = new System.Drawing.Point(13, 294);
            this.lblconfirmar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfirmar.Name = "lblconfirmar";
            this.lblconfirmar.Size = new System.Drawing.Size(188, 25);
            this.lblconfirmar.TabIndex = 100;
            this.lblconfirmar.Text = "Confirmar Identidad:";
            this.lblconfirmar.Visible = false;
            //
            // chkactivo
            //
            this.chkactivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkactivo.AutoSize = true;
            this.chkactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkactivo.Location = new System.Drawing.Point(870, 364);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Size = new System.Drawing.Size(68, 21);
            this.chkactivo.TabIndex = 101;
            this.chkactivo.Text = "Activo";
            this.chkactivo.UseVisualStyleBackColor = true;
            this.chkactivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            //
            // chkdespedido
            //
            this.chkdespedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkdespedido.AutoSize = true;
            this.chkdespedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkdespedido.Location = new System.Drawing.Point(976, 364);
            this.chkdespedido.Name = "chkdespedido";
            this.chkdespedido.Size = new System.Drawing.Size(98, 21);
            this.chkdespedido.TabIndex = 102;
            this.chkdespedido.Text = "Despedido";
            this.chkdespedido.UseVisualStyleBackColor = true;
            this.chkdespedido.CheckedChanged += new System.EventHandler(this.chkdespedido_CheckedChanged);
            //
            // chktodos
            //
            this.chktodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chktodos.AutoSize = true;
            this.chktodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chktodos.Location = new System.Drawing.Point(1113, 365);
            this.chktodos.Name = "chktodos";
            this.chktodos.Size = new System.Drawing.Size(70, 21);
            this.chktodos.TabIndex = 103;
            this.chktodos.Text = "Todos";
            this.chktodos.UseVisualStyleBackColor = true;
            this.chktodos.CheckedChanged += new System.EventHandler(this.chktodos_CheckedChanged);
            //
            // txtconfirmarident
            //
            this.txtconfirmarident.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtconfirmarident.Location = new System.Drawing.Point(218, 298);
            this.txtconfirmarident.Name = "txtconfirmarident";
            this.txtconfirmarident.Size = new System.Drawing.Size(205, 22);
            this.txtconfirmarident.TabIndex = 104;
            //
            // RegistroEmpleado
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1377, 778);
            this.Controls.Add(this.txtconfirmarident);
            this.Controls.Add(this.chktodos);
            this.Controls.Add(this.chkdespedido);
            this.Controls.Add(this.chkactivo);
            this.Controls.Add(this.lblconfirmar);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbcodrol);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.rbdespedido);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.txtidentidad);
            this.Controls.Add(this.txtcodpost);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.txtregion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label16);
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtregion;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.TextBox txtcodpost;
        private System.Windows.Forms.TextBox txtidentidad;
        private System.Windows.Forms.RadioButton rbactivo;
        private System.Windows.Forms.RadioButton rbdespedido;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.ComboBox cbcodrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label lblconfirmar;
        private System.Windows.Forms.CheckBox chkactivo;
        private System.Windows.Forms.CheckBox chkdespedido;
        private System.Windows.Forms.CheckBox chktodos;
        private System.Windows.Forms.TextBox txtconfirmarident;
    }
}
