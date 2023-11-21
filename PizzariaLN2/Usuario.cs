using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaLN2
{
    public class Usuario
    {
        //(1)
        //internal é mais restrito que public. Existem internal, publuc(acessível a qualque outro [projeto] de código/dá para acessar por meio de outras classes) e private(acessível somente dentro daquela classe).
        //(1) e (3) - diferente de atributo que [pode] começa com '_' -> (isso é nomenclatura), propriedade começa com maiúsculo.
        //É pelo construtor que vc cmç a execusão da classe. Todo método precisa de um construtor por isso.
        //Estão encapsulados(?)

        //(2)
        //Esse é o método construtor.
        //public Usuario(string name, string phone, string CPF)
        //{
        //    Name = name;
        //    Phone = phone;
        //    this.CPF = CPF;
        //}
        //Quando "0 referências' quer dizer que ninguém está usando ele.

        //(3)
        //validar os dados que o usuário está usando nessa classe.
        //Propriedades não tem ().
        //Set; setar um valor para a variável que está lá em cima (atribuir um valor) ((validação - ver se está correto)).
        //ger; retornar a um atributo que está lá em cima (retornar um valor).
        //throw new - lança a excessão para quem chamou a (classe) pq ele consegue lidar com isso (dizer que está errado).
        //ArgumentNullException - argumento está inválido (especifíca mais o Exception).

        //(4)
        //Tem que colocar try catch em locais onde possívelmente pode ter erro.

        //(1)
        private int _id;
        private string _name;
        private decimal _phone;
        private decimal _cpf;
        private string _pass;

        //(2)
        public Usuario(string name,
                        decimal phone,
                        decimal cpf)
        {
            Name = name;
            Phone = phone;
            Cpf = cpf;
        }
        public Usuario(int id, string name,
                        decimal phone,
                        decimal cpf)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Cpf = cpf;
        }
        public Usuario(decimal cpf, string pass)
        {
            Cpf = cpf;
            Pass = pass;
        }

        public Usuario(string name)
        {
            Name = name;
        }

        public Usuario(decimal cpf)
        {
            Cpf = cpf;
        }

        //(3)
        //Propriedades
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Name
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo nome está vazio");
                _name = value; 
            }
            get { return _name; }
        }
        public decimal Phone
        {
            set {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Campo telefone está vazio"); //(4)
                _phone = value; }
            get { return _phone; }
        }
        public string Pass
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo senha está vazio"); //(4)
                _pass = value;
            }
            get { return _pass; }
        }
        public decimal Cpf
        {
            set {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Campo CPF está vazio");
                _cpf = value; }
            get { return _cpf; }
        }
    }
}
