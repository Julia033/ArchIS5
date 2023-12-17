namespace Laba6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Houses", "CityID", "dbo.Cities");
            DropPrimaryKey("dbo.Cities");
            AlterColumn("dbo.Cities", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cities", "Id");
            AddForeignKey("dbo.Houses", "CityID", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "CityID", "dbo.Cities");
            DropPrimaryKey("dbo.Cities");
            AlterColumn("dbo.Cities", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Cities", "Id");
            AddForeignKey("dbo.Houses", "CityID", "dbo.Cities", "Id");
        }
    }
}
