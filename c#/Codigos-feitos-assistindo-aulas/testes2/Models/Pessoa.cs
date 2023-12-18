using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testes2.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public int idade
        { 
            get => _idade;
            set
            {
                if(value < 0 )
                {
                    throw new ArgumentNullException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }
        public string nome 
        {
             get => _nome.ToUpper();
             set
             {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                    _nome = value;
                }
             } 
        }

        public void Apresnetar()
        {
            Console.WriteLine($"nome: {nome}, Idade: {idade}"); 
        }
    }
}