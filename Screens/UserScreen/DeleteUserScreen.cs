using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreen
{
    public class DeleteUserScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Adicionar um usuario: ");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Nome: ");
            System.Console.WriteLine("Digite o id do usuario que sera excluido");
            var id = int.Parse(Console.ReadLine());

            Delete(id);
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.connection);
                repository.Delete(id);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nao foi possivel excluir o usuario!");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}

