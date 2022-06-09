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
            while (sucursales.Contains(null))
            {
                int numsucursal=Input.IntC("Que numero de sucursal queres ingresar?", "Eso no es un numero", x=>x>=1 && x<8 && sucursales[x-1] == null , "Sucursal Fuera de rango o Ya ingresada");
                sucursales[numsucursal-1] = new Sucursal(Input.Decimal("Ingrese el monto total"), Input.Int("Ingrese la cantidad de empleados"), Input.Int("Ingrese la cantidad de Clientes que compraron este mes"));
            }

        }
}
}