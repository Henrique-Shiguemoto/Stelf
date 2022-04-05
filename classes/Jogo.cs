using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Stelf
{
    public class Jogo
    {
        public ObjectId _id { get; set; }
        public byte[] imagem { get; set; }
        public String nome { get; set; }
        public float preco { get; set; }
        public String genero { get; set; }
        public int faixaEtaria { get; set; }
        public Desenvolvedora desenvolvedora { get; set; }
        public Requisitos minRequisitos { get; set; }
        public Requisitos recRequisitos { get; set; }
        public String descricao { get; set; }
    }
}
