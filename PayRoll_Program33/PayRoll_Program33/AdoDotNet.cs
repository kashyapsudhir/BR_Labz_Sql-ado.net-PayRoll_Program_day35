using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PayRoll_Program33
{
    public class AdoDotNet
    {

        public void Update()
        {
            try
            {


                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;database=payroll_service; Integrated Security=True";
                string query = @"update employee_payroll set Salary=10000 where Name='Mohan'";
                SqlConnection connetion = new SqlConnection(connectionString);
                connetion.Open();
                SqlCommand command = new SqlCommand(query, connetion);
                if (command.ExecuteNonQuery() == 1)
                    Console.WriteLine("Record Updated Successfully");
                connetion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}