﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Stelf
{
    public class Desenvolvedora
    {
        public ObjectId _id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String contaBancaria { get; set; }
        public String Senha { get; set; }
    }
}
