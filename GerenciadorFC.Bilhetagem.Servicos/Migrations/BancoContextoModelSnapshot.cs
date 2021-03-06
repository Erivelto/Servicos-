﻿// <auto-generated />
using GerenciadorFC.Bilhetagem.Servicos.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GerenciadorFC.Bilhetagem.Servicos.Migrations
{
    [DbContext(typeof(BancoContexto))]
    partial class BancoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorFC.Bilhetagem.Domino.Implementacao.HistoricoDeProcesso", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Arquivo")
                        .HasMaxLength(200);

                    b.Property<DateTime>("DataProcesso");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("NumeroProcesso")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Sistema");

                    b.Property<int>("Status");

                    b.Property<int>("TipoProcesso");

                    b.Property<string>("ValorHistorico")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("VerificacaoProcesso")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Codigo");

                    b.ToTable("HistoricoDeProcessos");
                });
#pragma warning restore 612, 618
        }
    }
}
