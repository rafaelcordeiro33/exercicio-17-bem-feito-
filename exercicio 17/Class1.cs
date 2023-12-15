using System;
using System.Collections.Generic;

namespace exercicio_17
{
    internal class Class1
    {
        public static string nome;
        public static string email;
        public static string password;
        public static List<Registro> Registros = new List<Registro>();

        public static void AdicionarRegistro(string nome, string email, string password)
        {
            Registros.Add(new Registro(nome, email, password));
        }
    }

    public class Registro
    {
        public string Nome { get; }
        public string Email { get; }
        public string Password { get; }

        public Registro(string nome, string email, string password)
        {
            Nome = nome;
            Email = email;
            Password = password;
        }
    }
}

