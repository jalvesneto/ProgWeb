﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgWeb.Domain;

#nullable disable

namespace ProgWeb.Domain.Migrations
{
    [DbContext(typeof(ProgWebContext))]
    [Migration("20230613094458_AlterCSV")]
    partial class AlterCSV
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProgWeb.Domain.Entities.AcompanhamentoOrcamentario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("AutorizadPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Autorizado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_Acao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_Esfera")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_Funcao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_Localizador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_Orgao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_Produto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_ProdutoPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_Programa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_SubFuncao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_TipoPrograma")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_UnidadeMedida")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_UnidadeMedidaPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CD_UnidadeOrcamentaria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CodigoPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescAdicionalPergunta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescPergunta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescQuestionario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescResposta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescTextoResposta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescTipoPergunta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescricaoEsfera")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescricaoFuncao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescricaoOrgao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescricaoUnidadeOrcamentaria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescricaoUnidademedida")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescricaosubFuncao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DotacaoInicial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DotacaoInicialPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ElementosSemCaptacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Empenhado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmpenhadoPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Execicio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FinanceiroReprogramadoPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FisicoReprogramadoPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Liquidado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LiquidadoPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LiquidoRap")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LiquidoRapPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LocalizadorPreenchimentoObrigatorio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MetaLoaPropostaPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumPergunta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumPrioridadeResposta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumQuestionario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumResposta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pago")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PagoPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProjetoLei")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QtdMetaAtual")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QtdMetaAtualPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QtdMetaLoa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RealizadoLoa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RealizadoPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RealizadoRap")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionalizacaoExecucaoComentario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionalizacaoExecucaoDescricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionalizacaoExecucaoDescricaoCorteGeorafico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionalizacaoExecucaoDescricaoMunicipio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionalizacaoExecucaoLiquidado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionalizacaoExecucaoRealizado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionalizacaoExecucaoSiglaUF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReprogramadoFinanceiro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReprogramadoFisico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoCaptacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoPrograma")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TituloAcao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TituloPO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TituloPrograma")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("descricaolocalizador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("descricaoproduto_po")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("descricaounidademedida_po")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("snRegionalizarNaExecucao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AcompanhamentoOrcamentario");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.Esfera", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("Esferas");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.Funcao", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("Funcoes");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.Localizador", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("Localizadores");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.Orgao", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("Orgaos");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.ProdutoPO", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("ProdutosPO");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.Programa", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("Programas");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.SubFuncao", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("SubFuncoes");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.TipoPrograma", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("TipoProgramas");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.UnidadeMedida", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("UnidadesMedida");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.UnidadeMedidaPO", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("UnidadesMedidaPO");
                });

            modelBuilder.Entity("ProgWeb.Domain.Entities.UnidadeOrcamentaria", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("UnidadesOrcamentaria");
                });
#pragma warning restore 612, 618
        }
    }
}
