﻿// <auto-generated />
using System;
using DbLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DbLayer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221105110608_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Model.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Model.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Customers")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("PrivatePersonId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("PrivatePersonId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Model.EvaluationTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateApplication")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IntendedUse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("EvaluationTasks");
                });

            modelBuilder.Entity("Model.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bank")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Bik")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CorrAccount")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DirectorId")
                        .HasColumnType("integer");

                    b.Property<string>("FullOpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Inn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Kpp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameFull")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameFullOpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameShort")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameShortOpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ogrn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OgrnDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PayAccount")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortOpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Persons", (string)null);
                });

            modelBuilder.Entity("Model.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CompilationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("VulationDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "Alex",
                            Password = "password1"
                        },
                        new
                        {
                            Id = 2,
                            Login = "Mike",
                            Password = "password2"
                        },
                        new
                        {
                            Id = 3,
                            Login = "Niki",
                            Password = "password3"
                        });
                });

            modelBuilder.Entity("Model.Director", b =>
                {
                    b.HasBaseType("Model.Person");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PowerOfAttorney")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PowerOfAttorneyBeforeDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("PowerOfAttorneyFirstDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PowerOfAttorneyNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Directors", (string)null);
                });

            modelBuilder.Entity("Model.PrivatePerson", b =>
                {
                    b.HasBaseType("Model.Person");

                    b.Property<string>("Division")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DivisionCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DivisionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("PrivatePersons", (string)null);
                });

            modelBuilder.Entity("Model.Customer", b =>
                {
                    b.HasOne("Model.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.PrivatePerson", "PrivatePerson")
                        .WithMany()
                        .HasForeignKey("PrivatePersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("PrivatePerson");
                });

            modelBuilder.Entity("Model.EvaluationTask", b =>
                {
                    b.HasOne("Model.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Model.Organization", b =>
                {
                    b.HasOne("Model.Director", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("Model.Director", b =>
                {
                    b.HasOne("Model.Person", null)
                        .WithOne()
                        .HasForeignKey("Model.Director", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.PrivatePerson", b =>
                {
                    b.HasOne("Model.Person", null)
                        .WithOne()
                        .HasForeignKey("Model.PrivatePerson", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
