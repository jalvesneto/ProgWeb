using System.ComponentModel.DataAnnotations;

namespace ProgWeb.Domain.Entities {
    public class Localizacao {
        [Key]
        public Guid IdULocalizacao { get; set; }
        public string IpAddress { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}