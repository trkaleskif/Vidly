namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies(Name,Genre,ReleaseDate,AddedDate,NumberInStock) values ('Hangover', 'Comedy' ,'11/6/2009','5/4/2016',5)");
            Sql("Insert into Movies(Name,Genre,ReleaseDate,AddedDate,NumberInStock) values ('Die Hard', 'Action' ,'11/6/2009','5/4/2016',15)");
            Sql("Insert into Movies(Name,Genre,ReleaseDate,AddedDate,NumberInStock) values ('The Terminator', 'Action' ,'11/6/2009','5/4/2016',9)");
            Sql("Insert into Movies(Name,Genre,ReleaseDate,AddedDate,NumberInStock) values ('Toy Story','Family' ,'11/6/2009','5/4/2016',9)");
            Sql("Insert into Movies(Name,Genre,ReleaseDate,AddedDate,NumberInStock) values ('Titanic','Romance' ,'11/6/2009','5/4/2016',9)");
        }
        
        public override void Down()
        {
        }
    }
}
