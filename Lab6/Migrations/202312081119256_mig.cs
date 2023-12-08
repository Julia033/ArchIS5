namespace Lab6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.House3",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Start = c.String(),
                        End = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.House3");
        }
    }
}
