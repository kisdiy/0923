using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4)  Створіть клас «Магазин». Необхідно зберігати у полях класу: назву магазину, адреса, опис профілю магазину, контактний телефон, email. Реалізуйте методи класу для введення даних, виведення даних. Реалізуйте доступ до окремих полів через методи класу. 


namespace Propertise
{
    class Magazine
    {
        private string _phone;
        private string _email;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adres { get; set; }
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value.Length == 10)
                    _phone = value;
                else throw new Exception("Не верная длина номера");

            }

        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains("@"))
                    _email = value;
                else throw new Exception("Не верный формат email");

            }

        }
    }
}
