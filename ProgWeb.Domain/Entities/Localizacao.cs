using System.ComponentModel.DataAnnotations;

namespace ProgWeb.Domain.Entities {
    public class Localizacao {
        [Key]
        public Guid IdULocalizacao { get; set; }
        public string IpAddress { get; set; }
        public string Location { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}