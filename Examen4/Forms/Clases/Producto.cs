#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms.Clases
{
    internal class Producto
    {
        #region Variables
        int CodProducto;
        string NnombreProducto;
        double PrecioUnidad;
        int UnidadExistencia;
        #endregion

        #region Get & Set
        public int CodProductos
        {
            get => CodProducto;
            set => CodProducto = value;
        }
        public string NombreProductos
        {
            get => NnombreProducto;
            set => NnombreProducto = value;
        }
        public double PrecioUnidades
        {
            get => PrecioUnidad;
            set => PrecioUnidad = value;
        }
        public int UnidadExistencias
        {
            get => UnidadExistencia;
            set => UnidadExistencia = value;
        }
        #endregion

        #region Producto
        public Producto()
        {
            CodProductos = 0;
            NombreProductos = "";
            PrecioUnidades = 0.00;
            UnidadExistencias = 0;
        }
        #endregion

        #region Public Producto
        public Producto(int codigoProductoP, string nombreProducto, double precioUnidad, int unidadEnExistencia)
        {
            this.CodProducto = codigoProductoP;
            this.NnombreProducto = nombreProducto;
            this.PrecioUnidad = precioUnidad;
            this.UnidadExistencia = unidadEnExistencia;
        }
        #endregion

        #region Public String
        public string ProductoExistencia()
        {
            return NombreProductos + "Y su Existencia:" +UnidadExistencias;
        }
        #endregion
    }
}