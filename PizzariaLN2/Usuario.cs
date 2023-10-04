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
        //internal é mais restrito que public. Existem internal, publuc(acessível a qualque outro [projeto] de código) e private(acessível somente dentro daquela classe).
        //(1) e (3) - diferente de atributo que [pode] começa com '_' -> (isso é nomenclatura), propriedade começa com maiúsculo.
        //É pelo construtor que vc cmç a execusão da classe. Todo método precisa de um construtor por isso.

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

        //(1)
        private string _id;
        private string _name;
        private string _phone;
        private string _cpf;

        //(2)
        public Usuario(string name, string phone, string cpf)
        {
            Name = name;
            Phone = phone;
            Cpf = cpf;
        }

        //(3)
        //Propriedades
        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        public string Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }
    }
}
