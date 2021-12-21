using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladeChat
{
    public interface IMediator
    {
        //Propiedades de la clase Interfaz IMediator
         string NombredelGrupo();
         void RegistrodeUsuarios(Usuarios usuarios);
         void EnviarMensaje(Usuarios usuarios, string mensaje);
         void AnularRegistrodeUsuario(Usuarios usuarios);

    }
}
