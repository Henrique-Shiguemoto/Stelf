using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Stelf
{
    public class Cliente
    {
        public ObjectId _id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String DataNascimento { get; set; }
        public String Senha { get; set; }
    }
}
