namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("Alter table Customers add Birthdate DateTime NULL");
        }
        
        public override void Down()
        {
        }
    }
}
