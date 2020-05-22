using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Double b;
            Double h;
            Console.WriteLine("Calcule a área de um triângulo retângulo.");
            Console.WriteLine("informe a base do triângulo:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe a altura do triângulo:");
            h = Convert.ToDouble(Console.ReadLine());

            //Conta
            Console.WriteLine("Área = " + b*h/2);
        }
    }
}
