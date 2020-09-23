namespace Aula1
{
    public class ContaBancaria
    {
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public Correntista CorrentistaConta { get; set; }
        public double Saldo { get; private set; }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        public string VerSaldo()
        {
            return $"O saldo da conta {Numero} do {CorrentistaConta.Nome} é R$ {Saldo}";
        }

    }
}
