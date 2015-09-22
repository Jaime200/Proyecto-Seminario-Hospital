using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace dll_ConectorBD
{
    public class csFunciones
    {
        private MySqlCommand mySqlComando;
        private MySqlDataAdapter mySqlDAdAdaptador;
        private MySqlDataReader mySqlRLector;

        public void vEjecutarDDL(string sQuery)
        {
                try
                {
                    mySqlComando = new MySqlCommand(sQuery,csCAD.ObtenerConexion());
                    mySqlComando.ExecuteNonQuery();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error al ejecutar la instrucción ", "MySql Conector");
                }
        }

        public DataTable dtObtenerRegistros(string sQuery)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                mySqlComando = new MySqlCommand(sQuery, csCAD.ObtenerConexion());
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al Realizar la Consulta", "MySql Conector", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return dtRegistros;
        }

        public ArrayList alConsultarRegistro(string sQuery)
        {
            ArrayList alTabla = new ArrayList();

            try
            {
                mySqlComando = new MySqlCommand(sQuery, csCAD.ObtenerConexion());
                mySqlRLector = mySqlComando.ExecuteReader();
                if (mySqlRLector.HasRows)
                {
                    while (mySqlRLector.Read())
                    {
                        ArrayList alFila = new ArrayList();
                        for (int iCont = 0; iCont < mySqlRLector.FieldCount; iCont++)
                        {
                            alFila.Add(mySqlRLector.GetString(iCont));
                        }
                        alTabla.Add(alFila);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Realizar la Consulta", "MySql Conector", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return alTabla;
        }
    }
}
