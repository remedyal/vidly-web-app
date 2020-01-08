namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, Stock, GenreId)" +
                " VALUES ('Hangover', '2012-02-26', '2012-04-01', 5, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, Stock, GenreId)" +
                " VALUES ('Die Hard', '1996-12-25', '2012-04-01', 3, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
