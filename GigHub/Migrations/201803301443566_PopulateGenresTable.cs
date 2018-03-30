namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT into Genres (Id, Name) VALUES (2, 'Blues')");
            Sql("INSERT into Genres (Id, Name) VALUES (3, 'Rock')");
            Sql("INSERT into Genres (Id, Name) VALUES (4, 'Country')");
            Sql("INSERT into Genres (Id, Name) VALUES (5, 'HipHop')");
            Sql("INSERT into Genres (Id, Name) VALUES (6, 'Electronic')");
            Sql("INSERT into Genres (Id, Name) VALUES (7, 'Other')");
        }
        
        public override void Down()
        {
            Sql("DELETE from Genres WHERE Id IN (1,2,3,4,5,6,7)");
        }
    }
}
