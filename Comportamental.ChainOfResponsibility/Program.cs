using Comportamental.ChainOfResponsibility.Middlewares;
using Comportamental.ChainOfResponsibility.Servers;
using System;

namespace Comportamental.ChainOfResponsibility
{
    public class Program
    {
        private static Server _server;

        static bool Init()
        {
            _server = new Server();

            _server.RegisterUser("master@teste.com.br", "adm123");
            _server.RegisterUser("user@hcode.com.br", "123456");


            Console.WriteLine("Digite o seu e-mail:");

            string email = Console.ReadLine();

            Console.WriteLine("Digite a sua senha:");

            string password = Console.ReadLine();

            var middleware = new CheckUserMiddleware(_server);

            middleware.LinkWith(new CheckPermissionMiddleware());

            _server.SetMiddleware(middleware);

            return _server.LogIn(email, password);
        }

        static bool RegisterUser()
        {
            _server = new Server();

            var middleware = new CheckPasswordMidlleware();

            middleware.LinkWith(new CheckUserMiddleware(_server));
            middleware.LinkWith(new CheckPermissionMiddleware());


            Console.WriteLine("Digite o seu e-mail:");

            string email = Console.ReadLine();

            Console.WriteLine("Digite a sua senha:");

            string password = Console.ReadLine();

            _server.SetMiddleware(middleware);

            _server.RegisterUser(email, password);

            return _server.LogInRegister(email, password);
        }

        static void Main(string[] args)
        {

            var done = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 para cadastrar\n2 para realizar login");
                var decision = Console.ReadLine();

                switch (decision)
                {
                    case "1":
                        done = RegisterUser();
                        break;
                    case "2":
                        done = Init();
                        break;
                    default:
                        Console.WriteLine("Erro: Só é possivel informar '1' ou '2'.");
                    break;
                }
            } while (!done);

            Console.ReadLine();

        }
    }
}
