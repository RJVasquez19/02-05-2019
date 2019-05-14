using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class manttoVendor
    {
        bdConex test = new bdConex();

        public String prueba() 
        {
            String mensaje;

            if(test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }else
            {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;
        }
    }
}
