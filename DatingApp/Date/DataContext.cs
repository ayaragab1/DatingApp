using DatingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Date;

public class DataContext :DbContext
{
    public DataContext(DbContextOptions<DataContext> options) :base(options) {}
    public DbSet<Value> Values { get; set; }
}