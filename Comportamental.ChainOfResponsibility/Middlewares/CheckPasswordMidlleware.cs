using System;
using Comportamental.ChainOfResponsibility.Servers;

namespace Comportamental.ChainOfResponsibility.Middlewares
{
    public class CheckPasswordMidlleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Contains("123"))
            {
                Console.WriteLine("Senha fraca, por favor, não insira a sequência 123");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
