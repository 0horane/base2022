using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea004
{
    static class Calcular
    {
        //#################### metodos internos ###################

        /// <summary>
        /// Calcula el total de una propiedad de las sucursales
        /// </summary>
        /// <param name="sucursales">array de la sucursales</param>
        /// <param name="sumaque">función que devuelve el parametro deseado de una sucursal</param>
        /// <returns>suma de todas las de esas propiedades de el array</returns>
        private static decimal XTotal(Sucursal[] sucursales, Func<Sucursal, decimal> sumaque)
        {
            decimal suma = 0;
            foreach (Sucursal sucursal in sucursales)
                suma += sumaque(sucursal);
            return suma;
        }

        /// <summary>
        /// Compara todos los montos de venta de un array de seucursales
        /// </summary>
        /// <param name="sucursales">array de sucursales</param>
        /// <param name="condicionaceptar">función que compara dos montos (ints) y devuelve true si el mas reciente (primero) es el Ximo (mayor, menor, etc)</param>
        /// <returns>tuple de el numero de la sucursal correcta y el valor.</returns>
        private static (int, decimal) ventaXima(Sucursal[] sucursales, Func<decimal, decimal, bool> condicionaceptar, Func<Sucursal, decimal>? Xxima=null)
        {
            if (Xxima == null)
                Xxima = (x => x.MontoVenta);
            decimal current = Xxima(sucursales[0]);
            int ri = 0;
            for (int i = 1; i < sucursales.Length; i++)
            {
                if (condicionaceptar(Xxima(sucursales[i]), current))
                {
                    current = Xxima(sucursales[i]);
                    ri = i;
                }

            }
            return (ri, current);
        }
        //#################### metodos que pide la consigna ###################
        // sus nombres explican lo que hacen
        public static decimal ventaTotal(Sucursal[] sucursales) => (XTotal(sucursales, x => x.MontoVenta));
        public static double promedioVentas(Sucursal[] sucursales) => ((double) ventaTotal(sucursales))/sucursales.Length;
        public static double promedioEmpleados(Sucursal[] sucursales) => ((double) XTotal(sucursales, x => x.CantidadEmpleados))/sucursales.Length;
        public static (int, decimal) ventaMaxima(Sucursal[] sucursales) =>ventaXima(sucursales, (x,y)=>x > y);
        public static (int, decimal) ventaMinima(Sucursal[] sucursales) =>ventaXima(sucursales, (x,y)=>x < y);


        //##### metodos para que queden mas lindos los datos en el print ######
        public static (int, decimal) maxempleados(Sucursal[] sucursales) => ventaXima(sucursales, (x, y) => x > y, x=>x.CantidadEmpleados);
        public static (int, decimal) maxclienes(Sucursal[] sucursales) => ventaXima(sucursales, (x, y) => x > y, x => x.CantidadEmpleados);



    }
}

