using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QonaqWebApp.Models.Entity
{
    public class Order : BaseEntity
    {
        [DisplayName("Say")]
        [Range(1, 20, ErrorMessage = "{0} {1} ilə {2} arasında olmalıdır")]
        public int Quantity { get; set; }
        public bool Sended { get; set; }
        public int CustomerId { get; set; }
        public string ProductId { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }

    }
}
