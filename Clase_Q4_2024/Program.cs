
using Clase_Q4_2024;


Ave ave = new Ave();
ave.Nombre = "Loro";
ave.Especie = "Amazona Aestiva";
ave.Color = "Verde";
ave.Tamano = 30.5;
ave.Habitat = "Bosques Tropicales";
ave.familia.Nombre = "1";
ave.familia.NumeroEspecie = 2;
ave.familia.Caracteristicas = "3";


ave.Imprimir();

Ave ave1 = new Ave();
ave1.Nombre = "Flamenco";
ave1.Especie = "Phoenicopteus roseus";
ave1.Color = "Rosa";
ave1.Tamano = 120;
ave1.Habitat = "Lagunas Salinas";
ave1.familia.Nombre = "4";
ave1.familia.NumeroEspecie = 5;
ave1.familia.Caracteristicas = "6";

Console.WriteLine();
ave1.Imprimir();