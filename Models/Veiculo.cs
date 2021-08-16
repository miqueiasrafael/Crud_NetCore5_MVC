using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppOficial.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor informe o modelo")]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Favor informe o ano de fabricação")]
        [DataType(DataType.Date)]
        [Display(Name = "Ano de fabricação")]
        public DateTime AnoFabricacao { get; set; }
       
        [Required(ErrorMessage = "Favor informe o ano do modelo")]
        [DataType(DataType.Date)]
        [Display(Name = "Ano do modelo")]
        public DateTime AnoModelo { get; set; }

        [Required]
        public string Foto { get; set; }
    }
}
