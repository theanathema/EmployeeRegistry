namespace EmployeesRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false, maxLength: 160));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String());
        }
    }
}
