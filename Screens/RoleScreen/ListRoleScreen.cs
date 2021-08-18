using System;
using Blog.Models;
using Blog.Repository;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.RoleScreen
{
    public class ListRoleScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista de Perfis");
            System.Console.WriteLine("---------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }
        public static void List()
        {
            var repository = new Repository<Role>(Database.connection);
            var roles = repository.Get();

            foreach (var item in roles)
            {
                System.Console.WriteLine($"{item.Id} - {item.Name} , {item.Slug}");
            }
        }
    }
}