using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaAvaliacao.API.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avaliacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caracteristicas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatoresAgravantes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatoresAtenuantes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(50)", nullable: false),
                    RG = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cor = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Profissao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Empresa = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Naturalidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profissaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profissionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profissao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroId = table.Column<int>(type: "int", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissionals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ADM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MSD = table.Column<int>(type: "int", nullable: false),
                    MSE = table.Column<int>(type: "int", nullable: false),
                    GoniometriaMsdMse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MID = table.Column<int>(type: "int", nullable: false),
                    MIE = table.Column<int>(type: "int", nullable: false),
                    GoniometriaMidMie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perimetria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coluna = table.Column<int>(type: "int", nullable: false),
                    GoniometriaColuna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestesEspeciais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvaliacaoSubjetivaDorId = table.Column<int>(type: "int", nullable: false),
                    ExamesComplementares = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ADM_Avaliacaos_AvaliacaoSubjetivaDorId",
                        column: x => x.AvaliacaoSubjetivaDorId,
                        principalTable: "Avaliacaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anamneses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosticoClinico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfissionalId = table.Column<int>(type: "int", nullable: true),
                    CID10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    IMC = table.Column<double>(type: "float", nullable: false),
                    QueixaPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicoResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anamneses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anamneses_Profissionals_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ObjetivosCondutas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosticoTerapeutico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjetivosTratamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CondutaFisioterapeutica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfissionalId = table.Column<int>(type: "int", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetivosCondutas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjetivosCondutas_Profissionals_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExameFisico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inspecao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Palpacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADMId = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExameFisico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExameFisico_ADM_ADMId",
                        column: x => x.ADMId,
                        principalTable: "ADM",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TesteForcaMuscular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusculoId = table.Column<int>(type: "int", nullable: false),
                    Grau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADMId = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesteForcaMuscular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TesteForcaMuscular_ADM_ADMId",
                        column: x => x.ADMId,
                        principalTable: "ADM",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TesteForcaMuscular_Musculos_MusculoId",
                        column: x => x.MusculoId,
                        principalTable: "Musculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AntecedentesFamiliares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnamneseId = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntecedentesFamiliares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AntecedentesFamiliares_Anamneses_AnamneseId",
                        column: x => x.AnamneseId,
                        principalTable: "Anamneses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AntecedentesPessoais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnamneseId = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntecedentesPessoais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AntecedentesPessoais_Anamneses_AnamneseId",
                        column: x => x.AnamneseId,
                        principalTable: "Anamneses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnamneseId = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicamentos_Anamneses_AnamneseId",
                        column: x => x.AnamneseId,
                        principalTable: "Anamneses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnamneseId = table.Column<int>(type: "int", nullable: true),
                    ExameFisicoId = table.Column<int>(type: "int", nullable: true),
                    ObjetivosCondutaId = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fichas_Anamneses_AnamneseId",
                        column: x => x.AnamneseId,
                        principalTable: "Anamneses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fichas_ExameFisico_ExameFisicoId",
                        column: x => x.ExameFisicoId,
                        principalTable: "ExameFisico",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fichas_ObjetivosCondutas_ObjetivosCondutaId",
                        column: x => x.ObjetivosCondutaId,
                        principalTable: "ObjetivosCondutas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Evolucaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataEvolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PressaoInicial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PressaoFinal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FichaId = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAtualizacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolucaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evolucaos_Fichas_FichaId",
                        column: x => x.FichaId,
                        principalTable: "Fichas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADM_AvaliacaoSubjetivaDorId",
                table: "ADM",
                column: "AvaliacaoSubjetivaDorId");

            migrationBuilder.CreateIndex(
                name: "IX_Anamneses_ProfissionalId",
                table: "Anamneses",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_AntecedentesFamiliares_AnamneseId",
                table: "AntecedentesFamiliares",
                column: "AnamneseId");

            migrationBuilder.CreateIndex(
                name: "IX_AntecedentesPessoais_AnamneseId",
                table: "AntecedentesPessoais",
                column: "AnamneseId");

            migrationBuilder.CreateIndex(
                name: "IX_Evolucaos_FichaId",
                table: "Evolucaos",
                column: "FichaId");

            migrationBuilder.CreateIndex(
                name: "IX_ExameFisico_ADMId",
                table: "ExameFisico",
                column: "ADMId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_AnamneseId",
                table: "Fichas",
                column: "AnamneseId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_ExameFisicoId",
                table: "Fichas",
                column: "ExameFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_ObjetivosCondutaId",
                table: "Fichas",
                column: "ObjetivosCondutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_AnamneseId",
                table: "Medicamentos",
                column: "AnamneseId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetivosCondutas_ProfissionalId",
                table: "ObjetivosCondutas",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_TesteForcaMuscular_ADMId",
                table: "TesteForcaMuscular",
                column: "ADMId");

            migrationBuilder.CreateIndex(
                name: "IX_TesteForcaMuscular_MusculoId",
                table: "TesteForcaMuscular",
                column: "MusculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AntecedentesFamiliares");

            migrationBuilder.DropTable(
                name: "AntecedentesPessoais");

            migrationBuilder.DropTable(
                name: "Cadastro");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Evolucaos");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Profissaos");

            migrationBuilder.DropTable(
                name: "TesteForcaMuscular");

            migrationBuilder.DropTable(
                name: "Fichas");

            migrationBuilder.DropTable(
                name: "Musculos");

            migrationBuilder.DropTable(
                name: "Anamneses");

            migrationBuilder.DropTable(
                name: "ExameFisico");

            migrationBuilder.DropTable(
                name: "ObjetivosCondutas");

            migrationBuilder.DropTable(
                name: "ADM");

            migrationBuilder.DropTable(
                name: "Profissionals");

            migrationBuilder.DropTable(
                name: "Avaliacaos");
        }
    }
}
