using System;

namespace Blog.Screens.RoleScreen
{
    public class MenuRoleScreen
    {

        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Gerenciamento de perfis");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("1 - Lista de perfis");
            System.Console.WriteLine("2 - Criar um perfil");
            System.Console.WriteLine("3 - Atualizar um perfil");
            System.Console.WriteLine("4 - Deletar um perfil");
            System.Console.WriteLine("5 - Voltar ao menu principal");
            var option = short.Parse(Console.ReadLine());



            switch (option)
            {
                case 1:
                    ListRoleScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }


    }
}