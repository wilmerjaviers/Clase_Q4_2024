
namespace Clase_Q4_2024
{
    public class Ave
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Color { get; set; }
        public double Tamano { get; set; }
        public string Habitat { get; set; }

        public FamiliaAves familia;
        public Ave() { 
        familia = new FamiliaAves();

        }


        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano} cm");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Nombre: {familia.Nombre}");
            Console.WriteLine($"Numero de Especie: {familia.NumeroEspecie}");
            Console.WriteLine($"Caracteristicas: {familia.Caracteristicas}");
        }
    }
}