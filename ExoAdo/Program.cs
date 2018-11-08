using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoAdo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=UTILISA-PFCSKJJ\\SQLEXPRESS;Initial Catalog=WideWorldImporters;Integrated Security=True";

            string queryString = "SELECT FullName, PreferredName, LogonName, PhoneNumber, ValidFrom, ValidTo "
                + "from Application.People "
                + "WHERE IsPermittedToLogon = 1";

            WriterFile writerFile = new WriterFile();
            
            List<People> peoples = new List<People>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        People people = new People(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToDateTime(reader[4]), Convert.ToDateTime(reader[5]));
                        peoples.Add(people);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            writerFile.WriteInFile(peoples);
            Console.ReadLine();
        }
    }
}
