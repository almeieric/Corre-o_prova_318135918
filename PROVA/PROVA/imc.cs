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
        public IMC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }
        public double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
     
        }

        public double Classificar(double imc)
        {
            return 0.0;
        }
        
            
      
     
    }
}
