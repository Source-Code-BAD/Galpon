using System;
using Galpon.App.Dominio;
using Galpon.App.Persistencia;

namespace Galpon.App.Consola
{
    class Program
    {
        private static IRepositoryUser _repoUser = new RepositoryUser(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Framework!");
            AddUser();
            // DeleteUser(1);
        }

        private static void AddUser()
        {
            var user = new User
            {
                user = "nicolay",
                pass = "1234",
                created_date = DateTime.Now,
                updated_date = DateTime.Now,
            };
            _repoUser.AddUser(user);
        }

        private static void SearchUser(int idUser) {
            var user = _repoUser.GetUser(idUser);
            Console.WriteLine(user.user + " " + user.pass);
        }

            private static void DeleteUser(int idUser) {
            _repoUser.DeleteUser(idUser);
            Console.WriteLine("si borro ");
        }
    }
}
