using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;

namespace business
{

    public class Login
    {
        private Context.Context dbo = new Context.Context();

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
