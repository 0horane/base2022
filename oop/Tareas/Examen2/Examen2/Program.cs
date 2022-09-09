using System.IO;
using System.Linq;

namespace Examen2
{
    /*
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Deportista> deportistas = new List<Deportista>();
            bool seguir = true;
            do
            {

                Console.Clear();
                Console.WriteLine($"En el sistema hay {deportistas.Count} deportistas.  Que deseas hacer?");
                switch (Input.Int("1: Cargar nuevo deportista | 2: ver deportista por codigo | 3: guardar desportistas a archivo | 4: Cargar deportistas de archivo | 5: salir ", condition: x => 1 <= x && x <= 5))
                {
                    case 1:
                        Console.Clear();
                        int codigodeportistanuevo = Input.Int("Ingrese el Codigo del deportista", condition: x => x >= 0);
                        if (deportistas.Where(x => x.Codigo == codigodeportistanuevo).Count() != 0)
                        {
                            Console.WriteLine("Ese codigo ya esta en uso!\n Apriete cualquier tecla para continuar");
                            Console.ReadKey();
                            break;
                        }


                        deportistas.Add(new Deportista(
                            codigodeportistanuevo,
                            Input.String("Ingrese el nombre del deportista", condition: x => x != ""),
                            Input.String("Ingrese el Apellido del deportista", condition: x => x != ""),
                            Input.Int("Ingrese la altura del deportista en cm", condition: x => x >= 0)));
                        break;
                    case 2:
                        static bool counts() {
                            return true;

                        }
                        if (deportistas.Count == 0)
                            break;
                        int[] depcode = deportistas.Select(x => x.Codigo).ToArray();
                        Console.Clear();
                        Console.WriteLine($"Deportistas disponibles: {string.Join(" ", depcode)}");
                        int deporcnum = Array.FindIndex(depcode, n=> n==Input.Int($"Cual deportista queres ver? ", condition: x => depcode.Contains(x)));
                        Console.WriteLine(deporcnum);
                        bool seguir2 = true;
                        while (seguir2)
                        {
                            Console.Clear();
                            Console.WriteLine(deporcnum);

                            deportistas[deporcnum].mostrardatos();

                            switch (Input.Int("0: volver | 1: cambiar codigo | 2: cambiar nombre | 3: cambiar apellido | 4: cambiar altura | 5: eliminar", condition: x => 0 <= x && x <= 5))
                            {
                                case 0:
                                    seguir2 = false;
                                    break;
                                case 1:
                                    deportistas[deporcnum].Codigo = Input.Int("Ingrese el nuevo codigo", condition: x => x >= 0);
                                    break;
                                case 2:
                                    deportistas[deporcnum].Nombre = Input.String("Ingrese el nuevo nombre", condition: x => x != "");
                                    break;
                                case 3:
                                    deportistas[deporcnum].Apellido = Input.String("Ingrese el nuevo apellido", condition: x => x != "");
                                    break;
                                case 4:
                                    deportistas[deporcnum].Codigo = Input.Int("Ingrese la nueva altura", condition: x => x >= 0);
                                    break;
                                case 5:
                                    if (Input.String("Estas seguro de que lo quieres borrar? (s/N)").ToUpper() == "S")
                                    {
                                        deportistas.RemoveAt(deporcnum);
                                        seguir2 = false;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 3:
                        StreamWriter? texto = null;
                        string inpstr;

                        while (texto == null)
                        {
                            inpstr = Input.String("Cual archivo de texto desea crear/usar? (defecto: C:\\Programacion\\deportistas.txt)");
                            if (inpstr == "")
                                inpstr = "C:\\Programacion\\deportistas.txt";

                            try
                            {
                                texto = File.CreateText(inpstr);
                            }
                            catch (DirectoryNotFoundException ex)
                            {
                                Console.WriteLine("La carpeta en la que se encuentra la dirección que ingreso no existe. por favor elija otra");

                            }
                        }
                        foreach (Deportista deportista in deportistas)
                        {
                            texto.WriteLine($"{deportista.Codigo},{deportista.Nombre},{deportista.Apellido},{deportista.Altura}");
                        }
                        texto.Close();
                        break;
                    case 4:
                        StreamReader? texto2 = null;
                        string inpstr2;
                        while (texto2 == null)
                        {
                            inpstr2 = Input.String("Cual archivo de texto desea usar? (defecto: C:\\Programacion\\deportistas.txt)");
                            if (inpstr2 == "")
                                inpstr2 = "C:\\Programacion\\deportistas.txt";

                            try
                            {
                                texto2 = new StreamReader(inpstr2);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Arch no existe");

                            }
                        }
                        string line;
                        string[] linesplit;
                        // Read and display lines from the file until the end of
                        // the file is reached.
                        while ((line = texto2.ReadLine()) != null && line!="")
                        {
                            linesplit=line.Split(",");
                            deportistas.Add(new Deportista(
                                int.Parse(linesplit[0]),
                                linesplit[1],
                                linesplit[2],
                                int.Parse(linesplit[3])));

                        }
                        texto2.Close();
                        break;
                    case 5:
                        seguir = false;
                        break;
                    default:
                        break;
                }


            } while (seguir);




          
        }
    }

    public class Deportista
    {
        private int codigo;
        private string name;
        private string apellido;
        private int altura;
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Altura { get; set; }

        public Deportista(int codigo, string Nombre, string Apellido, int Altura)
        {
            this.Codigo = codigo;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Altura = Altura;
        }

        public void mostrardatos()
        {
            Console.WriteLine($"{Nombre} {Apellido}, con codigo {Codigo} es un {this.GetType().Name} de {Altura} cm");
        }
    }
    */


