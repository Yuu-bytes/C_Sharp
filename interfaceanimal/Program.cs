using System;

namespace interfaceanimal
{
    class Program
    {
        static void Main(string[] args)
        {
            AcoesAnimais acoes = new AcoesAnimais();
            Tubarao babyShark = new Tubarao();
            Morcego batman = new Morcego();
            Golfinho flipper = new Golfinho();
            
            Console.WriteLine(acoes.TestarTubarao(babyShark));
            Console.WriteLine(acoes.TestarPeixe(babyShark));
            Console.WriteLine(acoes.TestarSeSabeNadar(babyShark));
            Console.WriteLine(acoes.TestarSeSabeNadar(flipper));

            Console.WriteLine(babyShark.Mergulhar());
            Console.WriteLine(flipper.Mergulhar());
            Console.WriteLine(flipper.Respirar());

            INadar algumAnimalNadador = new Tubarao();
            Console.WriteLine(algumAnimalNadador.Mergulhar());

            algumAnimalNadador = new Golfinho();
            Console.WriteLine(algumAnimalNadador.Mergulhar());
            ((Golfinho)algumAnimalNadador).Respirar(); //CAST, diz que o que tem ali é um golfinho, não é uma conversão

            algumAnimalNadador = new Pato();
            Console.WriteLine(algumAnimalNadador.Mergulhar());

    }
}
}
