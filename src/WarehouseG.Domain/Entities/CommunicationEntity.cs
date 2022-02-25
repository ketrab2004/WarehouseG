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
        /// Nullable for communications with no extension
        /// </summary>
        public string? NumberExtension { get; set; }


        /// <summary>
        /// Zipcode of house/building
        /// </summary>
        public string ZipCode { get; set; }
    }
}
