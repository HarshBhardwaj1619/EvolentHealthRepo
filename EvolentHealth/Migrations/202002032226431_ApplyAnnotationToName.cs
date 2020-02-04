namespace EvolentHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationToName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
        }
    }
}
