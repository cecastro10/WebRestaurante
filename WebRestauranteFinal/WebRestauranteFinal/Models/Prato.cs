using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebRestauranteFinal
{
    [Table("Tb_Prato")]
    public class Prato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Nome do prato não pode ser branco.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O valor de ser informado.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe o restaurante.")]
        public int RestauranteID { get; set; }

        //[Required(ErrorMessage = "Informe a data de cadastro")]
        //public DateTime datacadastro { get; set; }

        [ForeignKey("RestauranteID")]
        public virtual Restaurante Restaurante { get; set; }
    }
}
