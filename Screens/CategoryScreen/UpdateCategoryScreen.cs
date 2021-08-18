using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreen
{

    public class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Criaçao de Categoria");
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            System.Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category { Id = id, Name = name, Slug = slug });
            Console.ReadKey();

        }
        public static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.connection);
                repository.Update(category);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nao foi possivel criar uma categoria!");
                System.Console.WriteLine(ex.Message);

            }
        }
    }
}