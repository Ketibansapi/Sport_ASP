namespace SportTransfer4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Football')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Basketball')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Baseball')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Cricket')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Rugby')");
        }
        
        public override void Down()
        {
        }
    }
}
