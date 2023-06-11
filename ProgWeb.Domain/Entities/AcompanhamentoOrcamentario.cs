using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgWeb.Domain.Entities
{
    public class AcompanhamentoOrcamentario
    {
        [Key]
        public long Id { get; set; }

        public int Execicio { get; set; }
        public string TipoCaptacao { get; set; }

        [ForeignKey("Esfera")]
        public int CD_Esfera { get; set; }
        public Esfera Esfera { get; set; }

        [ForeignKey("Orgao")]
        public int CD_Orgao { get; set; }
        public Orgao Orgao { get; set; }

        [ForeignKey("UnidadeOrcamentaria")]
        public int CD_UnidadeOrcamentaria { get; set; }
        public UnidadeOrcamentaria UnidadeOrcamentaria { get; set; }

        [ForeignKey("Funcao")]
        public int CD_Funcao { get; set; }
        public Funcao Funcao { get; set; }

        [ForeignKey("SubFuncao")]
        public int CD_SubFuncao { get; set; }
        public SubFuncao SubFuncao { get; set; }

        [ForeignKey("Programa")]
        public int CD_Programa { get; set; }
        public Programa Programa { get; set; }

        [ForeignKey("TipoPrograma")]
        public int CD_TipoPrograma { get; set; }
        public TipoPrograma TipoPrograma { get; set; }

        public string Acao { get; set; }

        [ForeignKey("Produto")]
        public int CD_Produto { get; set; }
        public Produto Produto { get; set; }

        [ForeignKey("UnidadeMedida")]
        public int CD_UnidadeMedida { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        [ForeignKey("Localizador")]
        public int CD_Localizador { get; set; }
        public Localizador Localizador { get; set; }
        public bool LocalizadorPreenchimentoObrigatorio { get; set; }
        public bool ElementosSemCaptacao { get; set; }
        public int QtdMetaLoa { get; set; }
        public string ProjetoLei { get; set; }
        public long DotacaoInicial { get; set; }
        public long Autorizado { get; set; }
        public decimal Empenhado { get; set; }
        public decimal Liquidado { get; set; }
        public long ReprogramadoFisico { get; set; }
        public long ReprogramadoFinanceiro { get; set; }
        public long RealizadoLoa { get; set; }
        public decimal Pago { get; set; }
        public decimal LiquidoRap { get; set; }
        public long RealizadoRap { get; set; }
        public string snRegionalizarNaExecucao { get; set; }
        public string RegionalizacaoExecucaoDescricao { get; set; }
        public string RegionalizacaoExecucaoSiglaUF { get; set; }
        public string RegionalizacaoExecucaoDescricaoMunicipio { get; set; }
        public string RegionalizacaoExecucaoDescricaoCorteGeorafico { get; set; }
        public string RegionalizacaoExecucaoLiquidado { get; set; }
        public string RegionalizacaoExecucaoRealizado { get; set; }
        public string CodigoPO { get; set; }
        public string TituloPO { get; set; }

        [ForeignKey("ProdutoPO")]
        public int CD_ProdutoPO { get; set; }
        public ProdutoPO ProdutoPO { get; set; }

        [ForeignKey("UnidadeMedidaPO")]
        public int CD_UnidadeMedidaPO { get; set; }
        public UnidadeMedidaPO UnidadeMedidaPO { get; set; }
        public long MetaLoaPropostaPO { get; set; }
        public long DotacaoInicialPO { get; set; }
        public long AutorizadPO { get; set; }
        public decimal EmpenhadoPO { get; set; }
        public decimal LiquidadoPO { get; set; }
        public decimal RealizadoPO { get; set; }
        public long FisicoReprogramadoPO { get; set; }
        public long FinanceiroReprogramadoPO { get; set; }
        public decimal PagoPO { get; set; }
        public decimal LiquidoRapPO { get; set; }
        public long QtdMetaAtualPO { get; set; }
        public long QtdMetaAtual { get; set; }
        public string RegionalizacaoExecucaoComentario { get; set; }
        public int NumQuestionario { get; set; }
        public string DescQuestionario { get; set; }
        public int NumPergunta { get; set; }
        public string DescPergunta { get; set; }
        public string DescTipoPergunta { get; set; }
        public string DescAdicionalPergunta { get; set; }
        public int NumResposta { get; set; }
        public string DescResposta { get; set; }
        public int NumPrioridadeResposta { get; set; }
        public string DescTextoResposta { get; set; }
    }
}
