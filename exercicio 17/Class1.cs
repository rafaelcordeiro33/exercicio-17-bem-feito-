using System;
using System.Collections.Generic;

namespace exercicio_17
{
    internal class Class1
    {
        public static string nome;
        public static string email;
        public static string password;
        public static List<(string Nome, string Email, string Password)> Registros = new List<(string, string, string)>();

        public static void AdicionarRegistro(string nome, string email, string password)
        {
            Registros.Add((nome, email, password));
        }
    }
}
