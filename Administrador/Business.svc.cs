using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using business;

namespace Administrador
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Business" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Business.svc o Business.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Business : IBusiness
    {
        public void DoWork()
        {
            Login login = new Login();

            var response = login.ValidarLogin(0);
        }

        public void DoWork2()
        {
        }
    }
}
