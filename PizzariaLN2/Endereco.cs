using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzariaLN2
{
    internal class Endereco
    {
        private int _id;
        private string _pais;
        private string _estado;
        private string _cidade;
        private string _rua;
        private int _num;

        public Endereco(string pais,
                        string estado,
                        string cidade,
                        string rua,
                        int num)
        {
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Num = num;
        }

        public Endereco(int id,
                        string pais,
                        string estado,
                        string cidade,
                        string rua,
                        int num)
        {
            Id = id;
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Num = num;
        }

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Pais
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo país está vazio");
                _pais = value;
            }
            get { return _pais; }
        }

        public string Estado
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo estado está vazio");
                _estado = value;
            }
            get { return _estado; }
        }

        public string Cidade
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo cidade está vazio");
                _cidade = value;
            }
            get { return _cidade; }
        }

        public string Rua
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo rua está vazio");
                _rua = value;
            }
            get { return _rua; }
        }

        public int Num
        {
            set { _num = value; }
            get { return _num; }
        }
    }
}
