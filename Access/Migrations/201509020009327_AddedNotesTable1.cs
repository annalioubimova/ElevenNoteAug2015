namespace Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNotesTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ok_to_delete",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SomeColum = c.String(),
                        Auri = c.String(),
                        CarPolish = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ok_to_delete");
        }
    }
}