    /*
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Medico> medicos = new List<Medico>();
            List<Paciente> pacientes = new List<Paciente>();
            bool seguir = true;
            do
            {

                Console.Clear();
                Console.WriteLine($"En els sistema hay {medicos.Count} medicos tratando a {pacientes.Count} pacientes. Que deseas hacer?");
                switch(Input.Int("1: Agregar nuevo medico | 2: Agregar nuevo paciente | 3: Ver medico | 4: Ver paciente | 5:salir ", condition:x=> 1<=x && x<=5))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresando un nuevo medico");
                        medicos.Add( new Medico(
                            Input.String("Ingrese el nombre del medico", condition: x=>x!=""),
                            Input.String("Ingrese el Apellido del medico", condition: x => x != ""),
                            Input.Int("Ingrese la edad del medico", condition: x => x >=0),
                            Input.Int("Ingrese el Salario del medico", condition: x => x >=0)
                            ));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingresando un nuevo paciente");
                        pacientes.Add(new Paciente(
                            Input.String("Ingrese el nombre del paciente", condition: x => x != ""),
                            Input.String("Ingrese el Apellido del paciente", condition: x => x != ""),
                            Input.Int("Ingrese la edad del paciente", condition: x => x >= 0),
                            Input.Int("Ingrese la habitacion en la que esta el paciente", condition: x => x >= 1),
                            Input.Int("Ingrese la cama en la que esta el paciente", condition: x => x >= 1),
                            Input.String("Ingrese la condicion medica por la que esta internado", condition: x => x != "")
                            ));
                        break;
                    case 3:
                        if (medicos.Count == 0)
                            break;
                        int medicnum = Input.Int($"Cual médico queres ver? 1-{medicos.Count}", condition: x => 1 <= x && x <= medicos.Count) - 1;
                        bool seguir2 = true;
                        while (seguir2)
                        {
                            Console.Clear();
                            medicos[medicnum].mostrardatos();

                            switch(Input.Int("0: volver | 1: cambiar nombre | 2: cambiar apellido | 3: cambiar edad | 4: cambiar salario | 5: eliminar", condition:x=> 0<=x && x<=5))
                            {
                                case 0:
                                    seguir2 = false;
                                    break;
                                case 1:
                                    medicos[medicnum].Nombre = Input.String("Ingrese el nuevo nombre", condition: x => x != "");
                                    break;
                                case 2:
                                    medicos[medicnum].Apellido = Input.String("Ingrese el nuevo apellido", condition: x => x != "");
                                    break;
                                case 3:
                                    medicos[medicnum].Edad = Input.Int("Ingrese la nueva edad", condition: x => x >=0);
                                    break;
                                case 4:
                                    medicos[medicnum].Salario = Input.Int("Ingrese el nuevo salario", condition: x => x >= 0);
                                    break;
                                case 5:
                                    if (Input.String("Estas seguro de que lo quieres borrar? (s/N)").ToUpper() == "S"){
                                        medicos.RemoveAt(medicnum);
                                        seguir2 = false;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 4:
                        if (pacientes.Count == 0)
                            break;
                        int pacientenum = Input.Int($"Cual paciente queres ver? 1-{pacientes.Count}", condition: x => 1 <= x && x <= pacientes.Count) - 1;
                        bool seguir3 = true;
                        while (seguir3)
                        {
                            Console.Clear();
                            pacientes[pacientenum].mostrardatos();
                            switch (Input.Int("0: volver 1: cambiar nombre | 2: cambiar apellido | 3: cambiar edad | 4: cambiar habitacion | 5: cambiar cama | 6: cambiar condicion | 7: eliminar", condition: x => 0 <= x && x <= 7))
                            {
                                case 0:
                                    seguir3 = false;
                                    break;
                                case 1:
                                    pacientes[pacientenum].Nombre = Input.String("Ingrese el nuevo nombre", condition: x => x != "");
                                    break;
                                case 2:
                                    pacientes[pacientenum].Apellido = Input.String("Ingrese el nuevo apellido", condition: x => x != "");
                                    break;
                                case 3:
                                    pacientes[pacientenum].Edad = Input.Int("Ingrese la nueva edad", condition: x => x >= 0);
                                    break;
                                case 4:
                                    pacientes[pacientenum].Habitacion = Input.Int("Ingrese la nueva habitacion", condition: x => x >= 0);
                                    break;
                                case 5:
                                    pacientes[pacientenum].Cama = Input.Int("Ingrese la nueva cama", condition: x => x >= 0);
                                    break;
                                case 6:
                                    pacientes[pacientenum].Condicion = Input.String("Ingrese la nueva condicion", condition: x => x != "");
                                    break;
                                case 7:
                                    if (Input.String("Estas seguro de que lo quieres borrar? (s/N)").ToUpper() == "S")
                                    {
                                        pacientes.RemoveAt(pacientenum);
                                        seguir3 = false;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 5:
                        seguir=false;
                        break;
                    default:
                        break;
                }


            } while (seguir);
        }
    }

    abstract public class Persona
    {
        private string name;
        private string apellido;
        private int edad;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona(string Nombre, string Apellido, int Edad)
        {

            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
        }

        public virtual void mostrardatos() {
            Console.WriteLine($"{Nombre} {Apellido} es un {this.GetType().Name} de {Edad} años");
        }


    }

    public class Paciente : Persona {

        private int habitacion;
        private int cama;
        private string condicion;
        public int Habitacion { get; set; }
        public int Cama { get; set; }

        public string Condicion 
        { 
            get { return condicion; } 
            set { condicion = value.ToUpper(); } 
        }
        public Paciente(string Nombre, string Apellido, int Edad, int habitacion, int cama, string condicion): base(Nombre, Apellido, Edad)
        {

            this.Habitacion = Habitacion;
            this.Cama = Cama;
            this.Condicion = condicion;
        }

        public override void mostrardatos()
        {
            Console.WriteLine($"{Nombre} {Apellido} es un {this.GetType().Name} de {Edad} años, que está en la habitación {Habitacion} cama {Cama}. Esta en el hospital por {Condicion}");
        }

    }

    public class Medico : Persona
    {
        private int salario;
        public int Salario { get; set; }
        public Medico(string Nombre, string Apellido, int Edad, int Salario) : base(Nombre, Apellido, Edad)
        {


            this.Salario = Salario;
        }
        public override void mostrardatos()
        {
            Console.WriteLine($"{Nombre} {Apellido} es un {this.GetType().Name} de {Edad} años, que cobra {Salario} al mes");
        }
    }

    */

    /*
    internal class Program
    {

        static void Main(string[] args)

        {
            StreamWriter? texto=null;
            string inpstr;

            while (texto==null) {
                inpstr = Input.String("Cual archivo de texto desea crear/usar? (defecto: C:\\Programacion\\animales.txt)");
                if (inpstr == "")
                    inpstr = "C:\\Programacion\\animales.txt";

                try
                {
                    texto = File.CreateText(inpstr);
                }
                catch (DirectoryNotFoundException ex) {
                    Console.WriteLine("La carpeta en la que se encuentra la dirección que ingreso no existe. por favor elija otra");

                }
            }
            for (int x = 0; x < 5; x++) {
                texto.WriteLine(
                    Input.String("Ingrese el nombre de un animal", x => x != ""));
            }



            texto.Close();

        }
    }
    */
}