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
        private string Raca;
        private double Peso;
        private double Altura;

        //Guardar determinada informação, validando ou não
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

        public void SetPeso(double peso)
        {
            if (peso < 0.1) 
            {
                throw new Exception("O peso deve ser maior que 0.1"); 
            }
            if (peso > 150)
            {
                throw new Exception("O peso deve ser menor que 150");
            }
            Peso = peso;
        }

        public void SetRaca(string raca)
        {
            if (raca.Count() < 3)
            {
                throw new Exception("A raça deve conter mais de 3 caracteres");
            }
            if (raca.Count() > 40)
            {
                throw new Exception("A race deve conter menos de 40 caracteres");
            }
            Raca = raca;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetRaca()
        {
            return Raca;
        }
        
        public double GetPeso()
        {
            return Peso;
        }

        public double GetAltura()
        {
            return Altura;
        }
    }
}
