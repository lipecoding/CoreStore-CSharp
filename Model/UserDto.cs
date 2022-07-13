using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreStore_CSharp.Model
{
    public class UserDTO
    {
        private string user, pass, name, lname, b, l, cpf, cep;

        public string User { get => user; set => user = value; }

        public string Pass { get => pass; set => pass = value; }

        public string B { get => b; set => b = value; }

        public string L { get => l; set => l = value; }

        public string Cpf { get => cpf; set => cpf = value; }

        public string Cep { get => cep; set => cep = value; }

        public string Name { get => name; set => name = value; }

        public string Lname { get => lname; set => lname = value; }
    }
}