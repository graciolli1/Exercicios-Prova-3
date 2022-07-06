using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Prova_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3 – Criar um programa para calcular e mostrar a área de 3 figuras geométricas diferentes, não vale quadrado e nem retângulo.
            Observação: as figuras são de escolha livre, dá um Google se não lembrar como faz o cálculo de alguma delas.
            Requisitos: Deve ser apresentada uma lista para o usuário com o nome das 3 figuras que ele pode escolher para calcular.
            Deve-se utilizar Switch Case.*/
            int fig;
            Console.WriteLine("Escolha a figura: [1] Losângulo [2] Círculo [3] Trapézio");
            fig = Convert.ToInt16(Console.ReadLine());
            switch (fig)
            {
                case 1:
                    double diaMenor, dMiaMaior;
                    Console.WriteLine("Diagonal maior: ");
                    dMiaMaior = double.Parse(Console.ReadLine());
                    Console.WriteLine("Diagonal menor: ");
                    diaMenor = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do losângulo é: " + dMiaMaior * diaMenor / 2);
                    break;
                    
                case 2:
                    double raio;
                    Console.WriteLine("Raio da figura: ");
                    raio = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do círculo é (aproximadamente)" + (raio * raio) * 3.14);
                    break;
                case 3:
                    double baseMaior, baseMenor, alt;
                    Console.WriteLine("Base maior: ");
                    baseMaior = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base menor: ");
                    baseMenor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    alt = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do trapézio é: " + (baseMaior + baseMenor) * alt / 2);
                    break;
            }
            Console.ReadKey();

        }
    }
}
