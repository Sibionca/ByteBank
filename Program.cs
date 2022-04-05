using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando uma nova conta do tipo ContaCorrente, que é nossa classe

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela de Alcantara";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 5000.00;

            Console.WriteLine("Titular da Conta: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número da conta: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);
            Console.WriteLine("---------------------------------------------------------" + "\n");

            //nova conta com funcionalidade de saque e deposito

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno oliveira";
            contaDoBruno.agencia = 863;
            contaDoBruno.numero = 863453;
            contaDoBruno.saldo = 75.0;


            Console.WriteLine("Titular da Conta: " + contaDoBruno.titular);
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

            Console.WriteLine("Bruno, após a transferência seu saldo é: " + contaDoBruno.saldo);
            Console.WriteLine("Gabriela, você recebeu uma transferência, seu saldo é: " + contaDaGabriela.saldo);




            Console.ReadLine();

        }
    }
}

