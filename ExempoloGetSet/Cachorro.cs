using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempoloGetSet
{
    class Cachorro
    {
        private string Nome;
        public string Raca;
        public double Peso;
        private double Altura;

        public void SetNome(string nome)
        {
            if (nome.Count() < 3)
            {
                throw new Exception("Nome deve conter 3 letras");
            }
            if (nome.Count() > 40)
            {
                throw new Exception("Nome deve conter no máximo 40 caracteres");
            }
            Nome = nome;
        }

        public void SetAltura(double altura)
        {
            if (altura <= 0)
            {
                throw new Exception("Altura deve ser maior que 0");
            }
            if (altura > 2)
            {
                throw new Exception("Altura deve ser menor que 2 metros");
            }
            Altura = altura;
        }
    }
}
