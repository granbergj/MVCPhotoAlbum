// <auto-generated />
namespace PhotoAlbum.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class added_AlbumId_to_Photo : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(added_AlbumId_to_Photo));
        
        string IMigrationMetadata.Id
        {
            get { return "201704270012365_added_AlbumId_to_Photo"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}