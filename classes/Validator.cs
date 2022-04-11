using System;
using System.Collections.Generic;
using System.Text;

namespace Stelf
{
    public static class Validator
    {
        private static int min_senha_length = 8;
        private static int max_senha_length = 16;
        private static int max_nome_length = 36;

        public static bool emailIsValid(string email)
        {
            try
            {
                if (!(email.EndsWith(".com") || email.EndsWith(".br")))
                {
                    return false;
                }

                var endereco = new System.Net.Mail.MailAddress(email);
                return endereco.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool isSenhaValid(string text)
        {
            bool valid = true;
            if (text.Length < min_senha_length || text.Length > max_senha_length)
            {
                valid = false;
            }
            return valid;
        }

        public static bool isNomeValid(string text)
        {
            bool valid = true;

            if (text.Length > max_nome_length)
            {
                valid = false;
            }

            //Conversão dos símbolos de text para um vetor de código ASCII ascii_symbols
            byte[] ascii_symbols = Encoding.ASCII.GetBytes(text);
            foreach (byte symbol in ascii_symbols)
            {
                //Verificando se symbol está entre A-Z, a-z, 0-9 ou é uma barra de espaço
                if (!((65 <= symbol && symbol <= 90) ||
                    (97 <= symbol && symbol <= 122) ||
                    (48 <= symbol && symbol <= 57) ||
                    (symbol == 32)))
                {
                    valid = false;
                }
            }

            return valid;
        }

        public static bool contaBancariaIsValid(string text)
        {
            if (text.Length == 0)
            {
                return false;
            }
            return true;
        }

        public static bool jogoIsValid(String preco, String faixaEtaria, Requisitos minRequisitos, Requisitos recRequisitos)
        {
            bool valid = true;

            bool isMinReqValid = isRequisitosValid(minRequisitos);
            bool isRecReqValid = isRequisitosValid(recRequisitos);
            bool isFaixaEtariaValid = !faixaEtaria.Equals("");

            bool isPrecoValid = true;
            try
            {
                float preco_float = float.Parse(preco);
                if (preco_float < 0)
                {
                    isPrecoValid = false;
                }
            }
            catch
            {
                isPrecoValid = false;
            }

            if (!isMinReqValid || !isRecReqValid || !isFaixaEtariaValid || !isPrecoValid)
            {
                valid = false;
            }

            return valid;
        }

        public static bool isRequisitosValid(Requisitos req)
        {
            try
            {
                Requisitos requisitos = new Requisitos();
                float ram = float.Parse(req.ram);
                float espDisc = float.Parse(req.espacoDisco);
                float rede = float.Parse(req.rede);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
