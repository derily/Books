namespace Books.Web.DataContexts.BookMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameBookProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Category", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Genre", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "Category");
        }
    }
}
