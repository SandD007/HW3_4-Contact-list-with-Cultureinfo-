using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public sealed class Contact
    {
        public Contact(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
            this.Language = LanguageSelector._enLanguage.ToString();
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Language { get; set; }

        public override string ToString()
        {
            return $"{this.Language} {this.Name} {this.Phone}";
        }
    }
}
