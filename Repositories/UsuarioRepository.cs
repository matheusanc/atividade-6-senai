using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System.Linq;

namespace Exo.WebApi.Repositories
{
    public class UsuarioRepository
    {
        private readonly ExoContext _context;

        public UsuarioRepository(ExoContext context)
        {
            _context = context;
        }

        public Usuario Login(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
        
        // ... demais métodos (Listar, Cadastrar, BuscaPorId, Atualizar, Deletar)
    }
}
