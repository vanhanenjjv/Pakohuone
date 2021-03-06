﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pakohuone.Data;

namespace Pakohuone.Data.Migrations
{
    [DbContext(typeof(PakohuoneContext))]
    partial class PakohuoneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pakohuone.Entities.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Directory")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Directory")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("Pakohuone.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LevelId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("WorldId");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("Name");

                    b.HasIndex("WorldId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Pakohuone.Entities.World", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Directory")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Time");

                    b.HasKey("Id");

                    b.HasIndex("Directory")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Worlds");
                });

            modelBuilder.Entity("Pakohuone.Entities.Room", b =>
                {
                    b.HasOne("Pakohuone.Entities.Level", "Level")
                        .WithMany("Rooms")
                        .HasForeignKey("LevelId");

                    b.HasOne("Pakohuone.Entities.World", "World")
                        .WithMany("Rooms")
                        .HasForeignKey("WorldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
