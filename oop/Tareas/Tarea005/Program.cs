namespace Tarea005
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int cantautos = Input.Int("Cuantos autos quieres ingresar", condition: (x) => x>=0);
            int cantmotos = Input.Int("Cuantas motos quieres ingresar", condition: (x) => x>=0);
            int cantcamis = Input.Int("Cuantas camionetas quieres ingresar", condition: (x) => x>=0);
            Vehiculo[] vehiculos = new Vehiculo[cantautos+cantmotos+cantcamis];

            for (int i = 0; i < vehiculos.Length; i++)
            {
                if (i < cantautos)
                    vehiculos[i] = new Auto(
                        Input.Float($"Cuanto pesa el {i + 1}° auto? (kg)"),
                        Input.String("Cual es la patente del auto?", (x) => int.TryParse(x, out _)),
                        Input.Int("Cuantos asientos tiene?"));
                 else if (i < cantautos + cantmotos)
                    vehiculos[i] = new Moto(
                        Input.Float($"Cuanto pesa la {i+1-cantautos}° moto? (kg)"),
                        Input.String("Cual es la patente de la moto?", (x) => int.TryParse(x, out _)),
                        (Moto.TipoDeMoto)Input.Int("De que tipo es? (0: deportiva, 1: todo terreno, 2:urbana)", condition:(x) => x == 0 || x == 1 || x == 2 ));
                else 
                    vehiculos[i] = new Camioneta(
                        Input.Float($"Cuanto pesa la {i+1-cantautos-cantmotos}° camioneta? (kg)"),
                        Input.String("Cual es la patente de la camioneta?", (x) => int.TryParse(x, out _)),
                        Input.Int("Tiene caja o baul (0: baul, 1: caja)?", condition: (x) => x is 0 or 1)==1); //el visual me dijo que en vez de x==0||x==1 haga esto. sera mas rapido?
            }
            float pesototal=0;
            float pesomotos=0;
            float pesoautos = 0;
            float pesocamis = 0;
            int patparmoto = 0;
            int patimpcami = 0;
            for (int i = 0; i < vehiculos.Length; i++)
            {
                string printstr="";
                string endstr="";
                switch (vehiculos[i])
                {
                    case Auto:
                        printstr = $"El {i+1}° auto      ";
                        Auto auto = (Auto)vehiculos[i];
                        endstr = $"y tiene {auto.cantidadAsientos} asinetos";
                        pesoautos += auto.weight;
                        break;
                    case Moto:
                        printstr = $"La {i + 1 - cantautos}° Moto      ";
                        Moto moto = (Moto)vehiculos[i];
                        endstr = $"y es una moto {moto.tipo}";
                        pesomotos += moto.weight;
                        patparmoto += int.Parse(moto.license_plate) % 2 == 0 ? 1 : 0;
                        break;
                    case Camioneta:
                        printstr = $"La {i + 1 - cantmotos - cantautos}° Camioneta ";
                        Camioneta camioneta = (Camioneta)vehiculos[i];
                        endstr = $"y tiene {(camioneta.tienecaja ? "caja" : "baul")}";
                        pesocamis += camioneta.weight;
                        patimpcami += int.Parse(camioneta.license_plate) % 2 == 0 ? 0 : 1;
                        break;

                }
                pesototal += vehiculos[i].weight;
                printstr += $"con patente { vehiculos[i].license_plate} " +
                            $"pesa {vehiculos[i].weight}, "+endstr;

                Console.WriteLine(printstr);
            }
            Console.WriteLine($"El peso total de todos los vehiculos es {pesototal}");
            if (cantmotos>0)
                Console.WriteLine($"El promedio del peso de las motos es {pesomotos / (float)cantmotos}");
            if (cantautos>0)
                Console.WriteLine($"El promedio del peso de los autos es {pesoautos / (float)cantautos}");
            if (cantcamis>0)
                Console.WriteLine($"El promedio del peso de las camionetas es {pesocamis / (float)cantcamis}");
            if (cantmotos>0)
                Console.WriteLine($"Hubieron {patparmoto} patentes pares de motos");
            if (cantcamis>0)
                Console.WriteLine($"Hubieron {patimpcami} patentes impares de camionetas");
        
        }
    }
    

}


