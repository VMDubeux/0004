using System;
using System.Globalization;

namespace Exercicio
{
    class ProjetoQuatro
    {
        static void Main(string[] args) {
            Console.WriteLine("Qual o seu nome completo:");
            string[] v_nome = Console.ReadLine().Split(' ');
            string prim_nome = v_nome[0];
            Console.WriteLine("Há quantos quartos em sua casa? ");
            sbyte quartos = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço do produto desejado?");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine($"{prim_nome}, diga sua idade:");
            sbyte idad = sbyte.Parse(Console.ReadLine());
            Console.WriteLine($"{prim_nome}, diga sua altura:");
            float alt = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"{prim_nome}, você tem {idad} anos de idade e a sua altura é {alt.ToString("F2", CultureInfo.InvariantCulture)} cm. ");
            Console.Write($"A sua casa possui {quartos} quartos e o produto que desejas comprar custa somente R${preco.ToString("F2", CultureInfo.InvariantCulture)}!");
        }
    }
}