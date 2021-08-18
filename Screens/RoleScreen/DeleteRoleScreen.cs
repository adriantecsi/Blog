using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.RoleScreen
{
    public class DeleteRoleScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Deletar Perfil");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());


            Delete(id);
            Console.ReadKey();
            MenuRoleScreen.Load();

        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.connection);
                repository.Delete(id);
                System.Console.WriteLine("Perfil excluido com sucesso!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nao foi possivel atualizar o perfil");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}