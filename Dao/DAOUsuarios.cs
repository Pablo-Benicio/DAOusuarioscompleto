


namespace Dao
{
    public interface IDatosUsuarios
    {
        public IEnumerable<Usuario> Obtener();
           
    }
    public class Usuario
    {
        public int id { get; set; }
        public string? nombre { get; set; }
        public int edad { get; set; }
    }
    public class DAOUsuarios:IDatosUsuarios
    {
        public IEnumerable<Usuario> Obtener()
        {
           var resultado = new List<Usuario>();
            resultado.Add(new Usuario {id = 1,nombre ="upa",edad=40 });
            resultado.Add(new Usuario { id = 2, nombre = "dimaria", edad = 35 });
            resultado.Add(new Usuario { id = 3, nombre = "dibala", edad = 25 });
            return resultado;
        }
        public Usuario Obtener(int id) { throw new NotImplementedException();}

        public bool Insertar(Usuario usuario) { throw new NotImplementedException(); }

        public bool Eliminar(Usuario usuario) { throw new NotImplementedException(); }
    }
}