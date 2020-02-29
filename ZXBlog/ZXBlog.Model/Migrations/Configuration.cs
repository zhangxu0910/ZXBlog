namespace ZXBlog.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ZXBlog.Model.ZXBlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZXBlog.Model.ZXBlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.roles.AddOrUpdate
            (
                new role() { role_name = "管理员" },
                new role() { role_name = "用户" }
            );
            context.SaveChanges();

            context.users.AddOrUpdate
            (
                new user()
                {
                    user_name = "阿旭",
                    user_pwd = "123456",
                    user_email = "1944182590@qq.com",
                    user_headportrait = "1.png",
                    user_birthday = DateTime.Parse("2000-9-10"),
                    user_age = 19,
                    user_phone = "13231099376",
                    user_rname = "张旭",
                    role_id = context.roles.First(m => m.role_name == "管理员").id
                },
                new user()
                {
                    user_name = "阿壮",
                    user_pwd = "123456",
                    user_email = "319686253@qq.com",
                    user_headportrait = "2.png",
                    user_birthday = DateTime.Parse("2000-6-10"),
                    user_age = 19,
                    user_phone = "18833008503",
                    user_rname = "马壮壮",
                    role_id = context.roles.First(m => m.role_name == "用户").id
                }
            );
            context.SaveChanges();
        }
    }
}
