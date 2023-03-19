using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class CreatorContacts
    {
        public List<Contact> CreateContacts()
        {
            List<Contact> result = new List<Contact>();
            var list = this.GenerateContact();

            foreach (var contact in list)
            {
                string key = LanguageSelector.LangSelector(contact.Name);
                var a = list
                    .Where(x => x.Name == contact.Name)
                    .Select(x => x.Language = key)
                    .ToList();
            }

            return list;
        }

        private List<Contact> GenerateContact()
        {
            var list = new List<Contact>();
            list.AddRange(
                new[]
                {
                new Contact("Jon", "111-111-111"),
                new Contact("Josh", "222-222-222"),
                new Contact("9Josh", "222-222-122"),
                new Contact("Dasha", "333-333-333"),
                new Contact("Джамал", "444-444-444"),
                new Contact("Валентин", "555-555-555"),
                new Contact("Саша", "666-666-666"),
                new Contact("0Саша", "666-666-676"),
                new Contact("Andry", "777-777-777"),
                new Contact("Андрій", "888-888-888"),
                });
            return list;
        }
    }
}
