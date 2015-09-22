using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace dll_ConectorBD
{
    public partial class csCAD
    {
        private static String sConeccion;
        private static MySqlConnection mySqlConeccion;
        private static int iValorConexion = 0;

        internal static int IValorConexion
        {
            get { return csCAD.iValorConexion; }
        }

        private static void vCAD()
        {
            if (csConfig.RecuperarDatos("pConexion", "Valor no Encontrado") == "Localhost")
            {
                sConeccion = "server=" + csCodificar.DesEncriptar(csConfig.RecuperarDatos("pLocalhost", "Valor no Encontrado")) + "; ";
            }
            else
            {
                if (csConfig.RecuperarDatos("pConexion", "Valor no Encontrado") == "Server")
                {
                    sConeccion = "server=" + csCodificar.DesEncriptar(csConfig.RecuperarDatos("pServer", "Valor no Encontrado")) + "; ";
                }
            }

            sConeccion += "database=" +csCodificar.DesEncriptar(csConfig.RecuperarDatos("pBaseDatos", "Valor no Encontrado")) + "; ";
            sConeccion += "Uid=" +csCodificar.DesEncriptar( csConfig.RecuperarDatos("pUser", "Valor no Encontrado"))+ "; ";
            sConeccion += "pwd=" + csCodificar.DesEncriptar(csConfig.RecuperarDatos("pPassBD", "Valor no Encontrado")) + "; ";
        }

        internal static MySqlConnection ObtenerConexion()
        {
            try
            {
                vCAD();
                mySqlConeccion = new MySqlConnection(sConeccion);
                mySqlConeccion.Open();
                iValorConexion = 0;
                return mySqlConeccion;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Conector MySQL");
                iValorConexion = 1;
                return null;
            }
        }

    }
}
