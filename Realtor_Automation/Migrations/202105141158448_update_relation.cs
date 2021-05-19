namespace Realtor_Automation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_relation : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Ev", "MusteriId");
            CreateIndex("dbo.Ev", "EvTurId");
            AddForeignKey("dbo.Ev", "EvTurId", "dbo.EvTur", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Ev", "MusteriId", "dbo.Musteri", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ev", "MusteriId", "dbo.Musteri");
            DropForeignKey("dbo.Ev", "EvTurId", "dbo.EvTur");
            DropIndex("dbo.Ev", new[] { "EvTurId" });
            DropIndex("dbo.Ev", new[] { "MusteriId" });
        }
    }
}
