using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea004
{
    static class Calcular
    {

        public static double XTotal(Sucursal[] sucursales, Func<Sucursal, double> sumaque)
        {
            double suma = 0;
            foreach (Sucursal sucursal in sucursales)
            {
                suma += sumaque(sucursal);
            }
            return suma;
        }

        public static decimal ventaXima(Sucursal[] sucursales, Func<decimal, decimal, bool> condicionaceptar)
        {
            decimal current = sucursales[0].MontoVenta;
            for (int i = 1; i < sucursales.Length; i++)
            {
                if (condicionaceptar(sucursales[i].MontoVenta, current))
                {
                    current = i;
                }
            }
            return current;
        }


    }
}
