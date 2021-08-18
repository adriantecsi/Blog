using System;

namespace Blog.Screens.CategoryScreen
{

    public class MenuCategoryScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Menu Categoria");
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("1 - Listar Categoria: ");
            System.Console.WriteLine("2 - Criar uma Categoria: ");
            System.Console.WriteLine("3 - Atualizar uma Categoria: ");
            System.Console.WriteLine("4 - Deleter uma Categoria: ");
            System.Console.WriteLine("5 - Voltar ao menu principal: ");
            var option = short.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;

                default: Load(); break;
            }


        }

    }
}