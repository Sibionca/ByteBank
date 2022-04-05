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

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            Cliente bruno = new Cliente();

            bruno.nome = "Bruno";
            bruno.profissao = "Desenvolvedor FrontEnd";
            bruno.cpf = "128.194.167-25";

            //criando uma nova conta do tipo ContaCorrente, que é nossa classe

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular =  gabriela;
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 5000.00;


            Console.WriteLine("Titular da Conta: " + contaDaGabriela.titular.nome);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número da conta: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);
            Console.WriteLine("---------------------------------------------------------" + "\n");

            //nova conta com funcionalidade de saque e deposito

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = bruno;
            contaDoBruno.agencia = 863;
            contaDoBruno.numero = 863453;
            contaDoBruno.saldo = 75.0;


            Console.WriteLine("Titular da Conta: " + contaDoBruno.titular.nome);
            Console.WriteLine("Agência: " + contaDoBruno.agencia);
            Console.WriteLine("Número da conta: " + contaDoBruno.numero);
            Console.WriteLine("Saldo: " + contaDoBruno.saldo + "\n");
            contaDoBruno.Sacar(50);

            Console.WriteLine("após o saque seu saldo é: " + contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine("após o deposito seu saldo é: " + contaDoBruno.saldo);

            //Transferências

            Console.WriteLine("---------------------------------------------------------" + "\n");

            contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine(contaDoBruno.titular.nome + ", após a transferência seu saldo é: " + contaDoBruno.saldo);
            Console.WriteLine(contaDaGabriela.titular.nome +", você recebeu uma transferência, seu saldo é: " + contaDaGabriela.saldo);




            Console.ReadLine();

        }
    }
}

