using System.ComponentModel.DataAnnotations;

namespace Warehouse.Application.Models.CustomerContactModel
{
    public class CustomerContactView
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int ContactId { get; set; }

        public Guid CustomerContactKey { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedCreated { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedModified { get; set; }
    }
}
