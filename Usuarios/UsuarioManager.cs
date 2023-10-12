using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;

namespace UsuarioManager { 

    public  class Usuariomanager
    {
        public int ObtenerCantidadUsuarios(IDatosUsuarios datos)
        {
            var usuarios = datos.Obtener();
            return usuarios.Count();
        }

    }

}
