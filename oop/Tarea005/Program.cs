namespace Tarea005
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int cantautos = Input.Int(condition: (x) => x>=0);
            int cantmotos = Input.Int(condition: (x) => x>=0);
            int cantcamis = Input.Int(condition: (x) => x>=0);
            Vehiculo[] vehiculos = new Vehiculo[cantautos+cantmotos+cantcamis];

            for (int i = 0; i < vehiculos.Length; i++)
            {
                if (i < cantautos)
                    vehiculos[i] = new Auto(
                        Input.Float("Cuanto pesa el auto?"),  
                        Input.Int("Cual es la patente del auto?"),
                        Input.Int("Cuantos asientos tiene?"));
                 else if (i < cantautos + cantmotos)
                    vehiculos[i] = new Moto(
                        Input.Float("Cuanto pesa la moto?"),
                        Input.Int("Cual es la patente de la moto?"),
                        (Moto.TipoDeMoto)Input.Int("De que tipo es? (0: deportiva, 1: todo terreno, 2:urbana)", condition:(x) => x == 0 || x == 1 || x == 2 ));
                else 
                    vehiculos[i] = new Camioneta(
                        Input.Float("Cuanto pesa la camioneta?"),
                        Input.Int("Cual es la patente de la camioneta?"),
                        !(Input.Int("Tiene caja o baul (0: baul, 1: caja)?", condition: (x) => x is 0 or 1)==1));
            }


        
        }
    }
    

}


