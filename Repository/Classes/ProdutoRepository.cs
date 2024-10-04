using cosmic_api.Models;
using cosmic_api.Repository.interfaces;

namespace cosmic_api.Repository.Classes;

public class ProdutoRepository : IProduto
{
    private readonly CosmicContext _dbcontext;
    public ProdutoRepository(CosmicContext cosmicContext)
    {
        _dbcontext = cosmicContext;
    }

    public void ChangeOne(Produto produto)
    {
        _dbcontext.Produtos.Add(produto);
        _dbcontext.SaveChanges();
    }

    public void CreateOne(Produto produto)
    {
        _dbcontext.Produtos.Add(produto);
        _dbcontext.SaveChanges();
    }

    public void DeleteOne(Produto produto)
    {
        _dbcontext.Produtos.Remove(produto);
        _dbcontext.SaveChanges();
    }

    public List<Produto> GetAll() => [.. _dbcontext.Produtos];

    public Produto GetOne(Produto produto) => _dbcontext.Produtos.FirstOrDefault(produto);
}