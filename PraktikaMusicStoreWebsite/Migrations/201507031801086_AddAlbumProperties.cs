namespace PraktikaMusicStoreWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAlbumProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "ReleaseDate");
        }
    }
}
