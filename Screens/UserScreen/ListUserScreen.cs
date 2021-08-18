using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreen
{
    public class ListUserScreen
    {

        public static void Load()
        {
            Console.Clear();
            List();
            Console.ReadKey();
            MenuUserScreen.Load();

        }
        public static void List()
        {
            var repository = new Repository<User>(Database.connection);
            var users = repository.Get();

            foreach (var item in users)
            {
                System.Console.WriteLine($"{item.Id} -  {item.Name} , {item.Email}, {item.PasswordHash}, {item.Bio} ,{item.Image},{item.Slug}");
            }
        }
    }
}
