﻿// <auto-generated />
using DatabaseModel.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DatabaseModel.Migrations
{
    [DbContext(typeof(DataMyContext))]
    partial class DataMyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabaseModel.Models.Acessorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Acessorio");
                });

            modelBuilder.Entity("DatabaseModel.Models.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Marca");

                    b.HasKey("Id");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("DatabaseModel.Models.CarroAcessorioNN", b =>
                {
                    b.Property<int>("CarroId");

                    b.Property<int>("AcessorioId");

                    b.HasKey("CarroId", "AcessorioId");

                    b.HasIndex("AcessorioId");

                    b.ToTable("CarroAcessorioNN");
                });

            modelBuilder.Entity("DatabaseModel.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeRua");

                    b.Property<int>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("DatabaseModel.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("DatabaseModel.Models.PessoaCarroNN", b =>
                {
                    b.Property<int>("PessoaId");

                    b.Property<int>("CarroId");

                    b.HasKey("PessoaId", "CarroId");

                    b.HasIndex("CarroId");

                    b.ToTable("PessoaCarroNN");
                });

            modelBuilder.Entity("DatabaseModel.Models.CarroAcessorioNN", b =>
                {
                    b.HasOne("DatabaseModel.Models.Acessorio", "Acessorio")
                        .WithMany("CarroAcessorioNN")
                        .HasForeignKey("AcessorioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DatabaseModel.Models.Carro", "Carro")
                        .WithMany("CarroAcessorioNN")
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DatabaseModel.Models.Endereco", b =>
                {
                    b.HasOne("DatabaseModel.Models.Pessoa", "Pessoa")
                        .WithMany("Enderecos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DatabaseModel.Models.PessoaCarroNN", b =>
                {
                    b.HasOne("DatabaseModel.Models.Carro", "Carro")
                        .WithMany("PessoaCarroNN")
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DatabaseModel.Models.Pessoa", "Pessoa")
                        .WithMany("PessoaCarroNN")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
