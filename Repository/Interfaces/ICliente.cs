using cosmic_api.Models;

namespace cosmic_api.Repository.interfaces;
public interface ICliente
{
    public void CreateOne(Cliente cliente);
    public List<Cliente> GetAll();
    public Cliente GetOne(Cliente cliente);
    public void ChangeOne(Cliente cliente);
    public void DeleteOne(Cliente cliente);
    public bool Autorizar(string email,string senha);
}