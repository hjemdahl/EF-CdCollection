﻿// <auto-generated />
using CdCollection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CdCollection.Migrations
{
    [DbContext(typeof(CollectionContext))]
    partial class CollectionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("CdCollection.Models.Artist", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArtistID");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("CdCollection.Models.Cd", b =>
                {
                    b.Property<int>("CdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("CdID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Cd");
                });

            modelBuilder.Entity("CdCollection.Models.Cd", b =>
                {
                    b.HasOne("CdCollection.Models.Artist", "Artist")
                        .WithMany("Cds")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("CdCollection.Models.Artist", b =>
                {
                    b.Navigation("Cds");
                });
#pragma warning restore 612, 618
        }
    }
}
