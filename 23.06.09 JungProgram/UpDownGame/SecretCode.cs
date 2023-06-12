using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownGame
{
    public class SecretCode
    {
        private char theCode;

        public virtual void Init()
        {
            Random random = new Random();

            theCode = (char)random.Next(65, 90);
        }

        public char OutCode()
        {
            return theCode;
        }
    }
}
