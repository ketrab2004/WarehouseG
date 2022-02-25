using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseG.Domain.Entities
{
    public class CommunicationEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CommunicationEntity()
        {
            // uhhh...
        }

        /// <summary>
        /// Id of communication
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Street of house/building
        /// </summary>
        public string Street { get; set; }


        /// <summary>
        /// Street number of house/building
        /// </summary>
        public int Number { get; set; }


        /// <summary>
        /// Street number extension of house/building
        /// <br />
        /// Nullable for Communications with no extension
        /// </summary>
        public string? NumberExtension { get; set; }


        /// <summary>
        /// Zipcode of house/building
        /// </summary>
        public string ZipCode { get; set; }


        /// <summary>
        /// Place of the house/building
        /// </summary>
        public string Place { get; set; }


        /// <summary>
        /// The province where the house/building lies
        /// </summary>
        public string Province { get; set; }


        /// <summary>
        /// Phonenumber of the communication
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// The phonenumber of the mobile phone of the communication
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// The fax number
        /// <br />
        /// Nullable because not everybody has a fax machine anymore
        /// </summary>
        public string? Fax { get; set; }

        /// <summary>
        /// The email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Their website
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// The type of address for their house/building
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Internal Communication key id
        /// </summary>
        public Guid Communicationkey { get; set; }

        /// <summary>
        /// Description of this Communication
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Whether this communication is active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Creation date of Communication
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Modification date of Communication
        /// </summary>
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Expiration date of Communication
        /// </summary>
        public DateTime DateExpired { get; set; }

        /// <summary>
        /// Modification number of database table record
        /// </summary>
        public byte[] Timestamp { get; set; }

        /// <summary>
        /// List of customers which belong to Communication.
        /// </summary>
        //public ICollection<CustomerCommunicationEntity> CustomerCommunicationList { get; set; }

        /// <summary>
        /// List of Shippers which belong to Communication.
        /// </summary>
        //public ICollection<ShipperCommunicationEntity> ShipperCommunicationList { get; set; }
    }
}
