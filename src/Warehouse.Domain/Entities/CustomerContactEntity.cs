namespace Warehouse.Domain.Entities
{
    /// <summary>
    /// Entity for the connection table between the Customer and Contact
    /// </summary>
    public class CustomerContactEntity
    {
        public CustomerContactEntity() { }

        public int Id { get; set; }

        /// <summary>
        /// Foreign Key
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Foreign Key
        /// </summary>
        public int ContactId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public byte[] Timestamp { get; set; }

        public ContactEntity Contact { get; set; }
    }
}
