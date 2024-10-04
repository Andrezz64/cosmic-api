using cosmic_api.Models;

namespace cosmic_api.Repository.interfaces;

public interface ICategoria
{
    public void CreateOne(Categoria categoria);
    public List<Categoria> GetAll();
    public Categoria GetOne(Categoria categoria);
    public void ChangeOne(Categoria categoria);
    public void DeleteOne(Categoria categoria);
}