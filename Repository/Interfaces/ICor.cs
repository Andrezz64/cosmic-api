using cosmic_api.Models;

namespace cosmic_api.Repository.interfaces;

public interface ICor
{
    public void CreateOne(Core cor);
    public List<Core> GetAll();
    public Core GetOne(Core cor);
    public void ChangeOne(Core cor);
    public void DeleteOne(Core cor);
}