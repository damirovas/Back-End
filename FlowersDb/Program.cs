using System.Data.SqlClient;

namespace FlowersDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=DESKTOP-89CP21D;Database=FlowersDb;Trusted_Connection=True";
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int result = EnterChoosens();
                    while(result != 0)
                    {
                        switch (result) 
                        {
                            case 1:
                                string readQuery = "Select * from Flowers";
                                ReadData(readQuery, connection);
                                result = EnterChoosens();
                                break;
                                case 2:
                                string createQuery = "Insert into Flowers (Name,Color,Price) values(@Name,@Color,@Price)";
                                (string name,string color,decimal price) = EnterFlowerDetails();
                                CreateData(createQuery, connection,name,color,price);
                                result = EnterChoosens();
                                break;
                                case 3:
                                result = EnterChoosens();   
                                    break;
                                case 4:
                                Console.WriteLine("Silinecek id daxil et");
                                int id = int.Parse(Console.ReadLine());
                                DeleteData(id, connection);
                                result = EnterChoosens();
                                break;
                                default:
                                result = EnterChoosens();
                                break;
                            
                        }

                    }
                    connection.Close();
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ReadData(string readQuery,SqlConnection connection)
        {
            
            using(SqlCommand command = new SqlCommand(readQuery,connection))
            {
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Id: " +reader.GetValue(0));
                        Console.WriteLine("Name: " + reader.GetValue(1));
                        Console.WriteLine("Color: " +reader.GetValue(2));
                        Console.WriteLine("Price: " +reader.GetValue(3));

                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Ugurla icra olundu");
        }
        static void CreateData(string createQuery,SqlConnection connection,string name,string color,decimal price)
        {
            using(SqlCommand command= new SqlCommand(createQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Color", color);
                command.Parameters.AddWithValue("@Price", price);
                int affectedRows= command.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} rows affected");


            }
        }
        static void DeleteData(int id,SqlConnection connection)
        {
            string deleteQuery = "Delete  from Flowers where Id=@Id";
            using (SqlCommand command = new SqlCommand(deleteQuery,connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                int affectedRows = command.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} rows affected");
            }
            
        }

        static int EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun 0 secin");
            Console.WriteLine("Read etmek ucun 1 secin");
            Console.WriteLine("Add etmek ucun 2 secin");
            Console.WriteLine("Update etmek ucun 3 secin");
            Console.WriteLine("Delete etmek ucun 4 secin");

            int result = int.Parse(Console.ReadLine());
            return result;
        }

        static (string,string ,decimal) EnterFlowerDetails()
        {
            Console.WriteLine("Enter Flower Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Flower Color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter Flower Price");
            decimal price = decimal.Parse(Console.ReadLine());
            return (name, color, price);
        }

    }
}
