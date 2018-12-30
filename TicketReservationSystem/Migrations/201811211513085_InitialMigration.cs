namespace TicketReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IdentificationNumber = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        IsAgency = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        FlightId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        ReservationNumber = c.String(nullable: false),
                        ReservationDateTime = c.DateTime(nullable: false),
                        FlightClass = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.FlightId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        FlightId = c.Int(nullable: false, identity: true),
                        FlightNumber = c.String(nullable: false),
                        DepartureDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FlightId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Reservations", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Reservations", new[] { "CustomerId" });
            DropIndex("dbo.Reservations", new[] { "FlightId" });
            DropTable("dbo.Flights");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
        }
    }
}
