#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms.Clases
{
    internal class Cliente
    {
        #region Variables
        int CodigoCliente;
        string NombreCliente;
        string apellidoCliente;
        #endregion

        #region Get & Set
        public int CodigoClientes
        {
            get => CodigoCliente;
            set => CodigoCliente = value;
        }
        public string NombreClientes
        {
            get => NombreCliente;
            set => NombreCliente = value;
        }

        #endregion

        #region Cliente
        public Cliente()
        {
            CodigoClientes = 0;
            NombreClientes = "";
        }
        #endregion

        #region Public Cliente
        public Cliente(int CodigoCliente, string NombreCliente)
        {
            this.CodigoClientes = CodigoCliente;
            this.NombreClientes = NombreCliente;
        }
        #endregion
    }
}
