namespace Warehouse.Application.Models.CustomerContactModel
{
    public class CustomerContactListView
    {
        public IEnumerable<CustomerContactView>? CustomerContacts { get; set; }

        /// <summary>
        /// Whether or not the list has been created
        /// </summary>
        public bool CreateEnabled { get; set; }
    }
}
