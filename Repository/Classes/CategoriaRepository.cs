using cosmic_api.Models;
using cosmic_api.Repository.interfaces;

namespace cosmic_api.Repository.Classes;
public class CategoriaRepository(CosmicContext context) : ICategoria
{
    private CosmicContext _context = context;

    public void ChangeOne(Categoria categoria)
    {
       _context.Categorias.Update(categoria);
       _context.SaveChanges();
    }

    public void CreateOne(Categoria categoria)
    {
       _context.Categorias.Add(categoria);
       _context.SaveChanges();
    }

    public void DeleteOne(Categoria categoria)
    {
       _context.Categorias.Remove(categoria);
       _context.SaveChanges();
    }

    public List<Categoria> GetAll() => [.. _context.Categorias];

    public Categoria GetOne(Categoria categoria) => _context.Categorias.FirstOrDefault(categoria);
}