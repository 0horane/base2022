namespace Ej3
{
    class Program
    {
        /// <summary>
        /// Prompts the user for a valid string until inputted correctly
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="failprompt"></param>
        /// <returns>Input String</returns>
        static string Inputstr(string prompt = "Ingrese un texto: ", string failprompt = "Eso no es un texto. Ingrese un texto: ")
        {
            Console.WriteLine(prompt);
            string? inputstring = Console.ReadLine();
            while (inputstring == null)
            {
                Console.WriteLine(failprompt);
                inputstring = Console.ReadLine();
            }
            return inputstring;
        }
        static void Main(string[] args)
        {
            string inputusername = Inputstr("Ingresá tu nombre de usuario: ");
            string inputpassword = Inputstr("Ingresá tu Contraseña: ");

            if (inputusername != "Thor") {
                Console.WriteLine("El nombre de usuario no es valido");
            } else if (inputpassword != "abj123")
            {
                Console.WriteLine("La contraseña no es válida");
            }
            else
            {
                Console.WriteLine("Te logueaste correctamente");
            }
        }
    }
}
