﻿// <auto-generated />
using BookStorageDatabaseImplement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStorageDatabaseImplement.Migrations
{
    [DbContext(typeof(LibraryDatabase))]
    [Migration("20211219095320_AddBookForm")]
    partial class AddBookForm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStorageDatabaseImplement.models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Annotation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookForm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookStorageDatabaseImplement.models.BookForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Form")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookForms");
                });

            modelBuilder.Entity("BookStorageDatabaseImplement.models.BookReader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("ReaderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ReaderId");

                    b.ToTable("BookReaders");
                });

            modelBuilder.Entity("BookStorageDatabaseImplement.models.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("BookStorageDatabaseImplement.models.BookReader", b =>
                {
                    b.HasOne("BookStorageDatabaseImplement.models.Book", "Book")
                        .WithMany("BookReaders")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStorageDatabaseImplement.models.Reader", "Reader")
                        .WithMany("BookReaders")
                        .HasForeignKey("ReaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}