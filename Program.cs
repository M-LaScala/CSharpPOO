// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using POOAlura;
using POOAlura.Funcionarios;
using POOAlura.Sistemas;

Main();

static void Main()
{
    try
    {
        //CalcularBonificacao();
        //UsarSistema();
        //CadastrarClientes();
        CarregarContas(); 
    }
    catch (Exception E) //Classe exception é a mais alta na hierarquia
    {
        Console.WriteLine($"Error: {E.Source}\nDescription: {E.Message}\n{E.StackTrace}");
    }
    
}

static void CarregarContas()
{
    using (LeitorDeArquivo leitor = new LeitorDeArquivo("arquivo.txt"))
    {
        leitor.LerProximaLinha();
    }
}

static void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("456.648.120-30");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";

    GerenteDeConta camila = new GerenteDeConta("546.879.157-20");
    camila.Nome = "Camila";
    camila.Senha = "ABC";

    Desenvolvedor jorge = new Desenvolvedor("339.000.221-22");
    jorge.Nome = "Jorge";
    //jorge.Senha = "Teste";

    ParceiroComercial parceiro = new ParceiroComercial();
    parceiro.Senha = "1234";

    sistemaInterno.Logar(roberta, "123");
    sistemaInterno.Logar(camila, "ABC");
    sistemaInterno.Logar(parceiro, "1234");

}

static void CadastrarClientes()
{
    ContaCorrente conta1 = new ContaCorrente(300, 874150);
    ContaCorrente conta2 = new ContaCorrente(222, 892002);

    conta1.Depositar(50);
    Console.WriteLine(conta1.Saldo);
    conta1.Sacar(10);
    Console.WriteLine(conta1.Saldo);

    conta1.Transferir(400, conta2);


    Console.WriteLine(ContaCorrente.TaxaOperacao);
}

static void CalcularBonificacao()
{
    Funcionario carlos = new GerenteDeConta("546.879.157-20");
    carlos.Nome = "Carlos";
    carlos.AumentarSalario();

    Funcionario roberta = new Diretor("456.648.120-30");
    roberta.Nome = "Roberta";
    roberta.AumentarSalario();

    Funcionario matheus = new Desenvolvedor("471.232.999-20");
    matheus.Nome = "Matheus";
    matheus.AumentarSalario();

    Console.WriteLine(carlos.Nome);
    Console.WriteLine(carlos.GetBonificacao());
    Console.WriteLine(roberta.Nome);
    Console.WriteLine(roberta.GetBonificacao());
    Console.WriteLine(matheus.Nome);
    Console.WriteLine(matheus.GetBonificacao());

    Console.WriteLine(Funcionario.TotalDeFuncionarios);

    GerenciadorBonificacao GerenciadorBonificacao = new GerenciadorBonificacao();
    GerenciadorBonificacao.Registrar(carlos);
    GerenciadorBonificacao.Registrar(matheus);
    GerenciadorBonificacao.Registrar(roberta);

    Console.WriteLine(GerenciadorBonificacao.GetTotalBonificacao());
}

