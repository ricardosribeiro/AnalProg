using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Questao2.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo 05 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo 14 caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo 12 caracteres")]
        public string CPF { get; set; }

        public ICollection<SalesOrderViewModel> SalesOrders { get; set; }
    }
}