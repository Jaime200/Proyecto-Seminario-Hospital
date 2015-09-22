using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace dll_ConectorBD
{
    internal partial class csConfig
    {
        internal static void EnviarDatos(String sLlave, String sValor)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(sLlave);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            config.AppSettings.Settings.Add(sLlave, sValor);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        internal static string RecuperarDatos(String sLlave, String sValorPredet)
        {
            String sRetornarValor = ConfigurationManager.AppSettings[sLlave];
            if (sRetornarValor == null)
            {
                sRetornarValor = sValorPredet;
            }

            return sRetornarValor;
        }

    }
}
