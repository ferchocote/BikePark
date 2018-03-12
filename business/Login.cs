using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class Login
    {
        Context dbo = new Context();

        public int ValidarLogin(int entero)
        {
            int response = 0;

            if (entero == 0)
            {
                response = 1;
            }

            return response;
        }
    }
}
