using cosmic_api.Models;
using cosmic_api.Repository.interfaces;

namespace cosmic_api.Repository.Classes;
public class ColecaoRepository(CosmicContext context) : IColecao
{
    private CosmicContext _context = context;

    public void ChangeOne(Coleco colecao)
    {
       _context.Colecoes.Update(colecao);
       _context.SaveChanges();
    }

    public void CreateOne(Coleco colecao)
    {
       _context.Colecoes.Add(colecao);
       _context.SaveChanges();
    }

    public void DeleteOne(Coleco colecao)
    {
       _context.Colecoes.Remove(colecao);
       _context.SaveChanges();
    }

    public List<Coleco> GetAll() => [.. _context.Colecoes];

    public Coleco GetOne(Coleco colecao) => _context.Colecoes.FirstOrDefault(colecao);
}