namespace PraktikaMusicStoreWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountDatabaseIsntWorking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.FeedbackID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feedbacks");
        }
    }
}
