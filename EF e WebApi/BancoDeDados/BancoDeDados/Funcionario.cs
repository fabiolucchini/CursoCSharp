using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados {
    internal class Funcionario {

        public void ObterLista() {
            //to get the connection string 
            //var _config = app.Services.GetRequiredService<IConfiguration>();
            //var connectionstring = _config.GetConnectionString("DefaultConnection");
            //build the sqlconnection and execute the sql command
            string connectionstring = "Server=W10PROX64EN60GB\\SQLEXPRESS;Database=CursoCSharp;User Id=fabio;Password=123456;Encrypt=False; TrustServerCertificate=False;";            
            using (SqlConnection conn = new SqlConnection(connectionstring)) {
                conn.Open();
                string commandtext = "select * from funcionarios";

                SqlCommand cmd = new SqlCommand(commandtext, conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Console.Write(reader["codf"].ToString()+"\t");
                    Console.Write(reader["Nome"].ToString()+"\t");
                    Console.Write(reader.GetInt32(2).ToString()+"\t");
                    Console.WriteLine(reader.GetString(3));                    
                }
                Console.WriteLine("==================================");
            }
            
        }

        public void ExecutarStoreProcedure(string connectionString, int codigo ) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Create the command and set its properties.
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "Consultar_Funcionario";
                command.CommandType = CommandType.StoredProcedure;

                // Add the input parameter and set its properties.
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Codigo";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = codigo;

                // Add the parameter to the Parameters collection.
                command.Parameters.Add(parameter);

                // Open the connection and execute the reader.
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()) {
                    if (reader.HasRows) {
                        while (reader.Read()) {
                            Console.WriteLine("Funcionario:{0}", reader[1]);
                        }
                    } else {
                        Console.WriteLine("Funcionario não encontrado: {0}", codigo);
                    }
                    reader.Close();
                }
            }
        }

        public void InserirDados(string connectionString) {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Funcionarios ([codf],[nome],[idade],[cidade],[salario],[cpf]) VALUES (6,'Fabio',45,'São Paulo',2900,'920001110')";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

    }

}
