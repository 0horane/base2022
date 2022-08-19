using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc004_Programando_con_Objetos
{
    internal class Traductor
    {
        private string idiomaentrada, idiomasalida, ubicacionDirectorioDiccionario;
        private int distanciaLevenshteinMaxima;

        public Traductor(string _idiomaentrada, string _idiomasalida, string _ubicacionDirectorioDiccionario, int _distanciaLevenshteinMaxima) {
            string shdict = Path.GetFullPath(_ubicacionDirectorioDiccionario);
            idiomaentrada = _idiomaentrada;
            idiomasalida = _idiomasalida;
            
            distanciaLevenshteinMaxima = _distanciaLevenshteinMaxima;
        }

        public void CambiarIdiomaSalida(string _idiomasalida)
        {
            idiomasalida = _idiomasalida;
        }

        public void CambiarIdiomaEntrada(string _idiomaentrada)
        {
            idiomasalida = _idiomaentrada;
        }

        public string Traducir(string inputstring)
        {
            string dictfolder;
            string pdir1 = ubicacionDirectorioDiccionario + @"\" + $"{idiomaentrada}-{idiomasalida}";
            string pdir2 = ubicacionDirectorioDiccionario + @"\" + $"{idiomasalida}-{idiomaentrada}";
            if (Directory.Exists(pdir1))
            {
                dictfolder = pdir1;
            }
            else if (Directory.Exists(pdir2))
            {
                dictfolder = pdir2;
            }
            else
            {
                throw new Exception("No existe el diccionario correspondiente");
            }

            for (int i = 1; File.Exists(dictfolder + @"\" + $"index{char.ToUpper(idiomaentrada[0])}{idiomaentrada.Substring(1)}{i}.csv"); i++)

            while (File.Exists(dictfolder+@"\"+$"index{char.ToUpper(idiomaentrada[0])}{idiomaentrada.Substring(1)}"))

            return "";
        }
    }
}
