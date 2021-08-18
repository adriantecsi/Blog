using System;
using Blog.Screens.CategoryScreen;
using Blog.Screens.RoleScreen;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreen;
using Microsoft.Data.SqlClient;

namespace Blog
{


    class Program
    {


        private const string connection_string = "Server = localhost, 1433 ; Database = Blog; User ID = sa; Password = Urahara13@@";
        static void Main(string[] args)
        {
            Database.connection = new SqlConnection(connection_string);

            Database.connection.Open();

            Load();
            Console.ReadKey();
            Database.connection.Close();


        }
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}











