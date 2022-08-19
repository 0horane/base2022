namespace Ejercicio2 
{
    public class Pasajero
    {
        string nombre, apellido, nacionalidad;
        int dni, edad;

        public Pasajero()
        {
            Console.WriteLine("Se ha creado un objeto para la carga de pasajeros. \n");
            Console.WriteLine("Ingresa un nombre");
            nombre = Console.ReadLine();
            if (nombre != "")
            {
                Console.WriteLine("Ingresa un apellido");
                apellido = Console.ReadLine();
            } else
            {
                nombre = "Invitado";
                apellido = "Invitado";
            }
            Console.WriteLine("Ingresa una nacionalidad");
            nacionalidad = Console.ReadLine();

            edad = inputInt("Ingrese la edad");
            dni = inputInt("Ingrese el DNI");

        }

        public void mostrarDatos() {

            Console.WriteLine("Pasajero: {0} {1}", nombre, apellido);
            Console.WriteLine("Nacionalidad: {0}", nacionalidad);
            Console.WriteLine("DNI: {0}", dni);
            Console.WriteLine("Edad: {0}", edad);
        }

        public void dnipar()
        {
            Console.WriteLine("El DNI es {0}par.", dni % 2 == 0 ? "" : "im" );
        }

        private int inputInt(string prompt = "Ingrese un numero") {
            int inputmonth;
            do
                Console.WriteLine(prompt);
            while (!Int32.TryParse(Console.ReadLine(), out inputmonth));
            return inputmonth;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pasajero pasajero = new Pasajero();
            Console.Write("\n\n");
            pasajero.mostrarDatos();
            Console.Write("\n\n");
            pasajero.dnipar();
        }
    }
}