using Microsoft.EntityFrameworkCore;

namespace LittleTeti.Data;

public class LTDataContext : DbContext{
    public LTDataContext(DbContextOptions<LTDataContext> options) : base(options)
    {
        
    }

    public DbSet<Address> Address {get; set;}
    public DbSet<User> Users {get; set;}
    public DbSet<Solicitaion> Posts {get; set;}
    public DbSet<Product> Products {get; set;}



}