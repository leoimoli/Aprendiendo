using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Aprendiendo.Entidades;

namespace Aprendiendo.BaseDatos
{
    public class DaoPersonaFisica
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool InsertarPersona(Persona _persona)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "InsertarPersona";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dni_in", _persona.Dni);
            cmd.Parameters.AddWithValue("Sexo_in", _persona.Sexo);
            cmd.Parameters.AddWithValue("Apellido_in", _persona.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", _persona.Nombre);
            cmd.Parameters.AddWithValue("Email_in", _persona.FechaNacimiento);      
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static List<Persona> ListarPersonas()
        {
            connection.Close();
            connection.Open();
            List<Persona> _listaClientes = new List<Persona>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarPersonas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Persona listaCliente = new Persona();
                    listaCliente.idPersona = Convert.ToInt32(item["idPersona"].ToString());
                    listaCliente.Dni = item["Sexo"].ToString();
                    listaCliente.Dni = item["Dni"].ToString();
                    listaCliente.Apellido = item["Apellido"].ToString();
                    listaCliente.Nombre = item["Nombre"].ToString();                  
                    listaCliente.FechaNacimiento = Convert.ToDateTime(item["FechaNacimiento"].ToString());                 
                    _listaClientes.Add(listaCliente);
                }
            }
            connection.Close();
            return _listaClientes;
        }
    }
}
