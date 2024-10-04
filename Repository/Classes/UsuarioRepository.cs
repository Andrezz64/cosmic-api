using cosmic_api.Models;
using cosmic_api.Repository.interfaces;

namespace cosmic_api.Repository.Classes;
public class UsuarioRepository(CosmicContext context) : IUsuario
{
    private CosmicContext _context = context;

    public void ChangeOne(Usuario usuario)
    {
       _context.Usuarios.Update(usuario);
       _context.SaveChanges();
    }

    public void CreateOne(Usuario usuario)
    {
       _context.Usuarios.Add(usuario);
       _context.SaveChanges();
    }

    public void DeleteOne(Usuario usuario)
    {
       _context.Usuarios.Remove(usuario);
       _context.SaveChanges();
    }

    public List<Usuario> GetAll() => [.. _context.Usuarios];

    public Usuario GetOne(Usuario usuario) => _context.Usuarios.FirstOrDefault(usuario);
}