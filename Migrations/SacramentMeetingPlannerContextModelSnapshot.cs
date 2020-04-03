﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Data;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    partial class SacramentMeetingPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Elements", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Assignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HymnNumber")
                        .HasColumnType("int");

                    b.Property<int>("MeetingElementsId")
                        .HasColumnType("int");

                    b.Property<Guid?>("MeetingID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MeetingID");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Meeting", b =>
                {
                    b.Property<Guid>("MeetingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClosingHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClosingHymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("ClosingPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conducting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("OpeningHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpeningHymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("OpeningPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SacramentHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SacramentHymnNumber")
                        .HasColumnType("int");

                    b.HasKey("MeetingID");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Elements", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Meeting", null)
                        .WithMany("Elements")
                        .HasForeignKey("MeetingID");
                });
#pragma warning restore 612, 618
        }
    }
}