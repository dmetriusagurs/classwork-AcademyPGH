using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace GardenBox2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = c:\users\d'metrius\source\repos\GardenBox2.0\GardenBox2.0\GardenBoxInfo.mdf; Integrated Security = True";
            //Create an application that asks the user for the size of their raised beds.

            Console.WriteLine("Welcome to the GardenBox2.0 App!");
            Console.WriteLine("Please Enter the following number to get started: Length of garden ");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the following number: Width of garden");
            int Width = Convert.ToInt32(Console.ReadLine());

            //Tell them what the perimeter and area of their garden is.
            int area = Width * Length;
            int perimeter = 2 * (Width + Length);
            bool loop = true;
            string PlantChoice = "";
            while (loop)
            {
                Console.WriteLine("The area of your garden is " + area + " and the perimeter is " + perimeter + " .");
                Console.WriteLine("With the numbers figured out, lets decide which plants you want!");
                Console.WriteLine(" ");
                Console.WriteLine("Pick from the following list: Basil, Carrots, Dill, Eggplant, Garlic");
                PlantChoice = Console.ReadLine().ToLower();
                // Then, using a database (with data from http://www.mysquarefootgarden.net/plant-spacing/) 
                // Allow the user to select which crop they wish to plant.

                if (PlantChoice == "basil")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * from Plants WHERE Id = '1'", conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            double numPlants = Convert.ToDouble(dataReader["Number/Sqft"]);
                            numPlants = (numPlants / 4) * area;
                            Console.WriteLine("You'll need " + numPlants + " Basil plants for your garden");
                            Console.ReadLine();
                        }
                    }
                    dataReader.Close();
                    conn.Close();
                }
                else if (PlantChoice == "carrots")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * from Plants WHERE Id = '2'", conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            double numPlants = Convert.ToDouble(dataReader["Number/Sqft"]);
                            numPlants = (numPlants / 4) * area;
                            Console.WriteLine("You'll need " + numPlants + " Carrots for your garden");
                            Console.ReadLine();
                        }
                    }
                    dataReader.Close();
                    conn.Close();
                }
                else if (PlantChoice == "dill")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * from Plants WHERE Id = '3'", conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            double numPlants = Convert.ToDouble(dataReader["Number/Sqft"]);
                            numPlants = Math.Ceiling((numPlants / 4) * area);
                            Console.WriteLine("You'll need " + numPlants + " Dill for your garden");
                            Console.ReadLine();
                        }
                    }
                    dataReader.Close();
                    conn.Close();
                }
                else if (PlantChoice == "eggplant")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * from Plants WHERE Id = '4'", conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            double numPlants = Convert.ToDouble(dataReader["Number/Sqft"]);
                            numPlants = Math.Ceiling((numPlants / 4) * area);
                            Console.WriteLine("You'll need " + numPlants + " Eggplants for your garden");
                            Console.ReadLine();
                        }
                    }
                    dataReader.Close();
                    conn.Close();
                }
                else if (PlantChoice == "garlic")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * from Plants WHERE Id = '5'", conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            double numPlants = Convert.ToDouble(dataReader["Number/Sqft"]);
                            numPlants = Math.Ceiling((numPlants / 4) * area);
                            Console.WriteLine("You'll need " + numPlants + " Garlic plants for your garden");
                            Console.ReadLine();
                        }
                    }
                    dataReader.Close();
                    conn.Close();
                }
                else
                {

                    Console.WriteLine("Please Choose a plant from the following list above");




                }

                Console.WriteLine("Wanna check out another plant option?[Yes]/[No]");
                string userinput = Console.ReadLine().ToLower();
                if (userinput == "no")
                {
                    loop = false;
                }

            }





            //Show the user how many plants of that crop they can fit into their space.
        }
    }
}

