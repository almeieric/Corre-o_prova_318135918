using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA
{
    class Program
    {
        //exercicio1
        static int Maior(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;

        }
        static int Maior2(int a, int b)
        {
            return (a > b) ? a : b;

        }


        //exercicio 3
        static bool Par(int c)
        {
            if (c % 2 == 0){
                return true;

            }
            else
            {
                return false ;
            }
        }
        static string Par2(int c)
        {
            if (c % 2 == 0)
            {
                return c + " é par";

            }
            else
            {
                return c + " é impar";
            }
        }

        static void Main()
        {
            Console.WriteLine("Nome: Eric Almeida do Espirito Santo/n RA:318135918");

            //Exercicio 1
            Console.WriteLine("Insira primeiro Numero:");
            




            int a = Int32.Parse(Console.ReadLine());//recebe numero a
           // Console.WriteLine("primeiro numero é: " + a);//mostra numero a na tela
            int b = Int32.Parse(Console.ReadLine());//recebe numero b
            Console.WriteLine("Segundo numero é: " + b);//mostra numero b na tela

            Console.WriteLine(Maior(a , b) + " é o maior numero");
            //Exercicio 2


            /*Console.WriteLine("Informe seu peso");
            double massa = Double.Parse(Console.ReadLine());//informa peso
            Console.WriteLine("Seu Peso é: " + massa);
            Console.WriteLine("Informe sua altura");
            double altura = Double.Parse(Console.ReadLine());//informa altura
            Console.WriteLine("Sua Altura é: " + altura);

            Construtor cos = new Construtor(massa, altura);//pega a formula na outra classe

            if (cos.imc < 16)//verifica a tabela de IMC
            {
                Console.WriteLine("voce tem Magreza moderada\n");
            }
            else if (cos.imc > 17)
            {
                Console.WriteLine("voce tem Magreza moderada\n");
            }
            else if (cos.imc < 18.5)
            {
                Console.WriteLine("voce tem Magreza Leve\n");
            }
            else if (cos.imc < 25)
            {
                Console.WriteLine("voce esta saudavel\n");
            }
            else if (cos.imc < 30)
            {
                Console.WriteLine("voce esta com sobrepeso\n");
            }
            else if (cos.imc < 35)
            {
                Console.WriteLine("voce esta com obesidaed de primeiro grau\n");
            }
            else if (cos.imc < 40)
            {
                Console.WriteLine("voce esta com obesidaed de segundo grau(severa)\n");
            }
            else
            {
                Console.WriteLine("voce esta com obesidaed de terceiro grau(morbida)\n");
            }



    */



            //exercicio 3
            Console.WriteLine("é Par ou Impar?\nInsira um Numero");
             int parImpar = Int32.Parse(Console.ReadLine());//recebe o numero

            // int par = 0;
            // par = parImpar % 2;

             //if (par == 0)//verifica se é par
              //   Console.WriteLine(parImpar + " é um numero par\n");
             //else
             //    Console.WriteLine(parImpar + " é um numero impar\n");

     
            Console.WriteLine(Par2(parImpar));
            Console.ReadKey();



            //exercicio 4

            double x = 0;
            x = Math.Abs(7.5);
            Console.WriteLine("a: " + x);// ira retornar o valor 7,5

            x = Math.Floor(7.5);
            Console.WriteLine("b: " + x);//ira retornar o valor 7 e desconsiderara tudo apos a virgula

            x = Math.Abs(0.0);
            Console.WriteLine("c: " + x);//ira retornar valor 0

            x = Math.Ceiling(0.0);
            Console.WriteLine("d: " + x);// ira retornar valor 0

            x = Math.Abs(-6.4);
            Console.WriteLine("e: " + x);//ira retornar o valor de 6,4

            x = Math.Ceiling(-6.4);
            Console.WriteLine("f: " + x);//ira retornar o valor 6 e desconsiderara tudo apos a virgula

            x = Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5)));
            Console.WriteLine("g: " + x);//ira retornar o valor 14

            Console.ReadKey();


        }
    }
}
