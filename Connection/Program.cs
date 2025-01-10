using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Connection
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=DESKTOP-89CP21D;Database=ConnectionWithCode;Trusted_Connection=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();  
                    int result = EnterChoosens();
                    while (result != 0)
                    {
                        switch (result)
                        {
                            case 1:
                                string selectQuery = "Select * from workers";
                                ReadData(selectQuery, connection);
                                result = EnterChoosens();
                                break;
                            case 2:
                                string query = "Insert into workers(FirstName,LastName,Profession,Salary) values(@FirstName,@LastName,@Profession,@Salary)";
                                (string firstname,string lastname,string profession,decimal salary) = EnterWorkerDetails();
                                CreateData(query,connection, firstname, lastname, profession, salary);    
                                result = EnterChoosens();
                                break;
                                case 3:
                                Console.WriteLine("Id daxil edin");
                                int id = int.Parse(Console.ReadLine()); 
                                string deleteQuery = "DELETE FROM Workers WHERE Id = @Id";
                                DeleteData(id, connection);
                                result = EnterChoosens();
                                break;
                                case 4:
                                Console.WriteLine("Güncellemek istediğiniz çalışanın Id'sini girin:");
                                int updateId = int.Parse(Console.ReadLine());
                                (firstname, lastname, profession, salary) = EnterWorkerDetails();
                                string updateQuery = "UPDATE Workers SET FirstName = @FirstName, LastName = @LastName, Profession = @Profession, Salary = @Salary WHERE Id = @Id";
                                UpdateData(connection, updateId, firstname, lastname, profession, salary);
                                result = EnterChoosens();
                                break;
                            default:
                                result = EnterChoosens();
                                break;

                        }

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        
      
        
        static void UpdateData(SqlConnection connection, int id, string firstName, string lastName, string profession, decimal? salary)
        {
            string updateQuery = "UPDATE Workers " +
                                 "SET FirstName = @firstName, " +
                                 "LastName = @lastName, " +
                                 "Profession = @profession, " +
                                 "Salary = @salary " +
                                 "WHERE Id = @id";

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(profession))
            {
                throw new ArgumentException("FirstName, LastName ve Profession boş bırakılamaz.");
            }

            // Using bloğu ile bağlantıyı otomatik olarak yönetiyoruz
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@profession", profession);
                command.Parameters.AddWithValue("@salary", salary.HasValue ? (object)salary.Value : DBNull.Value);

                // Bağlantı açılır ve otomatik kapanır
                command.ExecuteNonQuery();
            }
        }

        static void ReadData(string selectQuery, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Id: " + reader.GetValue(0));
                        Console.WriteLine("FirstName: " + reader.GetValue(1));
                        Console.WriteLine("LastName: " + reader.GetValue(2));
                        Console.WriteLine("Position: " + reader.GetValue(3));
                        Console.WriteLine("Salary: " + reader.GetValue(4));
                        Console.WriteLine();

                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Ugurla icra olundu");

        }
        //static void DeleteData(int id,SqlConnection connection)
        //{

        //    using(SqlCommand command=new SqlCommand(deleteQuery,connection))
        //    {
        //        command.Parameters.AddWithValue("Id", id);
        //        int rowsAffected = command.ExecuteNonQuery();
        //    }
        //}
        static void DeleteData(int id, SqlConnection connection)
        {
            
            string deleteQuery = "DELETE FROM Workers WHERE Id = @Id";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                
                command.Parameters.AddWithValue("@Id", id);

                
                int rowsAffected = command.ExecuteNonQuery();


                Console.WriteLine($"{rowsAffected} row(s) deleted.");
            }
        }

        static int EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun 0 secim edin");
            Console.WriteLine("Datalari getrmek ucun 1 secim edin");
            Console.WriteLine("Data elave etmek ucun 2 secim edin");
            Console.WriteLine("Data silmek ucun 3 secim edin");
            Console.WriteLine("Data update etemek ucu 4 secin");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        //static void CreateData(string query, SqlConnection connection,string firstname,string lastname,string profession,decimal salary)
        //{
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //       command.Parameters.AddWithValue("@firstname",firstname);
        //        command.Parameters.AddWithValue("@lastname", lastname);
        //        command.Parameters.AddWithValue("@profession",profession)
        //        command.Parameters.AddWithValue("@salary",salary);

        //    }

        //}
        static void CreateData(string query, SqlConnection connection, string firstName, string lastName, string profession, decimal salary)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Profession", profession);
                command.Parameters.AddWithValue("@Salary", salary);
                int rowsAffected = command.ExecuteNonQuery(); 
                Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
            }
        }
        //value tuple
        static (string ,string ,string ,decimal ) EnterWorkerDetails()
        {
            Console.WriteLine("Worker adini yazdir");
            string firstname = Console.ReadLine();
            Console.WriteLine("Worker soyadini yazdir");
            string lastname = Console.ReadLine();
            Console.WriteLine("Worker Profession geyd et");
            string profession = Console.ReadLine();
            Console.WriteLine("Worker salary geyd et");
            decimal salary = decimal.Parse(Console.ReadLine());
            return (firstname, lastname, profession, salary);

        }
    }
}

