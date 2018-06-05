using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Bilhetagem.Servicos.Migrations
{
    public partial class setupInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricoDeProcessos",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Arquivo = table.Column<string>(maxLength: 200, nullable: true),
                    DataProcesso = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false),
                    Documento = table.Column<string>(maxLength: 20, nullable: false),
                    NumeroProcesso = table.Column<string>(maxLength: 30, nullable: false),
                    Sistema = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TipoProcesso = table.Column<int>(nullable: false),
                    ValorHistorico = table.Column<string>(maxLength: 30, nullable: false),
                    VerificacaoProcesso = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoDeProcessos", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoDeProcessos");
        }
    }
}
