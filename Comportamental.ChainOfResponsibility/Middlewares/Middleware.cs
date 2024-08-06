using System;

namespace Comportamental.ChainOfResponsibility.Middlewares
{
    public abstract class Middleware
    {
        private Middleware _next;

        public Middleware LinkWith(Middleware next)
        {
            _next = next;

            return next;
        }

        public abstract bool Check(string email, string password);

        protected bool CheckNext(string email, string password)
        {
            return _next == null? true : _next.Check(email, password);
        }
    }
}
