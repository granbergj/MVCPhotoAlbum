namespace PhotoAlbum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_AlbumId_to_Photo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Photos", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Photos", new[] { "Album_Id" });
            RenameColumn(table: "dbo.Photos", name: "Album_Id", newName: "AlbumId");
            AlterColumn("dbo.Photos", "AlbumId", c => c.Int(nullable: false));
            CreateIndex("dbo.Photos", "AlbumId");
            AddForeignKey("dbo.Photos", "AlbumId", "dbo.Albums", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "AlbumId", "dbo.Albums");
            DropIndex("dbo.Photos", new[] { "AlbumId" });
            AlterColumn("dbo.Photos", "AlbumId", c => c.Int());
            RenameColumn(table: "dbo.Photos", name: "AlbumId", newName: "Album_Id");
            CreateIndex("dbo.Photos", "Album_Id");
            AddForeignKey("dbo.Photos", "Album_Id", "dbo.Albums", "Id");
        }
    }
}
