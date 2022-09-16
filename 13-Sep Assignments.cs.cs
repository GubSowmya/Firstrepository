using AdminModule;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UserModule;
using CommonOptions;
using Handsonproj.UserModule;

namespace Handsonproj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> list = new List<Movie>();
            Movie m1 = new Movie() { MovieName = "SitaRaman", Language = "Tamil", Genre = "Love", Price = 120 };

            Movie m2 = new Movie() { Genre = "Action", Language = "Kanada", MovieName = "KGF2", Price = 140 };
            Movie m3 = new Movie() { MovieName = "777 Charlie", Language = "Kannada", Genre = "Adventure", Price = 120 };
            Movie m4 = new Movie() { MovieName = "Viruman", Language = "Tamil", Genre = "family", Price = 120 };
            Movie m5 = new Movie() { MovieName = "Vikram", Language = "Tamil", Genre = "Action", Price = 100 };
            Movie m6 = new Movie() { MovieName = "Not Reachable", Language = "English", Genre = "Thriller", Price = 150 };
            Movie m7 = new Movie() { MovieName = "Mahan", Language = "Tamil", Genre = "Action", Price = 120 };
            Movie m8 = new Movie() { MovieName = "Sillunu Oru kadhal", Language = "Tamil", Genre = "Love", Price = 120 };
            Movie m9 = new Movie() { MovieName = "Circus", Language = "Hindi", Genre = "Comedy", Price = 130 };
            Movie m10 = new Movie() { MovieName = "Gully Boy", Language = "Hindi", Genre = "Drama", Price = 180 };

            list.Add(m1); list.Add(m2); list.Add(m3); list.Add(m4); list.Add(m5); list.Add(m6); list.Add(m7); list.Add(m8);
            list.Add(m9);
            list.Add(m10);
            // Stock = list.Count;

            List<User> users = new List<User>();
            User user1 = new User("Salini", "Abcde", new DateTime(2022, 02, 2), "Silver");
            User user2 = new User("Sameer", "123456", new DateTime(2022, 03, 12), "Gold");
            User user3 = new User("Thashwanth", "23345", new DateTime(2022, 01, 23), "Platinum");
            User user4 = new User("Rubini", "34568", new DateTime(2022, 02, 14), "Gold");
            User user5 = new User("Eswari", "12344", new DateTime(2022, 1, 2), "Silver");
            User user6 = new User("Moorthy", "R1233", new DateTime(2022, 2, 2), "Platinum");
            User user7 = new User("Lavanya", "QWERTY", new DateTime(2022, 02, 2), "Gold");
            users.Add(user1); users.Add(user2); users.Add(user3); users.Add(user4); users.Add(user5); users.Add(user6); users.Add(user7);


            Console.WriteLine("Enter 1 for UserModule  2 for AdminModule  3 for Common Options");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Username and Password");
                    Action<string, string> Login = (string username, string password) =>
                    {
                        User name = users.Find(x => x.UserName == username);
                        User Pass = users.Find(x => name.Password == password);
                        if (name != null)
                        {
                            if (Pass != null)
                            {
                                Console.WriteLine(" Successfully Logged In ");
                                Console.WriteLine($"Hello {name.UserName} ");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("The Top Rated Movies Rented By others are :");
                                Console.ForegroundColor = ConsoleColor.White;
                                foreach (Movie Movies in list)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine(Movies.MovieName);
                                    Console.WriteLine(Movies.Language);
                                    Console.WriteLine(Movies.Genre);
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                string input;
                                do
                                {
                                    Console.WriteLine("Enter 1 for SearchList 2 for Borrow Movie 3 for Return Movie 4 for Show Your retnted List");
                                    int option = int.Parse(Console.ReadLine());
                                    switch (option)
                                    {
                                        case 1:
                                            Console.WriteLine("Enter 1 to SearchMovie ByLanguage 2 to SearchMovie by Genre");
                                            int choice = int.Parse(Console.ReadLine());

                                            switch (choice)
                                            {
                                                case 1:
                                                    Movie movie = new Movie();
                                                    movie.Searchbylanguage(list);
                                                    break;

                                                case 2:
                                                    Movie movie1 = new Movie();
                                                    movie1.SearchByGenre(list);
                                                    break;

                                                default:
                                                    Environment.Exit(1);
                                                    break;
                                            }
                                            break;
                                        case 2:

                                            User user = new User();
                                            user.BorrowMovie(list);
                                            break;
                                        case 3:

                                            User u1 = new User();
                                            u1.ReturnMovie(list);
                                            break;
                                        case 4:
                                            User u2 = new User();
                                            u2.ShowMyList();
                                            break;
                                        default:
                                            Environment.Exit(1);
                                            break;
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("If you want to continue Yes/No");
                                    input = Console.ReadLine();

                                }
                                while (input == "yes" || input == "yes");
                            }

                            else
                            {
                                Console.WriteLine("Password is incorrect");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Username doesnot exists");
                        }
                    };
                    Login(Console.ReadLine(), Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter Admin Operation to perform");
                    Console.WriteLine("1.Add User 2.Movie Modifications");
                    int Opt = int.Parse(Console.ReadLine());
                    Admin admin = new Admin();
                    switch (Opt)
                    {
                        case 1:
                            {
                                admin.AddUsers(users);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter 1 for Add Movie \n 2 for Update Movie \n 3 for delete Movie");
                                int ch2 = int.Parse(Console.ReadLine());
                                if (ch2 == 1)
                                {
                                    admin.AddMovies(list);
                                }
                                else if (ch2 == 2)
                                {
                                    admin.UpdateMovies(list);
                                }
                                else if (ch2 == 3)
                                {
                                    admin.DeleteMovies(list);
                                }
                                break;
                            }

                    }
                    break;
                case 3:
                    Console.WriteLine("Enter 1 for Change Password  2 for to changeprofile");
                    Coption opt = new Coption();

                    int n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        Console.WriteLine("Enter Username");
                        string name = Console.ReadLine();
                        User sel1 = users.Find(x => x.UserName == name);

                        if (sel1 != null)
                        {
                            opt.changePassword(users, sel1);

                        }

                    }
                    else if (n == 2)
                    {
                        opt.userpro(users);

                    }
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }





            Console.ReadLine();
        }
    }
