using Comportamental.ChainOfResponsibility.Middlewares;
using System;
using System.Collections.Generic;

namespace Comportamental.ChainOfResponsibility.Servers
{
    public class Server
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        private Middleware _middleware;

        public void SetMiddleware(Middleware middleware)
        {
            _middleware = middleware;
        }

        public bool LogIn(string email, string password)
        {
            if (_middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso!"); ;
                Console.WriteLine("Seja bem-vindo!");
                return true;
            }

            return false;
        }

        public bool LogInRegister(string email, string password)
        {
            return _middleware.Check(email, password);
        }
        public void RegisterUser(string email, string password)
        {
            _users[email] = password;
        }



        public bool HasEmail(string email)
        {
            return _users.ContainsKey(email);
        }

        public bool IsValidPassword(string email, string password)
        {
            string value = "";

            _users.TryGetValue(email, out value);

            return password == value;
        }
    }
}
