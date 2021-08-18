using System;


namespace Blog.Screens.UserScreen
{
    public class MenuUserScreen
    {

        public static void Load()
        {

            Console.Clear();
            System.Console.WriteLine("Gestao do usuario:");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("1 - Listar usuario: ");
            System.Console.WriteLine("2 - Criar usuario: ");
            System.Console.WriteLine("3 - Atualizar usuario: ");
            System.Console.WriteLine("4 - Deletar usuario:");
            System.Console.WriteLine("5 - Voltar ao menu principal: ");
            System.Console.WriteLine();
            System.Console.WriteLine();

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;

                default: Load(); break;
            }


        }
    }
}