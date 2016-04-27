using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using WebAppCore.models;

namespace WebAppCore.Migrations
{
    [DbContext(typeof(TripContext))]
    [Migration("20160421202854_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppCore.models.Stop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.Property<int?>("TripID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("WebAppCore.models.Trip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Name");

                    b.Property<string>("UserName");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("WebAppCore.models.Stop", b =>
                {
                    b.HasOne("WebAppCore.models.Trip")
                        .WithMany()
                        .HasForeignKey("TripID");
                });
        }
    }
}
