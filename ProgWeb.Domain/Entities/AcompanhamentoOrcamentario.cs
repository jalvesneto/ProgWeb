using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgWeb.Domain.Entities
{
    public class AcompanhamentoOrcamentario
    {
        [Key]
        public long Id { get; set; }

        public string Exercicio { get; set; }
        public string TipoCaptacao { get; set; }

        public string CD_Esfera { get; set; }
        public string DescricaoEsfera { get; set; }

        public string CD_Orgao { get; set; }
        public string DescricaoOrgao { get; set; }

        public string CD_UnidadeOrcamentaria { get; set; }
        public string DescricaoUnidadeOrcamentaria { get; set; }

        public string CD_Funcao { get; set; }
        public string DescricaoFuncao { get; set; }

        public string CD_SubFuncao { get; set; }
        public string DescricaosubFuncao { get; set; }
        public string CD_Programa { get; set; }
        public string TituloPrograma { get; set; }

        public string CD_TipoPrograma { get; set; }
        public string TipoPrograma { get; set; }

        public string CD_Acao { get; set; }
        public string TituloAcao { get; set; }
        public string CD_Produto { get; set; }
        public string DescricaoProduto { get; set; }

        public string CD_UnidadeMedida { get; set; }
        public string DescricaoUnidademedida { get; set; }
        public string CD_Localizador { get; set; }
        public string descricaolocalizador { get; set; }
        public string LocalizadorPreenchimentoObrigatorio { get; set; }
        public string ElementosSemCaptacao { get; set; }
        public string QtdMetaLoa { get; set; }
        public string ProjetoLei { get; set; }
        public string DotacaoInicial { get; set; }
        public string Autorizado { get; set; }
        public string Empenhado { get; set; }
        public string Liquidado { get; set; }
        public string ReprogramadoFisico { get; set; }
        public string ReprogramadoFinanceiro { get; set; }
        public string RealizadoLoa { get; set; }
        public string Pago { get; set; }
        public string LiquidoRap { get; set; }
        public string RealizadoRap { get; set; }
        public string snRegionalizarNaExecucao { get; set; }
        public string RegionalizacaoExecucaoDescricao { get; set; }
        public string RegionalizacaoExecucaoSiglaUF { get; set; }
        public string RegionalizacaoExecucaoDescricaoMunicipio { get; set; }
        public string RegionalizacaoExecucaoDescricaoCorteGeorafico { get; set; }
        public string RegionalizacaoExecucaoLiquidado { get; set; }
        public string RegionalizacaoExecucaoRealizado { get; set; }
        public string CodigoPO { get; set; }
        public string TituloPO { get; set; }

        public string CD_ProdutoPO { get; set; }
        public string descricaoproduto_po { get; set; }
        public string CD_UnidadeMedidaPO { get; set; }
        public string descricaounidademedida_po { get; set; }
        public string MetaLoaPropostaPO { get; set; }
        public string DotacaoInicialPO { get; set; }
        public string AutorizadPO { get; set; }
        public string EmpenhadoPO { get; set; }
        public string LiquidadoPO { get; set; }
        public string RealizadoPO { get; set; }
        public string FisicoReprogramadoPO { get; set; }
        public string FinanceiroReprogramadoPO { get; set; }
        public string PagoPO { get; set; }
        public string LiquidoRapPO { get; set; }
        public string QtdMetaAtualPO { get; set; }
        public string QtdMetaAtual { get; set; }
        public string RegionalizacaoExecucaoComentario { get; set; }
        public string NumQuestionario { get; set; }
        public string DescQuestionario { get; set; }
        public string NumPergunta { get; set; }
        public string DescPergunta { get; set; }
        public string DescTipoPergunta { get; set; }
        public string DescAdicionalPergunta { get; set; }
        public string NumResposta { get; set; }
        public string DescResposta { get; set; }
        public string NumPrioridadeResposta { get; set; }
        public string DescTextoResposta { get; set; }
    }
}
