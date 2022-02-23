#region Usos
using Forms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Forms
{
    public partial class frmInformacion : Form
    {
        #region Variables Globales
        List<Cliente> listaClientes = new List<Cliente>();
        List<Venta> listaVentas = new List<Venta>();
        List<Producto> listaProductos = new List<Producto>();

        Cliente cliente;
        Venta venta;
        Producto producto;
        #endregion

        #region Inicializar Componente 
        public frmInformacion()
        {
            InitializeComponent();
        }
        #endregion

        #region Botones
        //Paguina 1

        #region Boton Guardar Cliente
        private void BtnGuardarC_Click(object sender, EventArgs e)
        {
            this.ContadorC.Start();
            GuardarCliente();
            
        }
        #endregion
        #region Boton Mostrar Cliente
        private void BtnMostrarC_Click(object sender, EventArgs e)
        {
            MostrarCliente();
        }
        #endregion
        #region Boton Cancelar Cliente
        private void BtnCancelarC_Click(object sender, EventArgs e)
        {
            CancelarCliente()
        }
        #endregion

        //Paguina 2

        #region Boton Guardar Venta
        private void BtnGuardarV_Click(object sender, EventArgs e)
        {
            this.ContadorV.Start();
            GuardarVenta();
        }
        #endregion
        #region Boton Mostrar Venta
        private void BtnMostrarV_Click(object sender, EventArgs e)
        {
            MostrarVenta();
        }
        #endregion
        #region Boton Cancelar Venta
        private void CancelarV_Click(object sender, EventArgs e)
        {
            CancelarVenta();
        }
        #endregion

        //Paguina 3

        #region Boton Guardar Producto
        private void BtnGuardarP_Click(object sender, EventArgs e)
        {
            this.ContadorP.Start();
            GuardarProducto();
        }
        #endregion
        #region Boton Mostrar Producto
        private void BtnMostrarP_Click(object sender, EventArgs e)
        {
            MostrarProducto();
        }
        #endregion
        #region Boton Cancelar Producto
        private void BtnCancelarP_Click(object sender, EventArgs e)
        {
            CancelarProducto()
        }
        #endregion
        #endregion

        #region Metodos
        #region Guardar Cliente
        public void GuardarCliente()
        {
            cliente = new Cliente(int.Parse(txtCodigoCliente.Text), txtNombreCliente.Text);

            listaClientes.Add(cliente);
        }
        #endregion
        #region Mostrar Cliente
        public void MostrarCliente()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
        }
        #endregion
        #region Cancelar Cliente
        public void CancelarCliente()
        {
            txtCodigoCliente.Text = "";
            txtNombreCliente.Text = "";
        }
        #endregion

        #region Guardar Venta
        public void GuardarVenta()
        {
            venta = new Venta(int.Parse(txtCodigoVenta.Text), int.Parse(txtCodigoClienteV.Text),
                int.Parse(txtCodigoDelProductoV.Text), int.Parse(txtCantidad.Text),
                double.Parse(txtSubTotal.Text), DateTime.Parse(dtpFecha.Text));

            listaVentas.Add(venta);
        }
        #endregion
        #region Mostrar Venta
        public void MostrarVenta()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = listaVentas;
        }
        #endregion
        #region Cancelar Venta
        public void CancelarVenta()
        {
            txtCodigoVenta.Text = "";
            txtCodigoClienteV.Text = "";
            txtCodigoDelProductoV.Text = "";
            txtCantidad.Text = "";
            txtSubTotal.Text = "";
            dtpFecha.Text = "";
        }
        #endregion

        #region Guardar Producto
        public void GuardarProducto()
        {
            producto = new Producto(int.Parse(txtSubTotal.Text), txtNombreProducto.Text,
                double.Parse(txtPrecioUnidad.Text), int.Parse(txtUnidadExistencia.Text));

            listaProductos.Add(producto);
        }
        #endregion
        #region Mostrar Producto
        public void MostrarProducto()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
        }
        #endregion
        #region Cancelar Producto
        public void CancelarProducto()
        {
            txtSubTotal.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioUnidad.Text = "";
            txtUnidadExistencia.Text = "";
        }

        #endregion

        #region Consulta 1
        public void ProductoExistencia()
        {
            IEnumerable<Producto> Num = from A in listaProductos select A;
            foreach (Producto A in Num)
            {
                txtConsulta.AppendText(A.NombreProductos);
                txtConsulta.AppendText(A.UnidadExistencias.ToString());
            }
        }
        #endregion
        #region Consulta 2

        #endregion
        #region Consulta 3

        #endregion
        #endregion

        #region Herramientas
        #region Contador Cliente
        private void ContadorC_Tick(object sender, EventArgs e)
        {
            this.pbCargaC.Visible = true;
            this.pbCargaC.Increment(2);
            if (pbCargaC.Value >= pbCargaC.Maximum)
            {
                ContadorC.Stop();
                this.Hide();
                btnMostrarC.Visible = true;
            }
        }
        #endregion

        #region Contador Venta
        private void ContadorV_Tick(object sender, EventArgs e)
        {
            this.pbCargaV.Visible = true;
            this.pbCargaV.Increment(2);
            if (pbCargaV.Value >= pbCargaV.Maximum)
            {
                ContadorV.Stop();
                this.Hide();
                btnMostrarV.Visible = true;
            }
        }
        #endregion

        #region Contador Producto
        private void ContadorP_Tick(object sender, EventArgs e)
        {
            this.pbCargaP.Visible = true;
            this.pbCargaP.Increment(2);
            if (pbCargaP.Value >= pbCargaP.Maximum)
            {
                ContadorP.Stop();
                this.Hide();
                btnMostrarP.Visible = true;
            }
        }
        #endregion

        #endregion
    }
}