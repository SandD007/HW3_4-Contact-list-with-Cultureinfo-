using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public static class LanguageSelector
    {
        public static readonly char[] _enAlpabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static readonly char[] _uaAlpabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ".ToCharArray();
        public static readonly CultureInfo _uaLanguage = new CultureInfo("ua-UA");
        public static readonly CultureInfo _enLanguage = new CultureInfo("en-US");

        public static string LangSelector(string vaule)
        {
            char[] name = vaule.ToUpper().ToCharArray();
            string result = null;
            int index = 0;
            if (char.IsDigit(name[0]))
            {
                result = name[0].ToString();
            }

            for (int i = 0; i < name.Length; i++)
            {
                for (int x = 0; x < _enAlpabet.Length; x++)
                {
                    if (name[i] == _enAlpabet[x])
                    {
                        index++;
                    }

                    if (index == name.Length)
                    {
                        result = _enLanguage.Name;
                        return result;
                    }
                }
            }

            index = 0;
            for (int i = 0; i < name.Length; i++)
            {
                for (int x = 0; x < _uaAlpabet.Length; x++)
                {
                    if (name[i] == _uaAlpabet[x])
                    {
                        index++;
                    }

                    if (index == name.Length)
                    {
                        result = _uaLanguage.Name;
                        return result;
                    }
                }
            }

            return result;
        }
    }
}
