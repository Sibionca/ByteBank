using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //cria os novos clientes

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

        }
    }
}

