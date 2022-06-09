using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea004
{
    internal class Sucursal
    {

        private decimal montoVenta;
        private int cantidadEmpleados;
        private int cantidadClientes;

        public Sucursal(decimal montoVenta, int cantidadEmpleados, int cantidadClientes)
        {
            this.montoVenta = montoVenta;
            this.cantidadEmpleados = cantidadEmpleados;
            this.cantidadClientes = cantidadClientes;
        }

        public decimal MontoVenta { get => montoVenta;  set => montoVenta = value;}
        public int CantidadEmpleados { get => cantidadEmpleados; set => cantidadEmpleados = value;}
        public int CantidadClientes { get => cantidadClientes; set => cantidadClientes = value;}

    }
}
