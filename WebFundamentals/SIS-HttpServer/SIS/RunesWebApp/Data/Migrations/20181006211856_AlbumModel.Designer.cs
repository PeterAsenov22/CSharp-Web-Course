﻿namespace RunesWebApp.Data.Migrations
{
    // <auto-generated />
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;
    using RunesWebApp.Data;

    [DbContext(typeof(RunesContext))]
    [Migration("20181006211856_AlbumModel")]
    partial class AlbumModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RunesWebApp.Models.Album", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cover");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("RunesWebApp.Models.Track", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlbumId");

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("RunesWebApp.Models.TrackAlbum", b =>
                {
                    b.Property<string>("AlbumId");

                    b.Property<string>("TrackId");

                    b.Property<int>("Id");

                    b.HasKey("AlbumId", "TrackId");

                    b.HasIndex("TrackId");

                    b.ToTable("TracksAlbums");
                });

            modelBuilder.Entity("RunesWebApp.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("HashedPassword");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RunesWebApp.Models.Track", b =>
                {
                    b.HasOne("RunesWebApp.Models.Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId");
                });

            modelBuilder.Entity("RunesWebApp.Models.TrackAlbum", b =>
                {
                    b.HasOne("RunesWebApp.Models.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RunesWebApp.Models.Track", "Track")
                        .WithMany("Albums")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
