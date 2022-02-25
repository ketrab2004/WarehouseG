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
        public string MobilePhone { get; set; }
    }
}
