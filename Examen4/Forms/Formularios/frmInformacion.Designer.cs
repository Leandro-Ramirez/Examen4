namespace Forms
{
    partial class frmInformacion
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbCargaC = new System.Windows.Forms.ProgressBar();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnMostrarC = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbCargaV = new System.Windows.Forms.ProgressBar();
            this.CancelarV = new System.Windows.Forms.Button();
            this.btnMostrarV = new System.Windows.Forms.Button();
            this.btnGuardarV = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoDelProductoV = new System.Windows.Forms.TextBox();
            this.txtCodigoClienteV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbCargaP = new System.Windows.Forms.ProgressBar();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.btnMostrarP = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.txtUnidadExistencia = new System.Windows.Forms.TextBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txtCodigoProductoP = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rbConsulta1 = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.ContadorC = new System.Windows.Forms.Timer(this.components);
            this.ContadorV = new System.Windows.Forms.Timer(this.components);
            this.ContadorP = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbCargaC);
            this.tabPage1.Controls.Add(this.btnCancelarC);
            this.tabPage1.Controls.Add(this.btnMostrarC);
            this.tabPage1.Controls.Add(this.btnGuardarC);
            this.tabPage1.Controls.Add(this.dgvClientes);
            this.tabPage1.Controls.Add(this.txtNombreCliente);
            this.tabPage1.Controls.Add(this.txtCodigoCliente);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbCargaC
            // 
            this.pbCargaC.Location = new System.Drawing.Point(324, 60);
            this.pbCargaC.Name = "pbCargaC";
            this.pbCargaC.Size = new System.Drawing.Size(200, 30);
            this.pbCargaC.TabIndex = 28;
            this.pbCargaC.Visible = false;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.Location = new System.Drawing.Point(112, 60);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarC.TabIndex = 27;
            this.btnCancelarC.Text = "Cancelar";
            this.btnCancelarC.UseVisualStyleBackColor = true;
            this.btnCancelarC.Click += new System.EventHandler(this.BtnCancelarC_Click);
            // 
            // btnMostrarC
            // 
            this.btnMostrarC.Location = new System.Drawing.Point(218, 60);
            this.btnMostrarC.Name = "btnMostrarC";
            this.btnMostrarC.Size = new System.Drawing.Size(100, 30);
            this.btnMostrarC.TabIndex = 23;
            this.btnMostrarC.Text = "Mostrar";
            this.btnMostrarC.UseVisualStyleBackColor = true;
            this.btnMostrarC.Click += new System.EventHandler(this.BtnMostrarC_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Location = new System.Drawing.Point(6, 60);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarC.TabIndex = 22;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.BtnGuardarC_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(0, 96);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(536, 319);
            this.dgvClientes.TabIndex = 21;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(128, 32);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 22);
            this.txtNombreCliente.TabIndex = 12;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(128, 6);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoCliente.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbCargaV);
            this.tabPage2.Controls.Add(this.CancelarV);
            this.tabPage2.Controls.Add(this.btnMostrarV);
            this.tabPage2.Controls.Add(this.btnGuardarV);
            this.tabPage2.Controls.Add(this.dtpFecha);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCodigoDelProductoV);
            this.tabPage2.Controls.Add(this.txtCodigoClienteV);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvVentas);
            this.tabPage2.Controls.Add(this.txtSubTotal);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.txtCodigoVenta);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbCargaV
            // 
            this.pbCargaV.Location = new System.Drawing.Point(336, 161);
            this.pbCargaV.Name = "pbCargaV";
            this.pbCargaV.Size = new System.Drawing.Size(200, 30);
            this.pbCargaV.TabIndex = 29;
            this.pbCargaV.Visible = false;
            // 
            // CancelarV
            // 
            this.CancelarV.Location = new System.Drawing.Point(330, 42);
            this.CancelarV.Name = "CancelarV";
            this.CancelarV.Size = new System.Drawing.Size(100, 30);
            this.CancelarV.TabIndex = 27;
            this.CancelarV.Text = "Cancelar";
            this.CancelarV.UseVisualStyleBackColor = true;
            this.CancelarV.Click += new System.EventHandler(this.CancelarV_Click);
            // 
            // btnMostrarV
            // 
            this.btnMostrarV.Location = new System.Drawing.Point(436, 6);
            this.btnMostrarV.Name = "btnMostrarV";
            this.btnMostrarV.Size = new System.Drawing.Size(100, 30);
            this.btnMostrarV.TabIndex = 25;
            this.btnMostrarV.Text = "Mostrar";
            this.btnMostrarV.UseVisualStyleBackColor = true;
            this.btnMostrarV.Click += new System.EventHandler(this.BtnMostrarV_Click);
            // 
            // btnGuardarV
            // 
            this.btnGuardarV.Location = new System.Drawing.Point(330, 6);
            this.btnGuardarV.Name = "btnGuardarV";
            this.btnGuardarV.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarV.TabIndex = 24;
            this.btnGuardarV.Text = "Guardar";
            this.btnGuardarV.UseVisualStyleBackColor = true;
            this.btnGuardarV.Click += new System.EventHandler(this.BtnGuardarV_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(168, 169);
            this.dtpFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 22);
            this.dtpFecha.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha:";
            // 
            // txtCodigoDelProductoV
            // 
            this.txtCodigoDelProductoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDelProductoV.Location = new System.Drawing.Point(168, 63);
            this.txtCodigoDelProductoV.Name = "txtCodigoDelProductoV";
            this.txtCodigoDelProductoV.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoDelProductoV.TabIndex = 12;
            // 
            // txtCodigoClienteV
            // 
            this.txtCodigoClienteV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoClienteV.Location = new System.Drawing.Point(168, 36);
            this.txtCodigoClienteV.Name = "txtCodigoClienteV";
            this.txtCodigoClienteV.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoClienteV.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo Del Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo Del Cliente:";
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(0, 197);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(536, 218);
            this.dgvVentas.TabIndex = 8;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(168, 134);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubTotal.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(168, 94);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVenta.Location = new System.Drawing.Point(168, 6);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoVenta.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(83, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Sub Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo De Venta:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pbCargaP);
            this.tabPage3.Controls.Add(this.btnCancelarP);
            this.tabPage3.Controls.Add(this.btnMostrarP);
            this.tabPage3.Controls.Add(this.dgvProductos);
            this.tabPage3.Controls.Add(this.btnGuardarP);
            this.tabPage3.Controls.Add(this.txtUnidadExistencia);
            this.tabPage3.Controls.Add(this.txtPrecioUnidad);
            this.tabPage3.Controls.Add(this.txtCodigoProductoP);
            this.tabPage3.Controls.Add(this.txtNombreProducto);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(542, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbCargaP
            // 
            this.pbCargaP.Location = new System.Drawing.Point(333, 82);
            this.pbCargaP.Name = "pbCargaP";
            this.pbCargaP.Size = new System.Drawing.Size(200, 30);
            this.pbCargaP.TabIndex = 30;
            this.pbCargaP.Visible = false;
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.Location = new System.Drawing.Point(333, 45);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarP.TabIndex = 26;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.UseVisualStyleBackColor = true;
            this.btnCancelarP.Click += new System.EventHandler(this.BtnCancelarP_Click);
            // 
            // btnMostrarP
            // 
            this.btnMostrarP.Location = new System.Drawing.Point(439, 8);
            this.btnMostrarP.Name = "btnMostrarP";
            this.btnMostrarP.Size = new System.Drawing.Size(100, 30);
            this.btnMostrarP.TabIndex = 25;
            this.btnMostrarP.Text = "Mostrar";
            this.btnMostrarP.UseVisualStyleBackColor = true;
            this.btnMostrarP.Click += new System.EventHandler(this.BtnMostrarP_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(0, 118);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(539, 300);
            this.dgvProductos.TabIndex = 11;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Location = new System.Drawing.Point(333, 8);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarP.TabIndex = 10;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.BtnGuardarP_Click);
            // 
            // txtUnidadExistencia
            // 
            this.txtUnidadExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadExistencia.Location = new System.Drawing.Point(169, 90);
            this.txtUnidadExistencia.Name = "txtUnidadExistencia";
            this.txtUnidadExistencia.Size = new System.Drawing.Size(100, 22);
            this.txtUnidadExistencia.TabIndex = 9;
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnidad.Location = new System.Drawing.Point(169, 64);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioUnidad.TabIndex = 8;
            // 
            // txtCodigoProductoP
            // 
            this.txtCodigoProductoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProductoP.Location = new System.Drawing.Point(169, 8);
            this.txtCodigoProductoP.Name = "txtCodigoProductoP";
            this.txtCodigoProductoP.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProductoP.TabIndex = 6;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(169, 36);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Unidad en Existencia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Precio Unidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Codigo Del Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nombre Producto";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rbConsulta1);
            this.tabPage4.Controls.Add(this.txtConsulta);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(542, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rbConsulta1
            // 
            this.rbConsulta1.AutoSize = true;
            this.rbConsulta1.Location = new System.Drawing.Point(6, 6);
            this.rbConsulta1.Name = "rbConsulta1";
            this.rbConsulta1.Size = new System.Drawing.Size(193, 20);
            this.rbConsulta1.TabIndex = 1;
            this.rbConsulta1.TabStop = true;
            this.rbConsulta1.Text = "Productos En Existencia";
            this.rbConsulta1.UseVisualStyleBackColor = true;
            this.rbConsulta1.CheckedChanged += new System.EventHandler(this.RbConsulta1_CheckedChanged);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(6, 180);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.ReadOnly = true;
            this.txtConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsulta.Size = new System.Drawing.Size(530, 234);
            this.txtConsulta.TabIndex = 0;
            // 
            // ContadorC
            // 
            this.ContadorC.Tick += new System.EventHandler(this.ContadorC_Tick);
            // 
            // ContadorV
            // 
            this.ContadorV.Tick += new System.EventHandler(this.ContadorV_Tick);
            // 
            // ContadorP
            // 
            this.ContadorP.Tick += new System.EventHandler(this.ContadorP_Tick);
            // 
            // frmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmInformacion";
            this.Text = "Informacion";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvClientes;
        protected System.Windows.Forms.TextBox txtNombreCliente;
        protected System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvVentas;
        protected System.Windows.Forms.TextBox txtSubTotal;
        protected System.Windows.Forms.TextBox txtCantidad;
        protected System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnGuardarP;
        protected System.Windows.Forms.TextBox txtUnidadExistencia;
        protected System.Windows.Forms.TextBox txtPrecioUnidad;
        protected System.Windows.Forms.TextBox txtCodigoProductoP;
        protected System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton rbConsulta1;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtCodigoDelProductoV;
        private System.Windows.Forms.TextBox txtCodigoClienteV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMostrarC;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnMostrarV;
        private System.Windows.Forms.Button btnGuardarV;
        private System.Windows.Forms.Button btnMostrarP;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button CancelarV;
        private System.Windows.Forms.Button btnCancelarP;
        private System.Windows.Forms.ProgressBar pbCargaC;
        private System.Windows.Forms.Timer ContadorC;
        private System.Windows.Forms.ProgressBar pbCargaV;
        private System.Windows.Forms.Timer ContadorV;
        private System.Windows.Forms.ProgressBar pbCargaP;
        private System.Windows.Forms.Timer ContadorP;
    }
}

