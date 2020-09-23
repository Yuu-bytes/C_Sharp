namespace Aula1
{
    public class ContaBancaria
    {
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public int Correntista { get; set; }
        public double Saldo { get; private set; }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public double VerSaldo()
        {
            return Saldo;
        }

    }
}
