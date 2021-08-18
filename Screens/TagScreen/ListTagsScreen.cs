using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
    public static class ListTagsScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista de Tags");
            System.Console.WriteLine("---------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();

        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.connection);
            var tags = repository.Get();

            foreach (var item in tags)
            {
                System.Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
            }
        }
    }
}

