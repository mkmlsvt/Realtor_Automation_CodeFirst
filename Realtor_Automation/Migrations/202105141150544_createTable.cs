namespace Realtor_Automation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 30, unicode: false),
                        Parola = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ev",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MusteriId = c.Int(nullable: false),
                        Fiyat = c.Double(nullable: false),
                        Kat = c.Int(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        Musait = c.Boolean(nullable: false),
                        Resim = c.String(maxLength: 60, unicode: false),
                        Esyali = c.Boolean(nullable: false),
                        OdaSayi = c.Int(nullable: false),
                        Metrekare = c.Int(nullable: false),
                        Adres = c.String(maxLength: 100, unicode: false),
                        EvTurId = c.Int(nullable: false),
                        KiralikSatilik = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EvTur",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kiralanan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        MusteriId = c.Int(nullable: false),
                        EvId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ev", t => t.EvId, cascadeDelete: true)
                .ForeignKey("dbo.Musteri", t => t.MusteriId, cascadeDelete: true)
                .Index(t => t.MusteriId)
                .Index(t => t.EvId);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 20, unicode: false),
                        Soyad = c.String(maxLength: 20, unicode: false),
                        TelNo = c.String(maxLength: 20, unicode: false),
                        MusteriTurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MusteriTur", t => t.MusteriTurId, cascadeDelete: true)
                .Index(t => t.MusteriTurId);
            
            CreateTable(
                "dbo.MusteriTur",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Satilan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        MusteriId = c.Int(nullable: false),
                        EvId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ev", t => t.EvId, cascadeDelete: true)
                .ForeignKey("dbo.Musteri", t => t.MusteriId, cascadeDelete: true)
                .Index(t => t.MusteriId)
                .Index(t => t.EvId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satilan", "MusteriId", "dbo.Musteri");
            DropForeignKey("dbo.Satilan", "EvId", "dbo.Ev");
            DropForeignKey("dbo.Musteri", "MusteriTurId", "dbo.MusteriTur");
            DropForeignKey("dbo.Kiralanan", "MusteriId", "dbo.Musteri");
            DropForeignKey("dbo.Kiralanan", "EvId", "dbo.Ev");
            DropIndex("dbo.Satilan", new[] { "EvId" });
            DropIndex("dbo.Satilan", new[] { "MusteriId" });
            DropIndex("dbo.Musteri", new[] { "MusteriTurId" });
            DropIndex("dbo.Kiralanan", new[] { "EvId" });
            DropIndex("dbo.Kiralanan", new[] { "MusteriId" });
            DropTable("dbo.Satilan");
            DropTable("dbo.MusteriTur");
            DropTable("dbo.Musteri");
            DropTable("dbo.Kiralanan");
            DropTable("dbo.EvTur");
            DropTable("dbo.Ev");
            DropTable("dbo.Admin");
        }
    }
}
