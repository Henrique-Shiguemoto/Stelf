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

            //@gmail.com, @outlook.com, @hotmail.com (uma ideia)
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
    }
}
