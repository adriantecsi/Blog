using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
    public static class CreateTagScreen

    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Tag");
            Console.WriteLine("--------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();
            Create(new Tag { Name = name, Slug = slug });
            Console.ReadKey();
            MenuTagScreen.Load();


        }
        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.connection);
                repository.Create(tag);
                System.Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }




        }
    }
}
