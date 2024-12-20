using cosmic_api.Models;
using cosmic_api.Repository.interfaces;

namespace cosmic_api.Repository.Classes;

public class ClienteRepository(CosmicContext context) : ICliente
{
    private readonly CosmicContext _context = context;
    public void ChangeOne(Cliente cliente)
    {
       _context.Clientes.Update(cliente);
       _context.SaveChanges();
    }

    public void CreateOne(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
    }

    public void DeleteOne(Cliente cliente)
    {
       _context.Remove(cliente);
       _context.SaveChanges();
    }

    public List<Cliente> GetAll() => [.. _context.Clientes];

    public Cliente GetOne(Cliente cliente) => _context.Clientes.FirstOrDefault(cliente);

    public bool Autorizar(string email,string senha){
        Cliente cliente =_context.Clientes.Where(c => c.Emaill == email).FirstOrDefault() ?? throw new ArgumentNullException(email);
        if(cliente.Senha == senha){
            return true;
        }
        return false;
    }
}