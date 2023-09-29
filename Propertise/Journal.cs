using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3) Створіть клас «Журнал». Необхідно зберігати у полях класу: назву журналу, рік заснування, опис журналу, контактний телефон, email. Реалізуйте методи класу для введення даних, виведення даних. Реалізуйте доступ до окремих полів через методи класу.

namespace Propertise
{
    class Journal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public int Year { get; set; }

    }
}
