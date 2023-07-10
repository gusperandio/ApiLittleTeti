using Microsoft.EntityFrameworkCore;
using LittleTeti.Models;

namespace LittleTeti.Data;

public class LTDataContext : DbContext{
    public LTDataContext(DbContextOptions<LTDataContext> options) : base(options)
    {
        
    }

    public DbSet<Address> Address {get; set;}
    public DbSet<Product> Products {get; set;}
    public DbSet<Solicitation> Solicitations {get; set;}
    public DbSet<User> Users {get; set;}



}