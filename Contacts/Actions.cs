using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class Actions
    {
        public void Run()
        {
            var resultUa = this.ContactSearch(LanguageSelector._uaLanguage);
            this.Show(resultUa);
            Console.WriteLine("=======");
            var resultEn = this.ContactSearch(LanguageSelector._enLanguage);
            this.Show(resultEn);            
            Console.WriteLine("=======");
            var resultNumber = this.ContactSearch("9");
            this.Show(resultNumber);
        }

        private List<Contact> ContactSearch(CultureInfo value)
        {
            var contactList = new CreatorContacts();
            var contacts = contactList.CreateContacts();
            var result = contacts
                .Where(x => x.Language == value.Name)
                .ToList();
            return result;
        }     

        private List<Contact> ContactSearch(string value)
        {
            var contactList = new CreatorContacts();
            var contacts = contactList.CreateContacts();
            var result = contacts
                .Where(x => x.Language == value)
                .ToList();
            return result;
        }

        private void Show(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