//---------------------------------------------------------------------------------------------------------------------------

    //************************User.cs*************************

    using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
    {
        public class User
        {
            private string _uname;

            public string UserName
            {
                get { return _uname; }
                set { _uname = value; }
            }
            private string _pwd;

            public string Password
            {
                get { return _pwd; }
                set { _pwd = value; }
            }
            private int _phno;

            public int PhoneNumber
            {
                get { return _phno; }
                set { _phno = value; }
            }
            public DateTime Date { get; set; }
            public int moviesBorrowed = 0;
            List<Movie> borrowedmovies = new List<Movie>();
            public enum Userlvl
            {
                Silver = 2,
                Gold = 3,
                Platinum = 5

            }
            private int _userlvl;

            public int UserLevel
            {
                get { return _userlvl; }
                set { _userlvl = value; }
            }
            public User()
            {

            }
            public User(string UserName, string Password, DateTime d, string UserLevel1)
            {
                if (UserLevel1 == "Silver")
                {
                    this.UserLevel = (int)Userlvl.Silver;
                }
                if (UserLevel1 == "Gold")
                {
                    this.UserLevel = (int)Userlvl.Gold;
                }
                if (UserLevel1 == "Platinum")
                {
                    this.UserLevel = (int)Userlvl.Platinum;
                }
                this.UserName = UserName;
                this.Password = Password;
                this.Date = d;
            }

            public void BorrowMovie(List<Movie> list)
            {
                Console.WriteLine("The movies available for you are");
                foreach (Movie items in list)
                {
                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.WriteLine(items.Price + " ");

                    Console.WriteLine();
                }
                for (int i = 0; i < this.UserLevel; i++)
                {
                    Console.WriteLine("Enter the movie name you want to borrow");
                    string brw = Console.ReadLine();
                    Console.WriteLine("Enter how many days do you want for the Rent");
                    int days = int.Parse(Console.ReadLine());
                    Movie search = list.Find(x => x.MovieName == brw);

                    if (search != null)
                    {

                        this.moviesBorrowed++;
                        borrowedmovies.Add(search);
                        list.Remove(search);
                        search.Stock--;
                        double totalCost = days * (0.10 * search.Price) * (0.18 * search.Price);
                        Console.WriteLine($"You Need to Pay {totalCost}");
                        Console.WriteLine("This movie is added to your list");

                    }
                    else
                    {
                        Console.WriteLine("This Movie isn't Availabale");
                    }
                }
                Console.WriteLine("Movies in your list");
                foreach (var item in borrowedmovies)
                {
                    Console.WriteLine(item.MovieName);
                    Console.WriteLine(item.Language);
                    Console.WriteLine(item.Genre);
                }

            }
            public void ReturnMovie(List<Movie> list)
            {
                Console.WriteLine("Movies in your list");
                foreach (var item in borrowedmovies)
                {
                    Console.WriteLine(item.MovieName);
                    Console.WriteLine(item.Language);
                    Console.WriteLine(item.Genre);
                    Console.WriteLine();
                }
                Console.WriteLine("Enter Movie Name you want to return");
                string ret = Console.ReadLine();
                Console.WriteLine("Enter how many days you rented the movie");
                int days = int.Parse(Console.ReadLine());
                Movie returnmov = list.Find(x => x.MovieName == ret);

                if (this.borrowedmovies.Contains(returnmov))
                {

                    returnmov.Stock++;
                    this.moviesBorrowed--;
                    borrowedmovies.Remove(returnmov);
                    Console.WriteLine("Movie Returned Successfully");

                }
                else
                {
                    Console.WriteLine("You didn't Borrow this movie..");
                }

            }
            public void ShowMyList()
            {
                foreach (var item in this.borrowedmovies)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}");
                    Console.WriteLine($"Language   : {item.Language}");
                    Console.WriteLine($"Genere     : {item.Genre}");
                    Console.WriteLine();
                }
            }
        }
    }


    //***********************************Movie.cs*******************

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
    {
        public class Movie
        {
            private string _mname;

            public string MovieName
            {
                get { return _mname; }
                set { _mname = value; }
            }
            private string _genre;

            public string Genre
            {
                get { return _genre; }
                set { _genre = value; }
            }
            private string _lang;

            public string Language
            {
                get { return _lang; }
                set { _lang = value; }
            }
            private double _price;

            public double Price
            {
                get { return _price; }
                set { _price = value; }
            }
            private int _available;

            public int Stock
            {
                get { return _available; }
                set { _available = value; }
            }



            public void Searchbylanguage(List<Movie> list)
            {
                Console.WriteLine("These language movies are available Hindi,English,Tamil,Telugu,Kanada");
                Console.WriteLine("Enter languae to search Movie");
                string lang = Console.ReadLine();
                List<Movie> search = list.FindAll(x => x.Language == lang);
                if (search != null)
                {
                    for (int i = 0; i < search.Count; i++)
                    {
                        Console.WriteLine("Movie    : " + search[i].MovieName);
                        Console.WriteLine("Genre    : " + search[i].Genre);
                        Console.WriteLine("Language : " + search[i].Language);
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("This language is not available");
                }
            }
            public void SearchByGenre(List<Movie> list)
            {
                Console.WriteLine("These Genres are available..Action.Comedy,Drama,Romance,Thriller,Adventure");
                Console.WriteLine("Enter Genre to search Movie");
                string genre = Console.ReadLine();
                List<Movie> search1 = list.FindAll(x => x.Genre == genre);
                if (search1 != null)
                {
                    foreach (Movie item in search1)
                    {
                        Console.WriteLine("Movie    : " + item.MovieName);
                        Console.WriteLine("Genre    : " + item.Genre);
                        Console.WriteLine("Language : " + item.Language);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("This genre is not available");
                }
            }
        }
    }

    //***********************************Coption.cs********************

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModule;
using AdminModule;

namespace CommonOptions
    {
        public class Coption
        {
            public void changePassword(List<User> userlist, User user1)
            {
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();
                User user = userlist.Find(x => user1.Password == pass);
                if (user != null)
                {
                    DateTime Date = user1.Date;
                    DateTime now = DateTime.Now;
                    if ((now.Month - Date.Month) >= 1)
                    {
                        Console.WriteLine("Enter New Password");
                        user1.Password = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("After changing Password");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(user1.UserName);
                        Console.WriteLine(user1.Password);
                        Console.WriteLine(user1.PhoneNumber);
                    }
                    else
                    {
                        Console.WriteLine("Thank you!!");

                    }


                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            public void userpro(List<User> userslist)
            {
                Console.WriteLine("Enter UserName");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();
                User sel1 = userslist.Find(x => x.UserName == name);

                if (sel1 != null)
                {
                    User sel2 = userslist.Find(x => sel1.Password == pass);
                    if (sel2 != null)
                    {
                        Console.WriteLine("UserName : " + sel1.UserName);
                        Console.WriteLine("Password: " + sel1.Password);
                        Console.WriteLine("Phone number: " + sel1.PhoneNumber);
                        Console.WriteLine("Added date : " + sel1.Date);
                        Console.WriteLine();
                        Console.WriteLine("Do you want to Update Details\n Yes or No");
                        string op = Console.ReadLine();
                        if (op == "Yes")
                        {
                            Console.WriteLine("Enter the Updated UserName");
                            sel1.UserName = Console.ReadLine();
                            Console.WriteLine("Enter the Updated Password");
                            sel1.Password = Console.ReadLine();
                            Console.WriteLine("Enter the Updated PhoneNumber");
                            sel1.PhoneNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Updated Details are as follows");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("UserName : " + sel1.UserName);
                            Console.WriteLine("Password: " + sel1.Password);
                            Console.WriteLine("Phone number: " + sel1.PhoneNumber);
                            Console.WriteLine("Added date : " + sel1.Date);
                            Console.WriteLine();

                        }
                        else if (op == "No")
                        {


                            Console.WriteLine("ThankYou");
                        }



                    }
                    else
                    {
                        Console.WriteLine("Incorrect Password");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid UserName");
                }
            }
        }
    }
