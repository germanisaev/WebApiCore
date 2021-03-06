﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Model;

namespace WebApi.Migrations
{
    [DbContext(typeof(VisitDetailContext))]
    partial class VisitDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Model.VisitDetail", b =>
                {
                    b.Property<int>("QueueId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QueueDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QueueNumber")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<int>("QueueStatus")
                        .IsRequired()
                        .HasColumnType("smallint");

                    b.HasKey("QueueId");

                    b.ToTable("VisitDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
