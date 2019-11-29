using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API1.Models;

namespace API1.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private static List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        [HttpPost]
        [Route("CadastrarUsuario")]
        public string CadastrarUsuario(UsuarioModel usuario)
        {
            listaUsuarios.Add(usuario);
            return "Usuário cadastrado com sucesso!";
        }

        [HttpPut]
        [Route("AlterarUsuario")]
        public string AlterarUsuario(UsuarioModel usuario)
        {
            listaUsuarios
                .Where(x => x.Codigo == usuario.Codigo)
                .Select(x =>
                    {
                        x.Codigo = usuario.Codigo;
                        x.Nome = usuario.Nome;
                        x.Login = usuario.Login;

                        return x;
                    }).ToList();

            return "Usuário alterado com sucesso!";
        }

        [HttpDelete]
        [Route("ExcluirUsuario/{codigo}")]
        public string ExcluirUsuario(int codigo)
        {
            UsuarioModel usuario = listaUsuarios.Where(x => x.Codigo == codigo)
                                                .Select(x => x)
                                                .First();
            listaUsuarios.Remove(usuario);

            return "Registro excluído com sucesso!";
        }

        [HttpGet]
        [Route("ConsultarUsuarios")]
        public List<UsuarioModel> ConsultarUsuarios()
        {
            return listaUsuarios;
        }

    }
}
