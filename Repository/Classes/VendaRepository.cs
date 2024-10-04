using cosmic_api.Models;
using cosmic_api.Repository.interfaces;

namespace cosmic_api.Repository.Classes;
public class VendaRepository(CosmicContext context) : IVenda
{
    private CosmicContext _context = context;

    public void ChangeOne(Venda venda)
    {
       _context.Vendas.Update(venda);
       _context.SaveChanges();
    }

    public void CreateOne(Venda venda)
    {
       _context.Vendas.Add(venda);
       _context.SaveChanges();
    }

    public void DeleteOne(Venda venda)
    {
       _context.Vendas.Remove(venda);
       _context.SaveChanges();
    }

    public List<Venda> GetAll() => [.. _context.Vendas];

    public Venda GetOne(Venda venda) => _context.Vendas.FirstOrDefault(venda);
}