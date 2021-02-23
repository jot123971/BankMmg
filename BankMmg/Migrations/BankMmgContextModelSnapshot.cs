﻿// <auto-generated />
using BankMmg.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankMmg.Migrations
{
    [DbContext(typeof(BankMmgContext))]
    partial class BankMmgContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankMmg.Models.BankSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("employee_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employee_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employee_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employee_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employee_Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BankSystem");
                });
#pragma warning restore 612, 618
        }
    }
}
