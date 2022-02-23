#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms.Clases
{
    internal class Venta
    {
        #region Variables
        int CodigoVenta;
        int CodigoClienteV;
        int CodigoProducto;
        int Cantidad;
        double SubTotal;
        DateTime Fecha;
        #endregion

        #region Get & Set
        public int CodigoVentas
        {
            get => CodigoVenta;
            set => CodigoVenta = value;
        }
        public int CodigoClientesV
        {
            get => CodigoClienteV;
            set => CodigoClienteV = value;
        }
        public int CodigoProductos
        {
            get => CodigoProducto;
            set => CodigoProducto = value;
        }
        public int Cantidades
        {
            get => Cantidad;
            set => Cantidad = value;
        }
        public double SubTotales
        {
            get => SubTotal;
            set => SubTotal = value;
        }
        public DateTime Fechas
        {
            get => Fecha;
            set => Fecha = value;
        }
        #endregion

        #region Venta
        public Venta()
        {
            CodigoVentas = 0;
            CodigoClientesV = 0;
            CodigoProductos = 0;
            Cantidades = 0;
            SubTotales = 0.00;
            Fechas = DateTime.MaxValue;
        }
        #endregion

        #region Public Venta
        public Venta(int CodigoVenta, int CodigoClienteV, int CodigoProducto, int Cantidad, double SubTotal, DateTime Fecha)
        {
            this.CodigoVentas = CodigoVenta;
            this.CodigoClientesV = CodigoClienteV;
            this.CodigoProductos = CodigoProducto;
            this.Cantidades = Cantidad;
            this.SubTotales = SubTotal;
            this.Fechas = Fecha;
        }
        #endregion
    }
}
