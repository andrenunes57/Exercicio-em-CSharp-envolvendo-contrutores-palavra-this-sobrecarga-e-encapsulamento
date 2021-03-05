using System.Globalization;

namespace Program120
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string NomeTitularDaConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaConta, string nomeTitularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitularDaConta = nomeTitularDaConta;
        }
        public ContaBancaria(int numeroDaConta, string nomeTitularDaConta, double valorDoDeposito) : this(numeroDaConta, nomeTitularDaConta)
        {
            Depositar(valorDoDeposito);
            //Saldo = valorDoDeposito; Esse trecho funciona, mas tira a exclusividade de depositar do metodo Depositar().
        }

        public void Depositar(double movimentarConta)
        {
            Saldo += movimentarConta;
        }
        public void Sacar(double movimentarConta)
        {
            Saldo -= movimentarConta + 5.00;
        }
        public override string ToString()
        {
            return "Conta "  
            + NumeroDaConta
            + ", Titular: "
            + NomeTitularDaConta
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
