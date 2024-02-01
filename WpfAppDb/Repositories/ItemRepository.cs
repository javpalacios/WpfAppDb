using Microsoft.EntityFrameworkCore;
using WpfAppDb.Models;
using WpfAppDb.Data;
using WpfAppDb.Models;

namespace WpfEmployees.Repositories;

public class ItemRepository(AppDbContext context) : IRepository<Item>
{
    private readonly AppDbContext _context = context;

    public List<Item> GetAll() => _context.Items.ToList();

    public void Update(Item item)
    {
        _context.Entry(item).State = EntityState.Modified;
        _context.SaveChanges();
    }
}

