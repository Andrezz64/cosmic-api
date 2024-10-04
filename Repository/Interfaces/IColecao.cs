using cosmic_api.Models;

namespace cosmic_api.Repository.interfaces;

public interface IColecao
{
    public void CreateOne(Coleco colecao);
    public List<Coleco> GetAll();
    public Coleco GetOne(Coleco colecao);
    public void ChangeOne(Coleco colecao);
    public void DeleteOne(Coleco colecao);
}