using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgWeb.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AlterCSV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Esferas_CD_Esfera",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Funcoes_CD_Funcao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Localizadores_CD_Localizador",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Orgaos_CD_Orgao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_ProdutosPO_CD_ProdutoPO",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Produtos_CD_Produto",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Programas_CD_Programa",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_SubFuncoes_CD_SubFuncao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_TipoProgramas_CD_TipoPrograma",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_UnidadesMedidaPO_CD_UnidadeMedida~",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_UnidadesMedida_CD_UnidadeMedida",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropForeignKey(
                name: "FK_AcompanhamentoOrcamentario_UnidadesOrcamentaria_CD_UnidadeOr~",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Esfera",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Funcao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Localizador",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Orgao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Produto",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_ProdutoPO",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_Programa",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_SubFuncao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_TipoPrograma",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_UnidadeMedida",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_UnidadeMedidaPO",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropIndex(
                name: "IX_AcompanhamentoOrcamentario_CD_UnidadeOrcamentaria",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.RenameColumn(
                name: "Acao",
                table: "AcompanhamentoOrcamentario",
                newName: "descricaounidademedida_po");

            migrationBuilder.AlterColumn<string>(
                name: "ReprogramadoFisico",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ReprogramadoFinanceiro",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "RealizadoRap",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "RealizadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "RealizadoLoa",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "QtdMetaLoa",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "QtdMetaAtualPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "QtdMetaAtual",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PagoPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Pago",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NumResposta",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NumQuestionario",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NumPrioridadeResposta",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NumPergunta",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "MetaLoaPropostaPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LocalizadorPreenchimentoObrigatorio",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LiquidoRapPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LiquidoRap",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LiquidadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Liquidado",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FisicoReprogramadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FinanceiroReprogramadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Execicio",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EmpenhadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Empenhado",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ElementosSemCaptacao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DotacaoInicialPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DotacaoInicial",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_UnidadeOrcamentaria",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_UnidadeMedidaPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_UnidadeMedida",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_TipoPrograma",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_SubFuncao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_Programa",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_ProdutoPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_Produto",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_Orgao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_Localizador",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_Funcao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CD_Esfera",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Autorizado",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AutorizadPO",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CD_Acao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoEsfera",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoFuncao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoOrgao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoProduto",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoUnidadeOrcamentaria",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoUnidademedida",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescricaosubFuncao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TipoPrograma",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TituloAcao",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TituloPrograma",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "descricaolocalizador",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "descricaoproduto_po",
                table: "AcompanhamentoOrcamentario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CD_Acao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "DescricaoEsfera",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "DescricaoFuncao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "DescricaoOrgao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "DescricaoProduto",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "DescricaoUnidadeOrcamentaria",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "DescricaoUnidademedida",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "DescricaosubFuncao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "TipoPrograma",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "TituloAcao",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "TituloPrograma",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "descricaolocalizador",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.DropColumn(
                name: "descricaoproduto_po",
                table: "AcompanhamentoOrcamentario");

            migrationBuilder.RenameColumn(
                name: "descricaounidademedida_po",
                table: "AcompanhamentoOrcamentario",
                newName: "Acao");

            migrationBuilder.AlterColumn<long>(
                name: "ReprogramadoFisico",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "ReprogramadoFinanceiro",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "RealizadoRap",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "RealizadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "RealizadoLoa",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "QtdMetaLoa",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "QtdMetaAtualPO",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "QtdMetaAtual",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "PagoPO",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Pago",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "NumResposta",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "NumQuestionario",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "NumPrioridadeResposta",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "NumPergunta",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "MetaLoaPropostaPO",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "LocalizadorPreenchimentoObrigatorio",
                table: "AcompanhamentoOrcamentario",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "LiquidoRapPO",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "LiquidoRap",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "LiquidadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Liquidado",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "FisicoReprogramadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "FinanceiroReprogramadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Execicio",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "EmpenhadoPO",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Empenhado",
                table: "AcompanhamentoOrcamentario",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "ElementosSemCaptacao",
                table: "AcompanhamentoOrcamentario",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "DotacaoInicialPO",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "DotacaoInicial",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_UnidadeOrcamentaria",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_UnidadeMedidaPO",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_UnidadeMedida",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_TipoPrograma",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_SubFuncao",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_Programa",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_ProdutoPO",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_Produto",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_Orgao",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_Localizador",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_Funcao",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CD_Esfera",
                table: "AcompanhamentoOrcamentario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "Autorizado",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "AutorizadPO",
                table: "AcompanhamentoOrcamentario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Esferas_CD_Esfera",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Esfera",
                principalTable: "Esferas",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Funcoes_CD_Funcao",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Funcao",
                principalTable: "Funcoes",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Localizadores_CD_Localizador",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Localizador",
                principalTable: "Localizadores",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Orgaos_CD_Orgao",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Orgao",
                principalTable: "Orgaos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_ProdutosPO_CD_ProdutoPO",
                table: "AcompanhamentoOrcamentario",
                column: "CD_ProdutoPO",
                principalTable: "ProdutosPO",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Produtos_CD_Produto",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Produto",
                principalTable: "Produtos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_Programas_CD_Programa",
                table: "AcompanhamentoOrcamentario",
                column: "CD_Programa",
                principalTable: "Programas",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_SubFuncoes_CD_SubFuncao",
                table: "AcompanhamentoOrcamentario",
                column: "CD_SubFuncao",
                principalTable: "SubFuncoes",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_TipoProgramas_CD_TipoPrograma",
                table: "AcompanhamentoOrcamentario",
                column: "CD_TipoPrograma",
                principalTable: "TipoProgramas",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_UnidadesMedidaPO_CD_UnidadeMedida~",
                table: "AcompanhamentoOrcamentario",
                column: "CD_UnidadeMedidaPO",
                principalTable: "UnidadesMedidaPO",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_UnidadesMedida_CD_UnidadeMedida",
                table: "AcompanhamentoOrcamentario",
                column: "CD_UnidadeMedida",
                principalTable: "UnidadesMedida",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcompanhamentoOrcamentario_UnidadesOrcamentaria_CD_UnidadeOr~",
                table: "AcompanhamentoOrcamentario",
                column: "CD_UnidadeOrcamentaria",
                principalTable: "UnidadesOrcamentaria",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
