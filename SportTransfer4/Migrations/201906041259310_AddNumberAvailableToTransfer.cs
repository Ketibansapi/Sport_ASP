namespace SportTransfer4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToTransfer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transfers", "NumberAvailable", c => c.Byte(nullable: false));
            Sql("UPDATE Transfers SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transfers", "NumberAvailable");
        }
    }
}
