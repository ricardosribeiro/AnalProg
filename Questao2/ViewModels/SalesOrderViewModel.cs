using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Questao2.ViewModels
{
    public class SalesOrderViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Preenchimento obrigatório")]
        [MaxLength(100,ErrorMessage ="Máximo 100 caracteres")]
        [MinLength(5, ErrorMessage ="Mínimo 05 caracteres")]
        [DisplayName("Título")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo 05 caracteres")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Valor")]
        public decimal Value { get; set; }

        [DisplayName("Id do Cliente")]
        public int UserId { get; set; }
        public virtual UserViewModel User { get; set; }
      
    }
}