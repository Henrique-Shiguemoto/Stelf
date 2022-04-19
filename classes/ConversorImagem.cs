using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Stelf.classes
{
    public static class ConversorImagem
    {
        public static Image BytesToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
