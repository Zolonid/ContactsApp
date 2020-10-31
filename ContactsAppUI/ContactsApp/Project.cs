using System.Collections.Generic;

namespace ContactsApp
{
    /// <summary>
    /// Wrapper class for contacts
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Holds existing contacts
        /// </summary>
        public List<Contact> ContactList;

        /// <summary>
        /// Default contructor with no parameters
        /// </summary>
        public Project()
        {
            ContactList = new List<Contact>(200);
        }
    }
}
