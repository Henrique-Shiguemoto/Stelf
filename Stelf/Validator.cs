using System;
using System.Collections.Generic;
using System.Text;

namespace Stelf
{
    public static class Validator
    {
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

        public static bool isValid(string text)
        {
            bool valid = true;
            if (text.Length < 8 || text.Length > 16)
            {
                valid = false;
            }

            //Convertemos cada caractere em seu código ASCII e armazenamos num vetor
            byte[] ascii_symbols = Encoding.ASCII.GetBytes(text);
            foreach (byte symbol in ascii_symbols)
            {
                //Temos que verificar se os símbolos digitados no Nome são letras maiúsculas
                // ou letras minúsculas ou algarismos
                if (!((65 <= symbol && symbol <= 90) ||
                    (97 <= symbol && symbol <= 122) ||
                    (48 <= symbol && symbol <= 57)))
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
