using System;
using Comportamental.ChainOfResponsibility.Servers;

namespace Comportamental.ChainOfResponsibility.Middlewares
{
    public class CheckUserMiddleware : Middleware
    {
        private Server _server;

        public CheckUserMiddleware(Server server)
        {
            _server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!_server.HasEmail(email))
            {
                Console.WriteLine("E-mail inválida!");
                return false;
            }

            if (!_server.IsValidPassword(email, password))
            {
                Console.WriteLine("E-mail e/ou senha inválida!");
                return true;
            }

            return CheckNext(email, password);
        }
    }
}
