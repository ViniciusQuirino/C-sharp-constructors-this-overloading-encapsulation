using System;
using System.Globalization;
using C_sharp_constructors_this_overloading_encapsulation;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco); 
            
            p.Mostrar();

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int numero = int.Parse(Console.ReadLine());
            p.Adicionar(numero);
            p.Mostrar();

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            numero = int.Parse(Console.ReadLine());
            p.Remover(numero);
            p.Mostrar();
        }
    }
}