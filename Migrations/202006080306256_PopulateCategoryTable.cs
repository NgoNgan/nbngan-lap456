namespace baongan_lap456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Categories(Id, name) VALUES(1,'Development')");
            Sql("INSERT into Categories(Id, name) VALUES(2,'Business')");
            Sql("INSERT into Categories(Id, name) VALUES(3,'Maketing')");


        }

        public override void Down()
        {
        }
    }
}
