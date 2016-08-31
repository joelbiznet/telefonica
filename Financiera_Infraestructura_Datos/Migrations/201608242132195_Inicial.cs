namespace Financiera_Infraestructura_Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CC.Cliente",
                c => new
                    {
                        COD_CLIENTE = c.Int(nullable: false, identity: true),
                        NOM_CLIENTE = c.String(nullable: false),
                        TIP_CLIENTE = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.COD_CLIENTE);
            
            CreateTable(
                "CC.CUENTAS_CORRIENTE",
                c => new
                    {
                        NUM_CUENTA = c.Int(nullable: false, identity: true),
                        SAL_CUENTA = c.Int(nullable: false),
                        FEC_APERTURA = c.Int(nullable: false),
                        IND_ESTADO = c.Int(nullable: false),
                        COD_CUENTA = c.Int(nullable: false),
                        COD_CLIENTE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NUM_CUENTA)
                .ForeignKey("CC.Cliente", t => t.COD_CLIENTE, cascadeDelete: true)
                .Index(t => t.COD_CLIENTE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("CC.CUENTAS_CORRIENTE", "COD_CLIENTE", "CC.Cliente");
            DropIndex("CC.CUENTAS_CORRIENTE", new[] { "COD_CLIENTE" });
            DropTable("CC.CUENTAS_CORRIENTE");
            DropTable("CC.Cliente");
        }
    }
}
