﻿
namespace Presentacion
{
    partial class RegistroClientes
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
            this.txtcodigocli = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodPost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombrecli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtn_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtcodigocli);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtPais);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCodPost);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtRegion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.btnhabilitar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtnombrecli);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Apellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 651);
            this.panel1.TabIndex = 0;
            // 
            // txtcodigocli
            // 
            this.txtcodigocli.Location = new System.Drawing.Point(115, 320);
            this.txtcodigocli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigocli.Name = "txtcodigocli";
            this.txtcodigocli.Size = new System.Drawing.Size(132, 22);
            this.txtcodigocli.TabIndex = 103;
            this.txtcodigocli.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(916, 176);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 25);
            this.label12.TabIndex = 102;
            this.label12.Text = "Pais:";
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(1077, 178);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(229, 22);
            this.txtPais.TabIndex = 101;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(916, 118);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 100;
            this.label11.Text = "Codigo Postal:";
            // 
            // txtCodPost
            // 
            this.txtCodPost.Enabled = false;
            this.txtCodPost.Location = new System.Drawing.Point(1077, 121);
            this.txtCodPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodPost.Name = "txtCodPost";
            this.txtCodPost.Size = new System.Drawing.Size(229, 22);
            this.txtCodPost.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(527, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 98;
            this.label10.Text = "Region:";
            // 
            // txtRegion
            // 
            this.txtRegion.Enabled = false;
            this.txtRegion.Location = new System.Drawing.Point(649, 234);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(229, 22);
            this.txtRegion.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(527, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 96;
            this.label9.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(649, 178);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(229, 22);
            this.txtCiudad.TabIndex = 95;
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnhabilitar.FlatAppearance.BorderSize = 0;
            this.btnhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhabilitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhabilitar.Location = new System.Drawing.Point(1291, 308);
            this.btnhabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(119, 41);
            this.btnhabilitar.TabIndex = 94;
            this.btnhabilitar.Text = "Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(19, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 93;
            this.label8.Text = "Id Cliente:";
            // 
            // txtnombrecli
            // 
            this.txtnombrecli.Location = new System.Drawing.Point(352, 320);
            this.txtnombrecli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombrecli.Name = "txtnombrecli";
            this.txtnombrecli.Size = new System.Drawing.Size(148, 22);
            this.txtnombrecli.TabIndex = 92;
            this.txtnombrecli.TextChanged += new System.EventHandler(this.txtnombrecli_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(264, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 91;
            this.label7.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(1040, 558);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(311, 69);
            this.btnEliminar.TabIndex = 90;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(721, 558);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(311, 69);
            this.btnModificar.TabIndex = 89;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.Location = new System.Drawing.Point(403, 558);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(311, 69);
            this.btnMostrar.TabIndex = 88;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(84, 558);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(311, 69);
            this.btnAgregar.TabIndex = 87;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(916, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 86;
            this.label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(1077, 234);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(229, 22);
            this.txtTelefono.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(527, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(649, 118);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(229, 22);
            this.txtDireccion.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(124, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "RTN:";
            // 
            // rtn
            // 
            this.rtn.Enabled = false;
            this.rtn.Location = new System.Drawing.Point(247, 231);
            this.rtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtn.Name = "rtn";
            this.rtn.Size = new System.Drawing.Size(253, 22);
            this.rtn.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(124, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Apellido:";
            // 
            // Apellido
            // 
            this.Apellido.Enabled = false;
            this.Apellido.Location = new System.Drawing.Point(247, 176);
            this.Apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(253, 22);
            this.Apellido.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(124, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(532, 310);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 41);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nombre_cliente,
            this.apellido_cliente,
            this.rtn_cliente,
            this.direccion_cliente,
            this.ciudad_cliente,
            this.region_cliente,
            this.codigo_postal,
            this.pais_cliente,
            this.telefono_cliente});
            this.dgvClientes.Location = new System.Drawing.Point(19, 356);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(1391, 185);
            this.dgvClientes.TabIndex = 76;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Id Cliente";
            this.id_cliente.MinimumWidth = 6;
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Width = 125;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.MinimumWidth = 6;
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Width = 125;
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.HeaderText = "Apellido";
            this.apellido_cliente.MinimumWidth = 6;
            this.apellido_cliente.Name = "apellido_cliente";
            this.apellido_cliente.Width = 125;
            // 
            // rtn_cliente
            // 
            this.rtn_cliente.HeaderText = "RTN";
            this.rtn_cliente.MinimumWidth = 6;
            this.rtn_cliente.Name = "rtn_cliente";
            this.rtn_cliente.Width = 125;
            // 
            // direccion_cliente
            // 
            this.direccion_cliente.HeaderText = "Direccion";
            this.direccion_cliente.MinimumWidth = 6;
            this.direccion_cliente.Name = "direccion_cliente";
            this.direccion_cliente.Width = 125;
            // 
            // ciudad_cliente
            // 
            this.ciudad_cliente.HeaderText = "Ciudad";
            this.ciudad_cliente.MinimumWidth = 6;
            this.ciudad_cliente.Name = "ciudad_cliente";
            this.ciudad_cliente.Width = 125;
            // 
            // region_cliente
            // 
            this.region_cliente.HeaderText = "Region";
            this.region_cliente.MinimumWidth = 6;
            this.region_cliente.Name = "region_cliente";
            this.region_cliente.Width = 125;
            // 
            // codigo_postal
            // 
            this.codigo_postal.HeaderText = "Codigo Postal";
            this.codigo_postal.MinimumWidth = 6;
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.Width = 125;
            // 
            // pais_cliente
            // 
            this.pais_cliente.HeaderText = "Pais";
            this.pais_cliente.MinimumWidth = 6;
            this.pais_cliente.Name = "pais_cliente";
            this.pais_cliente.Width = 125;
            // 
            // telefono_cliente
            // 
            this.telefono_cliente.HeaderText = "Telefono";
            this.telefono_cliente.MinimumWidth = 6;
            this.telefono_cliente.Name = "telefono_cliente";
            this.telefono_cliente.Width = 125;
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(247, 122);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(253, 22);
            this.nombre.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(477, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 46);
            this.label1.TabIndex = 74;
            this.label1.Text = "Registro de Clientes";
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1427, 651);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroClientes";
            this.Text = "RegistroClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcodigocli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodPost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnombrecli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtn_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn region_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_cliente;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
    }
}