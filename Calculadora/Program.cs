using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma();
            //Subcatrao();
            ////Divisao();
            //Multiplicacao();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.Out.WriteLine("Escolha uma operação ");
            Console.Out.WriteLine("1 - Soma");
            Console.Out.WriteLine("2 - Subtração");
            Console.Out.WriteLine("3 - Divisão");
            Console.Out.WriteLine("4 - Multiplicação");
            Console.Out.WriteLine("5 - Porcentagem");
            Console.Out.WriteLine("6 - Sair");

            Console.WriteLine("-------------");
            Console.Out.WriteLine("Selecione a operação: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subcatrao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Porcentagem(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            //if(res == 1)
            //{
            //    Soma();
            //}
            //if (res == 2)
            //{
            //    Soma();
            //}
            //if (res == 3)
            //{
            //    Soma();
            //}
            //if (res == 4)
            //{
            //    Soma();
            //}
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            //Console.WriteLine("O resultado da soma é" + resultado);
            Console.WriteLine($"O resultado da soma é{resultado}");
            //Console.WriteLine($"O resultado da soma é{v1 + v2}");
            //Console.WriteLine("O resultado da soma é" + (v1+v2));
            Console.ReadKey();
            Menu();
        }
        static void Subcatrao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse((string) Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse((string)Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao () 
        { 
            Console.Clear ();
  
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse (Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse (Console.ReadLine());

            Console.WriteLine("");
        
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado é{resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear ();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse (Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse (Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Porcentagem()
        {
            Console.Clear();

            Console.WriteLine("Valor :");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Porcentagem do desconto:");
            float v2 = float.Parse (Console.ReadLine());

            Console.WriteLine("");

            float vD = (v2 / 100) * v1;
            float resultado = v1 - vD; 
            Console.WriteLine($"O valor após o desconto é{resultado}");
            Console.ReadLine();
            Menu();
        }
    }
    
}