using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace LojaWebEF.Models
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }

        [Required]
        public int IdProduto { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int Quantidade { get; set; }

        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        

    }
}