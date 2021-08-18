using System;

namespace Blog.Screens.TagScreens
{
    public static class MenuTagScreen
    {

        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Gestao de Tags");
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("O que deseja fazer? ");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar as Tags");
            System.Console.WriteLine("2 - Cadastrar as Tags");
            System.Console.WriteLine("3 - Atualizar as Tags");
            System.Console.WriteLine("4 - Deletar as Tags");
            System.Console.WriteLine("5 - Voltar ao menu principal");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListTagsScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagsScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
