namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sarasara : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Movies",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(),
                        AddedDate = c.DateTime(),
                        NumberInStock = c.Int(),
                        Genre_Id = c.Int()
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
           
        }
    }
}
