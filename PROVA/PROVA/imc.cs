using System;


namespace PROVA
{
    class IMC
    {
        
        private double peso;
        private double altura;
        
        public IMC()
        {
            this.altura = 0.0;
            this.peso = 0.0;
                        
        }
        
            
        
        public double CalcularIMC(double peso, double altura)
        {
            return  peso / (altura * altura);
     
        }

        public double Classificar(double imc)
        {
            if (imc < 16)//verifica a tabela de IMC
            {
                Console.WriteLine("voce tem Magreza grave\n");
            }
            else if (imc >= 16 && imc < 17 )
            {
                Console.WriteLine("voce tem Magreza moderada\n");
            }
            else if (imc >= 17 && imc < 18.5)
            {
                Console.WriteLine("voce tem Magreza Leve\n");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("voce esta saudavel\n");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("voce esta com sobrepeso\n");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("voce esta com obesidaed de primeiro grau\n");
            }
            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("voce esta com obesidaed de segundo grau(severa)\n");
            }
            else if (imc > 40)
            {
                Console.WriteLine("voce esta com obesidaed de terceiro grau(morbida)\n");
            }

            Console.WriteLine("Seu imc = ");
            return imc;
        }
         
       
        


    }
}
