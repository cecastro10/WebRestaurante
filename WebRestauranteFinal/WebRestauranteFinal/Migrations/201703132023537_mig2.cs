namespace WebRestauranteFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tb_Prato", "datacadastro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tb_Prato", "datacadastro", c => c.DateTime(nullable: false));
        }
    }
}
