using System;
using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
    public static class DeleteTagsScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma Tag");
            Console.WriteLine("--------------");
            System.Console.WriteLine("Qual o id da Tag que deseja excluir? ");
            var id = int.Parse(Console.ReadLine());
            Delete(id);
            Console.ReadKey();
            MenuTagScreen.Load();

        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.connection);
                repository.Delete(id);
                System.Console.WriteLine("Tag deletada com sucesso!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
