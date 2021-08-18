using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.RoleScreen
{
    public class UpdateRoleScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Atualizar Perfil");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            System.Console.WriteLine("Slug");
            var slug = Console.ReadLine();

            Update(new Role { Id = id, Name = name, Slug = slug });
            Console.ReadKey();
            MenuRoleScreen.Load();

        }
        public static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.connection);
                repository.Update(role);
                System.Console.WriteLine("Perfil atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nao foi possivel atualizar o perfil");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
