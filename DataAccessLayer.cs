using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDental
{
    public class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Password=Luismars85;Persist Security Info=False;User ID=sa;Initial Catalog=Consultorio;Data Source=THEHOOLIGANS-V2");

        public void InsertTablaPacientes(TablaPacientes tablaPacientes)
        {
            try
            {
                conn.Open();
                string query = @"
                               INSERT INTO Pacientes(nombre_paciente, apellidos_paciente, celular_paciente, correo_paciente)
                               VALUES (@FirstName, @LastName, @Phone, @Email)
                                ";
                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = tablaPacientes.FirstName;
                firstName.DbType = System.Data.DbType.String;

                SqlParameter lastName = new SqlParameter("@LastName",tablaPacientes.LastName);
                SqlParameter phone = new SqlParameter("@Phone",tablaPacientes.Phone);
                SqlParameter email = new SqlParameter("@Email",tablaPacientes.Email);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(email);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<TablaPacientes> GetTablaPacientes()
        {
            List<TablaPacientes> tablaPacientes = new List<TablaPacientes>();
            try
            {
                conn.Open();
                string query = @" SELECT id_paciente, nombre_paciente, apellidos_paciente, celular_paciente, correo_paciente
                                FROM Pacientes";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    tablaPacientes.Add(new TablaPacientes 
                    { 
                        Id = int.Parse(reader["id_paciente"].ToString()),
                        FirstName = reader["nombre_paciente"].ToString(),
                        LastName = reader["apellidos_paciente"].ToString(),
                        Phone = reader["celular_paciente"].ToString(),
                        Email = reader["correo_paciente"].ToString(),

                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            return tablaPacientes;
        }
    }

}
