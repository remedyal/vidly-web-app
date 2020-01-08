namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthdateData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1990-09-17' WHERE Id = 1 ");
        }
        
        public override void Down()
        {
        }
    }
}
