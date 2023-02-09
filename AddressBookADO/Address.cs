using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AddressBookSystem
{
    public class Address
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookService;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public int GetAllEmployee()
        {
            int count=0,count1=0,count2=0;
            try
            {
               
                AddressModel employee = new AddressModel();
                using (this.connection)
                {
                    string query = @"SELECT FirstName,LastName,Address,City,State,zip,PhoneNum,Email,Type,Date from Addressbook";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employee.FirstName = dr.GetString(0);
                            employee.LastName = dr.GetString(1);                          
                            employee.Address = dr.GetString(2);
                            employee.City = dr.GetString(3);
                            employee.State = dr.GetString(4);
                            employee.zip = dr.GetString(5);
                            employee.PhoneNum = dr.GetString(6);
                            employee.Email = dr.GetString(7);
                            employee.Type = dr.GetString(8);
                            employee.Date= dr.GetString(9);

                              
                            Console.WriteLine(employee.FirstName + ", " +employee.LastName+", "+ employee.Address +", "+employee.City+", "+employee.State+", "+ employee.zip + "," + employee.PhoneNum + ", " + employee.Email + ", " + employee.Type);
                        }
                         
                       
                        Console.WriteLine("Count by state : "+ employee.State.Count());
                        Console.WriteLine("Count by city : " + employee.City.Count());
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                   
                    dr.Close();
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return count;
        }
        public int UpdateQueryBasedonName()
        {
            //Open Connection
            connection.Open();
            string query = "Update AddressBook set Email = 'shubhu@gmail.com' where FirstName = 'shubham'";
            //Pass query to TSql
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            int result = sqlCommand.ExecuteNonQuery();
            if (result != 0)
            {
                Console.WriteLine("Updated!");
            }
            else
            {
                Console.WriteLine("Not Updated!");
            }

            //Close Connection
            connection.Close();
            return result;
        }
        public void retriveByDate()
        {
            AddressModel employee = new AddressModel();
            //Open Connection
            connection.Open();
            string query = @"SELECT FirstName,Date from Addressbook";
            //Pass query to TSql
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    employee.FirstName = dr.GetString(0);
                    employee.Date = dr.GetString(1);

                    Console.WriteLine(employee.FirstName + "  is created :  " + employee.Date);
                }
            }
            else
            {
                Console.WriteLine("Not found!");
            }

            //Close Connection
            connection.Close();
           
        }


    }
}