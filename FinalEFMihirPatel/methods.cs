using System;
using System.Data.Entity.Validation;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;


namespace FinalEFMihirPatel
{
    class methods
    {

        public static void View()
        {
            using (var bookcon = new BooksDbEntities())
            {
                var q1 = bookcon.Authors;

                foreach (var view in q1)
                {
                    Console.WriteLine($"{view.AuthorID,2} {view.FirstName,-15} {view.LastName,-15} {view.Phone,-15} {view.Address,-22}  {view.City,-12} {view.State,-12} ");
                }

            }
            Console.WriteLine("\n**********************************************************************************************");
        }


        public static void Add()
        {

            Console.WriteLine("\nAdd First Name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("\nAdd Last Name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("\nAdd Phone: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("\nAdd Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("\nAdd City: ");
            string city = Console.ReadLine();

            Console.WriteLine("\nAdd State: ");
            string state = Console.ReadLine();


            using (var bookcon = new BooksDbEntities())
            {

                try
                {
                    var add_author = new Author()
                    {
                        FirstName = fName,
                        LastName = lName,
                        Phone = phoneNumber,
                        Address = address,
                        City = city,
                        State = state
                    };
                    bookcon.Authors.Add(add_author);

                    bookcon.SaveChanges();

                    var q2 = bookcon.Authors;

                    foreach (var add in q2)
                    {
                        Console.WriteLine($"{add.AuthorID,2} {add.FirstName,-15} {add.LastName,-15} {add.Phone,-16} {add.Address,-20}  {add.City,-12} {add.State,-12} ");
                    }
                    Console.WriteLine("\nAuthor is successfully Added!!!");
                    Console.WriteLine("\n**********************************************************************************************");

                }
                catch (DbEntityValidationException)
                {
                    Console.WriteLine("\nInvalid Entry!!!");
                }

            }
        }
        public static void Update()
        {
            Console.WriteLine("\nEnter Author ID to update: ");
            int authID = Convert.ToInt32(Console.ReadLine());

            using (var bookcon = new BooksDbEntities())
            {
                try
                {
                    var update = bookcon.Authors.Find(authID);
                    if (update != null)
                    {
                        Console.WriteLine("\nUpdate First Name: ");
                        string updfName = Console.ReadLine();

                        Console.WriteLine("\nUpdate Last Name: ");
                        string updlname = Console.ReadLine();

                        Console.WriteLine("\nUpdate Phone: ");
                        string updPhoneNumber = Console.ReadLine();

                        Console.WriteLine("\nUpdate Address: ");
                        string updaddress = Console.ReadLine();

                        Console.WriteLine("\nUpdate City: ");
                        string updcity = Console.ReadLine();

                        Console.WriteLine("\nUpdate State: ");
                        string updstate = Console.ReadLine();

                        update.FirstName = updfName;
                        update.LastName = updlname;
                        update.Phone = updPhoneNumber;
                        update.Address = updaddress;
                        update.City = updcity;
                        update.State = updstate;

                        bookcon.SaveChanges();

                        var q3 = bookcon.Authors;


                        foreach (var upd in q3)
                        {
                            Console.WriteLine($"{upd.AuthorID,2} {upd.FirstName,-15} {upd.LastName,-15} {upd.Phone,-12} {upd.Address,-22}  {upd.City,-14} {upd.State,-14} ");
                        }
                        Console.WriteLine("\nAuthor data is successfully Updated...!!!!");
                        Console.WriteLine("\n**********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("\nThe Author ID entered is Invalid. Please select your option again.");
                    }
                }
                catch (DbEntityValidationException)
                {
                    Console.WriteLine("\nThe value entered is Invalid...!!!!");
                }

            }

        }

    }

}
