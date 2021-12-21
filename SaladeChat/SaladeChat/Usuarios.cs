using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladeChat
{
    public  abstract class Usuarios
    {
        protected IMediator Mediator;
        protected string NombredeUsuario = String.Empty;

        public Usuarios(IMediator mediator, string nombredeusuario)
        {
            Mediator = mediator;
            NombredeUsuario = nombredeusuario;
        }

        public abstract void EnviarMensaje(string mensaje);
        public abstract void RecibirMensaje(string mensaje);

        public string Obtenernombredeusuario() => NombredeUsuario;



    }
}
