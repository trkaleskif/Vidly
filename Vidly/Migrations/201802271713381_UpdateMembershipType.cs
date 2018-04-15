namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name = 'Pay As You Go' where Id=1");
            Sql("Update MembershipTypes set Name = 'Monthly' where Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
