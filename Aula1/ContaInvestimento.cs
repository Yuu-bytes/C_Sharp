namespace Aula1
{
    public class ContaInvestimento : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            valor += 1.1;
            base.Depositar(valor);
        }
    }
}
