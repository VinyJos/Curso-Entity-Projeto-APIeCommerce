using eCommerce.API.Database;
using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly eCommerceContext _db;
        public UsuarioRepository(eCommerceContext db)
        {
            _db = db;
        }


        public List<Usuario> Get()
        {
            // Ordena a tabela e converte para lista
            return _db.Usuarios.OrderBy(a => a.Id).ToList();
        }

        public Usuario Get(int id)
        {
            return _db.Usuarios.Find(id)!;
        }
        public void Add(Usuario usuario)
        {
            // Unit of works
            // fica em memória
            _db.Usuarios.Add(usuario);
            // salvar no banco
            _db.SaveChanges();
        }
        public void Update(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Usuarios.Remove(Get(id));
            _db.SaveChanges();
        }


    }
}
