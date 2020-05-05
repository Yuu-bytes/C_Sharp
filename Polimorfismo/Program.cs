using System;
using System.Collections.Generic;
using System.Linq;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            Gato gato = new Gato();
            Peixe peixe = new Peixe();

            List<Animal> listaAnimais = new List<Animal>();
            listaAnimais.Add(cachorro);
            listaAnimais.Add(gato);
            listaAnimais.Add(peixe);

            foreach(Animal animal in listaAnimais){
                Console.WriteLine("Eu sou um " + animal + " que " + animal.QualHabitat());
            }
        }
    }
}
