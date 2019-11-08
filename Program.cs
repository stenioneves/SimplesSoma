using System;

/*
 Código que soma um número entre 1 e 10 com os 100 números subsequentes.
 Autor: Stenio Neves

 */

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        { 

            Random random =new Random();

            int numero=random.Next(1,10);
            int aux= numero;
            for(int i=1;i<=100; i++){
              
              aux++;
              Console.WriteLine($"Posição :{i} === somando {numero}+{aux}={numero+aux}");


            }         
        }
    }
}
