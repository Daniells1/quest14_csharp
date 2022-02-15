/*
 Desafio
Faça a leitura de um valor inteiro. Em seguida, calcule o menor número de notas possíveis (cédulas) onde o valor pode ser decomposto. As notas que você deve considerar são de 100, 50, 20, 10, 5, 2 e 1. Na sequência mostre o valor lido e a relação de notas necessárias.

Entrada
Você receberá um valor inteiro N (0 < N < 1000000).

Saída
Exiba o valor lido e a quantidade mínima de notas de cada tipo necessárias, seguindo o exemplo de saída abaixo. Após cada linha deve ser imprimido o fim de linha.

Exemplo de Entrada	

576

Exemplo de Saída
576
5 nota(s) de R$ 100,00
1 nota(s) de R$ 50,00
1 nota(s) de R$ 20,00
0 nota(s) de R$ 10,00
1 nota(s) de R$ 5,00
0 nota(s) de R$ 2,00
1 nota(s) de R$ 1,00
 */
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace quest14_csharp
{

    class Program

    {

        static void Main(string[] args)

        {

            int valor1 = Convert.ToInt32(Console.ReadLine());

            int valor2 = valor1;

            int nota100 = 0;
            int nota50 = 0;
            int nota20 = 0;
            int nota10 = 0;
            int nota5 = 0;
            int nota2 = 0;
            int nota1 = 0;

            while (valor1 >= 100)

            {

                nota100++;

                valor1 = valor1 - 100;

            }

            

            while (valor1 >= 50)

            {

                nota50++;

                valor1 = valor1 - 50;

            }

            

            while (valor1 >= 20)

            {

                nota20++;

                valor1 = valor1 - 20;

            }

           

            while (valor1 >= 10)

            {

                nota10++;

                valor1 = valor1 - 10;

            }

            

            while (valor1 >= 5)

            {

                nota5++;

                valor1 = valor1 - 5;

            }

           

            while (valor1 >= 2)

            {

                nota2++;

                valor1 = valor1 - 2;

            }

           

            while (valor1 >= 1)

            {

                nota1++;

                valor1 = valor1 - 1;

            }

            Console.WriteLine("{0}", valor2);

            Console.WriteLine("{0} nota(s) de R$ 100,00", nota100);

            Console.WriteLine("{0} nota(s) de R$ 50,00", nota50);

            Console.WriteLine("{0} nota(s) de R$ 20,00", nota20);

            Console.WriteLine("{0} nota(s) de R$ 10,00", nota10);

            Console.WriteLine("{0} nota(s) de R$ 5,00", nota5);

            Console.WriteLine("{0} nota(s) de R$ 2,00", nota2);

            Console.WriteLine("{0} nota(s) de R$ 1,00", nota1);

            Console.ReadLine();

        }

    }

}