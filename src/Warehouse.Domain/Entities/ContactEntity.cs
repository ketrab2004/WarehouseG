namespace Warehouse.Domain.Entities
{
    /// <summary>
    /// Contact entity.
    /// </summary>
    public class ContactEntity
    {
        /// <summary>
        /// Constructor of Contact entity.
        /// </summary>
        public ContactEntity()
        {
            CustomerContactList = new HashSet<CustomerContactEntity>();
            //ShipperContactList  = new HashSet<ShipperContactEntity>();
        }

        /// <summary>
        /// Contact id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The street name of house or building.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The street number of house or building.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The street number extension of house or building.
        /// </summary>
        public string NumberExtension { get; set; }

        /// <summary>
        /// The street zipCode of house or building.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// The street place of house or building.
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// The province city of house or building.
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The mobile number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The website url.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// The address type of house or building.
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Internal key id of Contact. 
        /// </summary>
        public Guid Contactkey { get; set; }

        /// <summary>
        /// Contact description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicated wether the Contact is used.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Creation date of Contact.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Modification date of Contact.
        /// </summary>
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Expiration date of Contact.
        /// </summary>
        public DateTime DateExpired { get; set; }

        /// <summary>
        /// Modification number of database table record.
        /// </summary>
        public byte[] Timestamp { get; set; }

        /// <summary>
        /// Contact key
        /// </summary>
        public Guid ContactKey { get; set; }

        /// <summary>
        /// List of customer which belong to Contact.
        /// </summary>
        public ICollection<CustomerContactEntity> CustomerContactList { get; set; }

        /// <summary>
        /// List of Shipper which belong to Contact.
        /// </summary>
        //public ICollection<ShipperContactEntity> ShipperContactList { get; set; }
    }
}
