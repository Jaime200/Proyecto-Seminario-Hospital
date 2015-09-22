using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_ConectorBD
{
    internal class csDefaultSettings
    {
        internal csDefaultSettings()
        {
            csConfig.EnviarDatos("pPassAdmin", sPassAdmin);
            csConfig.EnviarDatos("pLocalHost", sLocalHost);
            csConfig.EnviarDatos("pServer", sServer);
            csConfig.EnviarDatos("pBaseDatos", sBaseDatos);
            csConfig.EnviarDatos("pUser", sUserBD);
            csConfig.EnviarDatos("pPassBD", sPassBD);
            csConfig.EnviarDatos("pConexion", sConexion);
        }

        private static string sPassAdmin = "shkvX8cYtOc=";
        private static string sBaseDatos = "9W1CYq6vlxxGLd7edXOVBg==";
        private static string sUserBD = "YNkjC1z/3o4=";
        private static string sPassBD = "keaSKzYjlcU=";
        private static string sLocalHost = "bhfv1wxYhAsHrX1tquZZxA==";
        private static string sServer = "8lQDvecQCGM=";
        private static string sConexion = "Localhost";

    }

}
