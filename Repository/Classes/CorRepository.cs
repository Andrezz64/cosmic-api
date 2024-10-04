using cosmic_api.Models;
using cosmic_api.Repository.interfaces;

namespace cosmic_api.Repository.Classes;
public class CorRepository(CosmicContext context) : ICor
{
    private CosmicContext _context = context;

    public void ChangeOne(Core cor)
    {
       _context.Cores.Update(cor);
       _context.SaveChanges();
    }

    public void CreateOne(Core cor)
    {
       _context.Cores.Add(cor);
       _context.SaveChanges();
    }

    public void DeleteOne(Core cor)
    {
       _context.Cores.Remove(cor);
       _context.SaveChanges();
    }

    public List<Core> GetAll() => [.. _context.Cores];

    public Core GetOne(Core cor) => _context.Cores.FirstOrDefault(cor);
}