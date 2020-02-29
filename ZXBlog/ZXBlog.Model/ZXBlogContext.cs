using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXBlog.Model
{
    public class ZXBlogContext : DbContext
    {
        public ZXBlogContext() : base("con")
        {
            Database.SetInitializer<ZXBlogContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<role> roles { get; set; }//角色表
        public DbSet<user> users { get; set; }//用户表
    }
}
