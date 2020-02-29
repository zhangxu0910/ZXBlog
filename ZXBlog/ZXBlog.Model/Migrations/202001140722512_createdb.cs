namespace ZXBlog.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.roles",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        role_name = c.String(nullable: false, maxLength: 100, unicode: false),
                        create_time = c.DateTime(nullable: false),
                        isremoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        user_name = c.String(nullable: false, maxLength: 100, unicode: false),
                        user_pwd = c.String(nullable: false, maxLength: 100, unicode: false),
                        user_email = c.String(nullable: false, maxLength: 100, unicode: false),
                        user_headportrait = c.String(nullable: false, maxLength: 100, unicode: false),
                        user_birthday = c.DateTime(nullable: false),
                        user_age = c.Int(nullable: false),
                        user_phone = c.String(nullable: false, maxLength: 100, unicode: false),
                        user_rname = c.String(nullable: false, maxLength: 100, unicode: false),
                        role_id = c.Guid(nullable: false),
                        create_time = c.DateTime(nullable: false),
                        isremoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.roles", t => t.role_id)
                .Index(t => t.role_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.users", "role_id", "dbo.roles");
            DropIndex("dbo.users", new[] { "role_id" });
            DropTable("dbo.users");
            DropTable("dbo.roles");
        }
    }
}
