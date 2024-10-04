using cosmic_api.Models;

namespace cosmic_api.Repository.interfaces;
public interface IProduto
{
    public void CreateOne(Produto produto);
    public List<Produto> GetAll();
    public Produto GetOne(Produto produto);
    public void ChangeOne(Produto produto);
    public void DeleteOne(Produto produto);
}