using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ---------------------------------------------------------
// POLIMORFISMO
// DEFINICION:
// El polimorfismo es la habilidad que tienen los objetos de
// reaccionar de manera diferente antes los mismos mensajes:
// ---------------------------------------------------------
namespace Consola01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciacion
            //persona objPersona = new persona();
            profesores objProfesor = new profesores();
            preceptores objPreceptores = new preceptores();
            // carga de informacion profesores
            objProfesor.apellido = " Perez " ;
            objProfesor.nombre = " Juan " ;
            objProfesor.edad = 45;
            objProfesor.fichaCensal = 56223;
            objProfesor.cantMaterias = 6;
            // muestra de informacion
            objProfesor.mostrarDatos(" profesor " );
            Console.WriteLine(" -----------------------------------------------");
            // carga de informacion preceptores
            objPreceptores.apellido = " Patricia " ;
            objPreceptores.nombre = " Gatti " ;

            objPreceptores.edad = 27;
            objPreceptores.legajo = 1041;
            objPreceptores.cantCurso = 2;
            // muestra de informacion
            objPreceptores.mostrarDatos(" preceptor " );
        }
    }
    abstract public class persona
    {
        // constructores
        public persona() { }
        // atributos
        public string apellido;
        public string nombre;
        public int edad;
        // metodos
        public virtual void mostrarDatos(string cargo)
        {
            Console.WriteLine(" El { 0} { 1} { 2} tiene { 3}    años ",cargo,apellido,nombre,edad);
        }
    }
    public class profesores : persona
    {
        // constructor
        public profesores() { }
        // atributos
        public int fichaCensal;
        public int cantMaterias;
        // metodos
        public override void mostrarDatos(string carg)
        {
            base.mostrarDatos(carg);
            Console.WriteLine(" su ficha censal es { 0} y tiene { 1} materias ", fichaCensal, cantMaterias);
        }
    }
    public class preceptores : persona
    {
        // constructor
        public preceptores() { }
        // atributos
        public int legajo;
        public int cantCurso;
        // metodos
        public override void mostrarDatos(string carg)
        {
            base.mostrarDatos(carg);
            Console.WriteLine(" su legajo es { 0} y tiene { 1} cursos ", legajo, cantCurso);
        }
    }
}