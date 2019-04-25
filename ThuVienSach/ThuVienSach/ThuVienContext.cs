using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVienSach.Models;

namespace ThuVienSach
{
    public class ThuVienContext : DbContext
    {
        public ThuVienContext() : base("ConnectionString")
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
