using Microsoft.EntityFrameworkCore;
using WpfAppDb.Models;
using WpfAppDb.Data;
using WpfAppDb.Models;

namespace WpfEmployees.Repositories;

public class CategoryRepository(AppDbContext context) : IRepository<Category>
{
    private readonly AppDbContext _context = context;

    public List<Category> GetAll() => _context.Categories.ToList();

    public void Update(Category category)
    {
        _context.Entry(category).State = EntityState.Modified;
        _context.SaveChanges();
    }
}

