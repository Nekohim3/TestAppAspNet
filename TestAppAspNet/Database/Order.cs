using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAppAspNet
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        
        
        [Required(ErrorMessage = "Обязательно для заполнения")]
        public string SenderCity { get; set; }
        [Required(ErrorMessage = "Обязательно для заполнения")]
        public string SenderAddress { get; set; }
        [Required(ErrorMessage = "Обязательно для заполнения")]
        public string ReceiverCity { get; set; }
        [Required(ErrorMessage = "Обязательно для заполнения")]
        public string ReceiverAddress { get; set; }
        [Required(ErrorMessage = "Обязательно для заполнения")]
        public int Weight { get; set; }
        [Required(ErrorMessage = "Обязательно для заполнения")]
        public DateTime Date { get; set; }
    }
}