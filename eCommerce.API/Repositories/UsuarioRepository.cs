using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        // db em memória
        public static List<Usuario> _db = new List<Usuario>();



        public List<Usuario> Get()
        {
            return _db;
        }

        public Usuario Get(int id)
        {
            return _db.Find(x => x.Id == id)!;
        }
        public void Add(Usuario usuario)
        {
            _db.Add(usuario);
        }
        public void Update(Usuario usuario)
        {
            // no nosso caso vamos deletar o que está no banco e jogar um novo
            _db.Remove(Get(usuario.Id)); // usando com o método get ali em cima
            _db.Add(usuario);
        }

        public void Delete(int id)
        {
            _db.Remove(Get(id));
        }


    }
}
