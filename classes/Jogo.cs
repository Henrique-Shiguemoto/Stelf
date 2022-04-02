using System;
using System.Collections.Generic;
using System.Text;

namespace Stelf
{
    public class Jogo
    {
        public int id { get; set; }
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
