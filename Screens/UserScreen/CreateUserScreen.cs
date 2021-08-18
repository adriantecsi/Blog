using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreen
{
    public class CreateUserScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Adicionar um usuario: ");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            System.Console.WriteLine("Senha: ");
            var password = Console.ReadLine();
            System.Console.WriteLine("Bio: ");
            var bio = Console.ReadLine();
            System.Console.WriteLine("Imagem: ");
            var image = Console.ReadLine();
            System.Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new User { Name = name, Email = email, PasswordHash = password, Bio = bio, Image = image, Slug = slug });
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.connection);
                repository.Create(user);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nao foi possivel cadastrar um usuario!");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}
