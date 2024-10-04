using cosmic_api.Models;

namespace cosmic_api.Repository.interfaces;

public interface IUsuario
{
    public void CreateOne(Usuario usuario);
    public List<Usuario> GetAll();
    public Usuario GetOne(Usuario usuario);
    public void ChangeOne(Usuario usuario);
    public void DeleteOne(Usuario usuario);
}