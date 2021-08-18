using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.RoleScreen
{
    public class CreateRoleScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Criar Perfil");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            System.Console.WriteLine("Slug");
            var slug = Console.ReadLine();

            Create(new Role { Name = name, Slug = slug });
            Console.ReadKey();
            MenuRoleScreen.Load();

        }
        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.connection);
                repository.Create(role);
                System.Console.WriteLine("Perfil criado com sucesso!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nao foi possivel atualizar o perfil");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
