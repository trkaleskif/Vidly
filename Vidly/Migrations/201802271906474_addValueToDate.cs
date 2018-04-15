namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addValueToDate : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set Birthdate = '1/1/1980' where Id=1");
                
        }
        
        public override void Down()
        {
        }
    }
}
