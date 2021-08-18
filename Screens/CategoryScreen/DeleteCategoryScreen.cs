using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreen
{

    public class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Exclusao de Categoria");
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());


            Delete(id);
            Console.ReadKey();

        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.connection);
                repository.Delete(id);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nao foi possivel criar uma categoria!");
                System.Console.WriteLine(ex.Message);

            }
        }
    }
}