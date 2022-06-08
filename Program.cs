using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //cria os novos clientes

            Console.WriteLine( "\n\n" +
                "                 *----Criação dos novos clientes e funcionalidades do banco----*" + "\n\n");

            Cliente gabriela = new Cliente();

            gabriela.Nome = "Gabriela";
            gabriela.Profissao = "Desenvolvedora C#";
            gabriela.CPF = "434.562.878-20";

            Cliente bruno = new Cliente();

            bruno.Nome = "Bruno";
            bruno.Profissao = "Desenvolvedor FrontEnd";
            bruno.CPF = "128.194.167-25";

            
            //criando uma nova conta do tipo ContaCorrente, que é nossa classe


            ContaCorrente contaDaGabriela = new ContaCorrente(863, 863452);

            contaDaGabriela.Titular =  gabriela;
            contaDaGabriela.Saldo = 5000.00;

            //outra forma de ser feito a conta utilizando o cliente é:
            //contaDaGabriela.titular = new Cliente();
            //contaDaGabriela.titular.nome = "Gabriela"; e etc...
            


            Console.WriteLine("Titular da Conta: " + contaDaGabriela.Titular.Nome);
            Console.WriteLine("Agência: " + contaDaGabriela.Agencia);
            Console.WriteLine("Número da conta: " + contaDaGabriela.NumeroDaConta);
            Console.WriteLine("Saldo: " + contaDaGabriela.Saldo);
            Console.WriteLine("---------------------------------------------------------" + "\n");


            //nova conta com funcionalidade de saque e deposito
            

            ContaCorrente contaDoBruno = new ContaCorrente(863, 863453);

            contaDoBruno.Titular = bruno;
            contaDoBruno.Saldo = 200.00;


            Console.WriteLine("Titular da Conta: " + contaDoBruno.Titular.Nome);
            Console.WriteLine("Agência: " + contaDoBruno.Agencia);
            Console.WriteLine("Número da conta: " + contaDoBruno.NumeroDaConta);
            Console.WriteLine("Saldo: " + contaDoBruno.Saldo + "\n");
            contaDoBruno.Sacar(50);

            Console.WriteLine("após o saque seu saldo é: " + contaDoBruno.Saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine("após o deposito seu saldo é: " + contaDoBruno.Saldo);


            //Transferências

            Console.WriteLine("---------------------------------------------------------" + "\n");

            contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine(contaDoBruno.Titular.Nome + ", após a transferência seu saldo é: " + contaDoBruno.Saldo);
            Console.WriteLine(contaDaGabriela.Titular.Nome + ", você recebeu uma transferência, seu saldo é: " + contaDaGabriela.Saldo);

            Console.ReadLine();

            //Nova Operação com taxa que diminui a cada nova conta corrente criada

            Console.WriteLine("A taxa de operação atual é de " + ContaCorrente.TaxaOperacao + "%");


            //nova funcionalidade de criação de funcionários

            Console.WriteLine("---------------------------------------------------------" + "\n\n" +
                "                 *----Bonificações e salários dos funcionários----*" + "\n\n");


            // criação da bonificação
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            // criação do sistema interno de senhas para login
            SistemaInterno sistemaInterno = new SistemaInterno(); 

            Funcionario carlos = new Auxiliar("546.879.157-20");
            carlos.Nome = "Carlos";

            FuncionarioAutenticavel roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.Senha = "123456";

            FuncionarioAutenticavel camila = new GerenteDeConta("326.279.527-00");
            camila.Nome = "Camila";
            camila.Senha = "abcde";

            Funcionario paula = new Designer("001.238.538-35");
            paula.Nome = "Paula";

            Funcionario rodrigo = new Desenvolvedor("002.008.444-08");
            rodrigo.Nome = "Rodrigo";

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(paula);
            gerenciador.Registrar(rodrigo);

            Console.WriteLine("Bonificacao da Diretora " + roberta.Nome + ": " + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao do Auxiliar " + carlos.Nome + ":  " + carlos.GetBonificacao());
            Console.WriteLine("Bonificacao da Gerente de contas " + camila.Nome + ":  " + camila.GetBonificacao());
            Console.WriteLine("Bonificacao da Designer " + paula.Nome + ":  " + paula.GetBonificacao());
            Console.WriteLine("Bonificacao do Desenvolvedor " + rodrigo.Nome + ":  " + rodrigo.GetBonificacao());

            Console.WriteLine("\n" + "Total de funcionários: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Total de bonificações da empresa: " + gerenciador.GetTotalBonificacao());

            //nova funcionalidade de login para funcionários e parceiros comerciais do banco

            Console.WriteLine("\n" + "*----Login de funcionários----* " + "\n");

            sistemaInterno.Logar(roberta, "123456");
            sistemaInterno.Logar(camila, "abcdef");


            Console.ReadLine();


        }
    }
}

