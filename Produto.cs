using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;


namespace C_sharp_constructors_this_overloading_encapsulation
{
    public class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        private int _quantidade;


        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            _quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        //PROPERTIES
        public string Nome
        {
            //value = palavra reservada p/ receber o argumento
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        //ENCAPSULAMENTO
        // public string GetNome()
        // {
        //     return _nome;
        // }

        // public void SetNome(string nome)
        // {
        //     if (nome != null && nome.Length > 1)
        //     {
        //         _nome = nome;
        //     }
        // }

        // public double GetPreco(){
        //     return _preco;
        // }

        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nome: {_nome} - Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture)} - Quantidade: {_quantidade} - VALOR TOTAL: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void Adicionar(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void Remover(int quantidade)
        {
            _quantidade -= quantidade;
        }
    }
}
