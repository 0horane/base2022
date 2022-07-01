namespace Tarea005
{
    public abstract class Vehiculo
    {
        float weight;
        int license_plate;

        public Vehiculo(float weight, int license_plate)
        {
            this.weight = weight;
            this.license_plate = license_plate;
        }
    }

    public class Moto : Vehiculo
    {
        public TipoDeMoto tipo;
        
        public enum TipoDeMoto : int
        {
            Deportiva = 0,
            TodoTerreno = 1,
            Urbana = 2
        }

        public Moto(float weight, int license_plate, TipoDeMoto tipo ) : base(weight, license_plate)
        {
            this.tipo = tipo;
        }
    }

    public class Auto : Vehiculo
    {
        int cantidadAsientos;
        public Auto(float weight, int license_plate, int cantidadAsientos) : base(weight, license_plate)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
    }

    public class Camioneta : Vehiculo
    {
        public bool tienecaja; //true= caja   false=baul
        public Camioneta(float weight, int license_plate, bool tienecaja) : base(weight, license_plate)
        {
            this.tienecaja = tienecaja;
        }
    }
}


