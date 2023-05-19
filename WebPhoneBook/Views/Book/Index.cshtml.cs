using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace WebPhoneBook.Views
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var json = System.IO.File.ReadAllText(@"People.json");
            Percons = JsonConvert.DeserializeObject<IList<PerconPhone>>(json);
            Console.WriteLine("какой нибудь текст, о том, что сработал метод OnGet");
        }

        private IList<PerconPhone> persons = new List<PerconPhone>();
        public IList<PerconPhone> Percons
        {
            get
            {
                return persons;
            }
            set { persons = value; }
        }

        public class PerconPhone
        {
            private int id;
            public int Id { get { return this.id; } set { this.id = value; } }

            private string name;
            /// <summary>
            /// Имя
            /// </summary>
            public string Name { get { return this.name; } set { this.name = value; } }

            private string lastname;
            /// <summary>
            /// Фамилия
            /// </summary>
            public string LastName { get { return this.lastname; } set { this.lastname = value; } }

            private string middlename;
            /// <summary>
            /// Отчество
            /// </summary>
            public string MiddleName { get { return this.middlename; } set { this.middlename = value; } }

            private string phonenumber;
            /// <summary>
            /// Номер телефона
            /// </summary>
            public string PhoneNumber { get { return this.phonenumber; } set { this.phonenumber = value; } }

            private string address;
            /// <summary>
            /// Адрес
            /// </summary>
            public string Address { get { return this.address; } set { this.address = value; } }

            private string description;
            /// <summary>
            /// Описание
            /// </summary>
            public string Description { get { return this.description; } set { this.description = value; } }

            [JsonConstructor]
            public PerconPhone(int Id, string Name, string LastName, string MiddleName, string PhoneNumber, string Address, string Description)
            {
                this.id = Id;
                this.name = Name;
                this.lastname = LastName;
                this.middlename = MiddleName;
                this.phonenumber = PhoneNumber;
                this.address = Address;
                this.description = Description;
            }
        }

       
    }
}