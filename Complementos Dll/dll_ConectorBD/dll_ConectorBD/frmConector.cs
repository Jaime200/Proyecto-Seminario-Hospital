
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dll_ConectorBD
{
    public partial class frmConector : Form
    {
        private static string sPassAdmin;

        public frmConector()
        {
            InitializeComponent();
        }

        private void frmConector_Load(object sender, EventArgs e)
        {
            vCargarConfiguracion();
            btnOcultarBD.Enabled = false;
            btnOcultarConexion.Enabled = false;

            txtLocalhost.Enabled = false;
            txtLocalhost.Enabled = false;
            txtServidor.Enabled = false;
            txtServidor.Enabled = false;
            
            txtBaseDatos.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;

            txtPassAdmin.Text = String.Empty;
            txtPassAdminNueva.Text = String.Empty;
        }

        private void vCargarConfiguracion()
        {
            vEvaluar(sPassAdmin = csCodificar.DesEncriptar(csConfig.RecuperarDatos("pPassAdmin", "Valor no Encontrado")));
            vEvaluar(txtLocalhost.Text = csCodificar.DesEncriptar(csConfig.RecuperarDatos("pLocalHost", "Valor no Encontrado")));
            vEvaluar(txtServidor.Text = csCodificar.DesEncriptar(csConfig.RecuperarDatos("pServer", "Valor no Encontrado")));
            vEvaluar(txtBaseDatos.Text = csCodificar.DesEncriptar(csConfig.RecuperarDatos("pBaseDatos", "Valor no Encontrado")));
            vEvaluar(txtUser.Text = csCodificar.DesEncriptar(csConfig.RecuperarDatos("pUser", "Valor no Encontrado")));
            vEvaluar(txtPass.Text = csCodificar.DesEncriptar(csConfig.RecuperarDatos("pPassBD", "Valor no Encontrado")));
            vEvaluar(csConfig.RecuperarDatos("pConexion", "Valor no Encontrado"));

            if (csConfig.RecuperarDatos("pConexion", "Valor no Encontrado") == "Localhost")
            {
                rdbLocalhost.Checked = true;
                rdbServer.Checked = false;
            }
            else
            {
                if (csConfig.RecuperarDatos("pConexion", "Valor no Encontrado") == "Server")
                {
                    rdbLocalhost.Checked = false;
                    rdbServer.Checked = true;
                }
            }
        }

        private void vEvaluar(String sVerificar)
        {
            if (String.Equals(sVerificar, "Valor no Encontrado"))
            {
                new csDefaultSettings();
                vCargarConfiguracion();
            }
        }

        private void btnMostrarConexion_Click(object sender, EventArgs e)
        {

            if (String.Equals(csCuadroDialogo.CuadroDialogo("Autenticación", "Contraseña", String.Empty), sPassAdmin))
            {
                txtServidor.PasswordChar = '\0';
                txtServidor.PasswordChar = '\0';
                txtLocalhost.PasswordChar = '\0';
                txtLocalhost.PasswordChar = '\0';

                btnMostrarConexion.Enabled = false;
                btnOcultarConexion.Enabled = true;

                txtServidor.Enabled = true;
                txtServidor.Enabled = true;
                txtLocalhost.Enabled = true;
                txtLocalhost.Enabled = true;

            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Conector MySQL");
            }

        }

        private void btnOcultarConexion_Click(object sender, EventArgs e)
        {
            vOcultarConexion();  
        }

        private void vOcultarConexion()
        {
            txtLocalhost.PasswordChar = '*';
            txtServidor.PasswordChar = '*';

            btnOcultarConexion.Enabled = false;
            btnMostrarConexion.Enabled = true;

            txtServidor.Enabled = false;
            txtServidor.Enabled = false;
        }

        private void btnMostrarBD_Click(object sender, EventArgs e)
        {
            if (String.Equals(csCuadroDialogo.CuadroDialogo("Autenticación", "Contraseña", String.Empty), sPassAdmin))
            {
                txtBaseDatos.PasswordChar = '\0';
                txtUser.PasswordChar = '\0';
                txtPass.PasswordChar = '\0';

                btnMostrarBD.Enabled = false;
                btnOcultarBD.Enabled = true;

                txtBaseDatos.Enabled = true;
                txtUser.Enabled = true;
                txtPass.Enabled = true;
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Conector MySQL");
            }
        }

        private void btnOcultarBD_Click(object sender, EventArgs e)
        {
            vOcultarBD();
        }

        private void vOcultarBD()
        {
            txtBaseDatos.PasswordChar = '*';
            txtUser.PasswordChar = '*';
            txtPass.PasswordChar = '*';

            btnOcultarBD.Enabled = false;
            btnMostrarBD.Enabled = true;

            txtBaseDatos.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
        }

        private void btnGuardarConexion_Click(object sender, EventArgs e)
        {
            if (String.Equals(csCuadroDialogo.CuadroDialogo("Autenticación", "Contraseña", String.Empty), sPassAdmin))
            {
                try
                {
                    IPAddress.Parse(txtLocalhost.Text);
                    IPAddress.Parse(txtServidor.Text);
                    csConfig.EnviarDatos("pLocalHost", csCodificar.Encriptar(txtLocalhost.Text));
                    csConfig.EnviarDatos("pServer", csCodificar.Encriptar(txtServidor.Text));
                    csConfig.EnviarDatos("pBaseDatos", csCodificar.Encriptar(txtBaseDatos.Text));
                    csConfig.EnviarDatos("pUser", csCodificar.Encriptar(txtUser.Text));
                    csConfig.EnviarDatos("pPassBD", csCodificar.Encriptar(txtPass.Text));

                    if (rdbLocalhost.Checked == true)
                    {
                        csConfig.EnviarDatos("pConexion", "Localhost");
                    }
                    else
                    {
                        if (rdbServer.Checked == true)
                        {
                            csConfig.EnviarDatos("pConexion", "Server");
                        }
                    }

                    vOcultarConexion();
                    vOcultarBD();

                    vCargarConfiguracion();

                    MessageBox.Show("Conexión Guardada Exitosamente", "Conector MySQL");
                }catch (Exception)
                {
                    MessageBox.Show("Dirección Ip no Valida", "Conector MySQL");
                }
              
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Conector MySQL");
            }

        }

        private void btnGuardarPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.Equals(sPassAdmin, txtPassAdmin.Text))
                {
                    csConfig.EnviarDatos("pPassAdmin", csCodificar.Encriptar(txtPassAdminNueva.Text));
                    vEvaluar(sPassAdmin = csCodificar.DesEncriptar(csConfig.RecuperarDatos("pPassAdmin", "Valor no Encontrado")));
                    MessageBox.Show("Cambio Efectuado Exitosamente", "Conector MySQL");

                    txtPassAdmin.Text = String.Empty;
                    txtPassAdminNueva.Text = String.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Guardar Contraseña", "Conector MySQL");
            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            csCAD.ObtenerConexion();

            if (csCAD.IValorConexion != 0)
            {
                MessageBox.Show("Error al tratar de realizar la conexión", "Conector MySQL");
            }
            else
            {
                MessageBox.Show("Conexión Realizada Exitosamente", "Conector MySQL");
            }

        }

    }
}
