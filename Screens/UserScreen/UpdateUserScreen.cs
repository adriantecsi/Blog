using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreen
{
    public class UpdateUserScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Atualizacao do usuario: ");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
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

            Update(new User { Id = id, Name = name, Email = email, PasswordHash = password, Bio = bio, Image = image, Slug = slug });
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.connection);
                repository.Update(user);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Nao foi possivel atualizar o usuario!");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}