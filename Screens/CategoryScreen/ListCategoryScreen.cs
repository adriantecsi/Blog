using System;
using Blog.Models;
using Blog.Repository;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.CategoryScreen
{

    public class ListCategoryScreen
    {
        public static void Load()
        {

            Console.Clear();
            System.Console.WriteLine("Lista de Categoria");
            System.Console.WriteLine("------------------");
            List();
            Console.ReadKey();
        }
        public static void List()
        {
            var repository = new Repository<Category>(Database.connection);
            var lists = repository.Get();

            foreach (var item in lists)
            {

                System.Console.WriteLine($"{item.Id} - {item.Name} , {item.Slug} ");
            }

        }
    }
}