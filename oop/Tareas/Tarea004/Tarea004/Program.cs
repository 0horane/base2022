using System;

namespace Tarea004 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            string[] ubicaciones = {
                "Once",
                "San Nicolás",
                "Almagro",
                "Microcentro",
                "Palermo",
                "San Cristóbal",
                "Parque Patricios"
            };

            Sucursal[] sucursales = new Sucursal[7];
            //mientras falte rellenar alguna sucursal
            while (sucursales.Contains(null))
            {
                //ingresar un numero de sucursal en rango y que no haya sido ya rellenado
                int numsucursal=Input.IntC("Que numero de sucursal queres ingresar?", "Eso no es un numero", x=>x>=1 && x<8 && sucursales[x-1] == null , "Sucursal Fuera de rango o Ya ingresada");
                Console.WriteLine($"Estas ingresando los datos de la sucursal {numsucursal}");
                //rellenar los datos de la sucursal de ese numero y asignarlo al lugar correspondiente del array.
                sucursales[numsucursal-1] = new Sucursal(Input.Decimal("Ingrese el monto total"), Input.Int("Ingrese la cantidad de empleados"), Input.Int("Ingrese la cantidad de Clientes que compraron este mes"));
                Console.Write("\n\n\n");

            }
            
            //usar los metodos para calcular los datos requeridos
            (int, decimal) ventamaxima = Calcular.ventaMaxima(sucursales);
            (int, decimal) ventaminima = Calcular.ventaMinima(sucursales);
            double promedioventas = Calcular.promedioVentas(sucursales);
            double promedioempleados = Calcular.promedioEmpleados(sucursales);

            int lenmaxclientes = Calcular.maxclienes(sucursales).Item2.ToString().Length;
            int lenmaxemps = Calcular.maxempleados(sucursales).Item2.ToString().Length;


            //imprimir todo
            for (int i = 0; i < sucursales.Length; i++) {
                Console.WriteLine($"La sucursal {i + 1} de {ubicaciones[i]}" + new string(' ', 17 - ubicaciones[i].Length) +
                    $" tiene {sucursales[i].CantidadClientes} " + new string(' ', lenmaxclientes - sucursales[i].CantidadClientes.ToString().Length) +
                    $"clientes, {sucursales[i].CantidadEmpleados} " + new string(' ', lenmaxemps - sucursales[i].CantidadEmpleados.ToString().Length) +
                    $"empleados, y un monto de venta de {sucursales[i].MontoVenta} ");
            }

            Console.WriteLine($"\nEl promedio de ventas es de {promedioventas}");
            Console.WriteLine($"La venta máxima fue de {ventamaxima.Item2} en la sucursal {ventamaxima.Item1+1}");
            Console.WriteLine($"La venta mínima fue de {ventaminima.Item2} en la sucursal {ventaminima.Item1+1}");
            Console.WriteLine($"El promedio de Empleados es de {promedioempleados}");
            Console.WriteLine($"El promedio de Ventas por Empleado es de {promedioventas / promedioempleados}");
            
        }
    }
}