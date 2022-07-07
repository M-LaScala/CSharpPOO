namespace POOAlura
{
    public class ContaCorrente
    {

        public static int TaxaOperacao;
        public Cliente Titular { get; set; } = new Cliente();
        public static int TotalDeContasCriadas { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int Agencia { get; }
        public int NumeroConta { get; }

        public double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        // Metodo construtor ( é usado para definir como criar um objeto )
        public ContaCorrente(int agencia, int numeroConta)
        {
            if (agencia <= 0 || numeroConta <= 0)
            {
                throw new ArgumentException($"Agencia:{agencia} ou NumeroConta:{numeroConta} devem ser maiores que 0.");
            }

            Agencia = agencia;
            NumeroConta = numeroConta;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valorSaque)
        {
            if (valorSaque < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valorSaque));
            }

            if (valorSaque > Saldo)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteExcepition(valorSaque, Saldo);
            }
            Saldo -= valorSaque;

        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
        }

        public void Transferir(double valorTransferencia, ContaCorrente contaDestino)
        {
            if (valorTransferencia < 0)
            {
                throw new ArgumentException("Valor inválido para a transferencia.", nameof(valorTransferencia));
            }

            try
            {
                Sacar(valorTransferencia);
            }
            catch (SaldoInsuficienteExcepition E)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operacao nao realizada.", E);
            }
            
            contaDestino.Depositar(valorTransferencia);
        }
    }
}
