using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDProjeto.Aplicacao;
using BDProjeto.Dominio;
using BDProjeto.Repositorio;

namespace DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            var bd = new bd();
            var app = new UsuarioAplicacao();
            var usuarioAplicacao = new UsuarioAplicacao();
            SqlConnection conexao = new SqlConnection(@"data source=DESKTOP-4MN6G5L; Integrated Security=SSPI; Initial Catalog=ExemploBD");
            conexao.Open();

            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o cargo do usuário: ");
            string cargo = Console.ReadLine();

            Console.Write("Digite a data de cadastro do usuário: ");
            string data = Console.ReadLine();
            
            var usuarios = new Usuarios
            {
                Nome = nome,
                Cargo = cargo,
                Data = DateTime.Parse(data)
            };

           //usuarios.Id = 6;

           app.Salvar(usuarios);
         

            var dados = new UsuarioAplicacao().ListarTodos();

            foreach(var usuario in dados)
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Cargo:{2}, Data:{3}", usuario.Id, usuario.Nome, usuario.Cargo, usuario.Data);
            }
        }
    }
}
