namespace PhotoAlbum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_required_to_UserFileName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Photos", "UserFileName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Photos", "UserFileName", c => c.String());
        }
    }
}
