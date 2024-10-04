using cosmic_api.Models;

namespace cosmic_api.Repository.interfaces;

public interface IRole
{
    public void CreateOne(Role role);
    public List<Role> GetAll();
    public Role GetOne(Role role);
    public void ChangeOne(Role role);
    public void DeleteOne(Role role);
}