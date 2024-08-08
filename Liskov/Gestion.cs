using System;

namespace Liskov
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VelocidadMaxima { get; set; }

        public Vehiculo(string marca, string modelo, int velocidadMaxima)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadMaxima = velocidadMaxima;
        }

        public abstract void Conducir();

        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca { Marca }, Modelo {Modelo}, Velocidad Maxima { VelocidadMaxima }");
        }
    }

    class Coche : Vehiculo
    {
        public Coche(string marca, string modelo, int velocidadMaxima) : base(marca, modelo, velocidadMaxima)
        {
        }

        public override void Conducir()
        {
            Console.WriteLine($"El Coche { Modelo } esta llendo a una Velocidad de: { VelocidadMaxima }");
        }
    }

    class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca, string modelo, int velocidadMaxima)
            : base(marca, modelo, velocidadMaxima)
        {
        }

        public override void Conducir()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} está conduciendo a {VelocidadMaxima} km/h.");
        }
    }

    class Camion : Vehiculo
    {
        public Camion(string marca, string modelo, int velocidadMaxima)
            : base(marca, modelo, velocidadMaxima)
        {
        }

        public override void Conducir()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} está conduciendo a {VelocidadMaxima} km/h.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo coche = new Coche("Toyota", "Corolla", 180);
            Vehiculo motocicleta = new Motocicleta("Honda", "CBR", 220);
            Vehiculo camion = new Camion("Volvo", "FH16", 120);

            coche.MostrarDetalles();
            coche.Conducir();

            motocicleta.MostrarDetalles();
            motocicleta.Conducir();

            camion.MostrarDetalles();
            camion.Conducir();
        }
    }
}