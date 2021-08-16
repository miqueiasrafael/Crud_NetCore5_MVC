using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppOficial.Models
{
    public class Usuario
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        [StringLength(100)]
        public virtual string Nome { get; set; }
        [Required(ErrorMessage = "Favor informe um e-mail")]
        [StringLength(250)]
        public virtual string Email { get; set; }
        [Required]
        [StringLength(200)]
        public virtual string Login { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Senha")]
        public virtual string Hash { get; set; }
       
        [StringLength(60)]
        public virtual string Salt { get; set; }
       
        public virtual string Foto { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data hora")]
        public virtual DateTime DataCadastro { get; set; }
    }
}
