using cosmic_api.Models;

namespace cosmic_api.Repository.interfaces;

public interface IVenda
{
    public void CreateOne(Venda venda);
    public List<Venda> GetAll();
    public Venda GetOne(Venda venda);
    public void ChangeOne(Venda venda);
    public void DeleteOne(Venda venda);
}