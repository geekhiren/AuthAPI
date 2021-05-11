namespace AuthLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initRegi1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "FirstName", c => c.String());
            AddColumn("dbo.User", "LastName", c => c.String());
            DropColumn("dbo.User", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Name", c => c.String());
            DropColumn("dbo.User", "LastName");
            DropColumn("dbo.User", "FirstName");
        }
    }
}
