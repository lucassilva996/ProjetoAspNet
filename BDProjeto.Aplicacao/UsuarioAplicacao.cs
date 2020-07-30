using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDProjeto.Dominio;
using BDProjeto.Dominio.Contrato;
using BDProjeto.Repositorio;
using BDProjeto.RepositorioADO;

namespace BDProjeto.Aplicacao
{
    public class UsuarioAplicacao
    {

        private readonly IRepositorio<Usuarios> repositorio;

        public UsuarioAplicacao(IRepositorio<Usuarios>repo)
        {
            repositorio = repo;
        }

        public void Salvar(Usuarios usuarios)
        {
            repositorio.Salvar(usuarios);
        }

        public void Excluir(Usuarios usuario)
        {

            repositorio.Excluir(usuario);
        }

        public IEnumerable<Usuarios>ListarTodos()
        {
            return repositorio.ListarTodos();

        }

        public Usuarios ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);

        }
    }
}
