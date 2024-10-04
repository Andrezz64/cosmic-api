using cosmic_api.Models;
using cosmic_api.Repository.interfaces;

namespace cosmic_api.Repository.Classes;
public class RoleRepository(CosmicContext context) : IRole
{
    private CosmicContext _context = context;

    public void ChangeOne(Role role)
    {
       _context.Roles.Update(role);
       _context.SaveChanges();
    }

    public void CreateOne(Role role)
    {
       _context.Roles.Add(role);
       _context.SaveChanges();
    }

    public void DeleteOne(Role role)
    {
       _context.Roles.Remove(role);
       _context.SaveChanges();
    }

    public List<Role> GetAll() => [.. _context.Roles];

    public Role GetOne(Role role) => _context.Roles.FirstOrDefault(role);
}