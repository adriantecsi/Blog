using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma Tag");
            Console.WriteLine("--------------");
            System.Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();
            Update(new Tag { Id = id, Name = name, Slug = slug });
            Console.ReadKey();
            MenuTagScreen.Load();

        }
        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.connection);
                repository.Update(tag);
                System.Console.WriteLine("Tag atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }




        }
    }
}

