using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgWeb.Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Esferas",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esferas", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Funcoes",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcoes", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Localizadores",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizadores", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orgaos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orgaos", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutosPO",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosPO", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Programas",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programas", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubFuncoes",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubFuncoes", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoProgramas",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProgramas", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UnidadesMedida",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedida", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UnidadesMedidaPO",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedidaPO", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UnidadesOrcamentaria",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesOrcamentaria", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AcompanhamentoOrcamentario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Execicio = table.Column<int>(type: "int", nullable: false),
                    TipoCaptacao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CD_Esfera = table.Column<int>(type: "int", nullable: false),
                    CD_Orgao = table.Column<int>(type: "int", nullable: false),
                    CD_UnidadeOrcamentaria = table.Column<int>(type: "int", nullable: false),
                    CD_Funcao = table.Column<int>(type: "int", nullable: false),
                    CD_SubFuncao = table.Column<int>(type: "int", nullable: false),
                    CD_Programa = table.Column<int>(type: "int", nullable: false),
                    CD_TipoPrograma = table.Column<int>(type: "int", nullable: false),
                    Acao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CD_Produto = table.Column<int>(type: "int", nullable: false),
                    CD_UnidadeMedida = table.Column<int>(type: "int", nullable: false),
                    CD_Localizador = table.Column<int>(type: "int", nullable: false),
                    LocalizadorPreenchimentoObrigatorio = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ElementosSemCaptacao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QtdMetaLoa = table.Column<int>(type: "int", nullable: false),
                    ProjetoLei = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DotacaoInicial = table.Column<long>(type: "bigint", nullable: false),
                    Autorizado = table.Column<long>(type: "bigint", nullable: false),
                    Empenhado = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Liquidado = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ReprogramadoFisico = table.Column<long>(type: "bigint", nullable: false),
                    ReprogramadoFinanceiro = table.Column<long>(type: "bigint", nullable: false),
                    RealizadoLoa = table.Column<long>(type: "bigint", nullable: false),
                    Pago = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    LiquidoRap = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    RealizadoRap = table.Column<long>(type: "bigint", nullable: false),
                    snRegionalizarNaExecucao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionalizacaoExecucaoDescricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionalizacaoExecucaoSiglaUF = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionalizacaoExecucaoDescricaoMunicipio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionalizacaoExecucaoDescricaoCorteGeorafico = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionalizacaoExecucaoLiquidado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionalizacaoExecucaoRealizado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoPO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TituloPO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CD_ProdutoPO = table.Column<int>(type: "int", nullable: false),
                    CD_UnidadeMedidaPO = table.Column<int>(type: "int", nullable: false),
                    MetaLoaPropostaPO = table.Column<long>(type: "bigint", nullable: false),
                    DotacaoInicialPO = table.Column<long>(type: "bigint", nullable: false),
                    AutorizadPO = table.Column<long>(type: "bigint", nullable: false),
                    EmpenhadoPO = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    LiquidadoPO = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    RealizadoPO = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FisicoReprogramadoPO = table.Column<long>(type: "bigint", nullable: false),
                    FinanceiroReprogramadoPO = table.Column<long>(type: "bigint", nullable: false),
                    PagoPO = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    LiquidoRapPO = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    QtdMetaAtualPO = table.Column<long>(type: "bigint", nullable: false),
                    QtdMetaAtual = table.Column<long>(type: "bigint", nullable: false),
                    RegionalizacaoExecucaoComentario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumQuestionario = table.Column<int>(type: "int", nullable: false),
                    DescQuestionario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumPergunta = table.Column<int>(type: "int", nullable: false),
                    DescPergunta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescTipoPergunta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescAdicionalPergunta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumResposta = table.Column<int>(type: "int", nullable: false),
                    DescResposta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumPrioridadeResposta = table.Column<int>(type: "int", nullable: false),
                    DescTextoResposta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcompanhamentoOrcamentario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_Esferas_CD_Esfera",
                        column: x => x.CD_Esfera,
                        principalTable: "Esferas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_Funcoes_CD_Funcao",
                        column: x => x.CD_Funcao,
                        principalTable: "Funcoes",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_Localizadores_CD_Localizador",
                        column: x => x.CD_Localizador,
                        principalTable: "Localizadores",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_Orgaos_CD_Orgao",
                        column: x => x.CD_Orgao,
                        principalTable: "Orgaos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_ProdutosPO_CD_ProdutoPO",
                        column: x => x.CD_ProdutoPO,
                        principalTable: "ProdutosPO",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_Produtos_CD_Produto",
                        column: x => x.CD_Produto,
                        principalTable: "Produtos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_Programas_CD_Programa",
                        column: x => x.CD_Programa,
                        principalTable: "Programas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_SubFuncoes_CD_SubFuncao",
                        column: x => x.CD_SubFuncao,
                        principalTable: "SubFuncoes",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_TipoProgramas_CD_TipoPrograma",
                        column: x => x.CD_TipoPrograma,
                        principalTable: "TipoProgramas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_UnidadesMedidaPO_CD_UnidadeMedida~",
                        column: x => x.CD_UnidadeMedidaPO,
                        principalTable: "UnidadesMedidaPO",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_UnidadesMedida_CD_UnidadeMedida",
                        column: x => x.CD_UnidadeMedida,
                        principalTable: "UnidadesMedida",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcompanhamentoOrcamentario_UnidadesOrcamentaria_CD_UnidadeOr~",
                        column: x => x.CD_UnidadeOrcamentaria,
                        principalTable: "UnidadesOrcamentaria",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Esfera",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Esfera");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Funcao",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Funcao");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Localizador",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Localizador");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Orgao",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Orgao");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Produto",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_ProdutoPO",
                table: "AcompanhamentoOrcamentario",
                column: "CD_ProdutoPO");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Programa",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Programa");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_SubFuncao",
                table: "AcompanhamentoOrcamentario",
                column: "CD_SubFuncao");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_TipoPrograma",
                table: "AcompanhamentoOrcamentario",
                column: "CD_TipoPrograma");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_UnidadeMedida",
                table: "AcompanhamentoOrcamentario",
                column: "CD_UnidadeMedida");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_UnidadeMedidaPO",
                table: "AcompanhamentoOrcamentario",
                column: "CD_UnidadeMedidaPO");

            migrationBuilder.CreateIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_UnidadeOrcamentaria",
                table: "AcompanhamentoOrcamentario",
                column: "CD_UnidadeOrcamentaria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcompanhamentoOrcamentario");

            migrationBuilder.DropTable(
                name: "Esferas");

            migrationBuilder.DropTable(
                name: "Funcoes");

            migrationBuilder.DropTable(
                name: "Localizadores");

            migrationBuilder.DropTable(
                name: "Orgaos");

            migrationBuilder.DropTable(
                name: "ProdutosPO");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Programas");

            migrationBuilder.DropTable(
                name: "SubFuncoes");

            migrationBuilder.DropTable(
                name: "TipoProgramas");

            migrationBuilder.DropTable(
                name: "UnidadesMedidaPO");

            migrationBuilder.DropTable(
                name: "UnidadesMedida");

            migrationBuilder.DropTable(
                name: "UnidadesOrcamentaria");
        }
    }
}
