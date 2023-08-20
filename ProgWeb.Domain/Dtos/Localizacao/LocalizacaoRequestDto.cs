namespace ProgWeb.Domain.Dtos.Localizacao
{
    public class LocalizacaoRequestDto
    {
        public string IpAddress { get; set; }
        public string Location { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
