using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 2) Створіть клас «Веб-сайт». Необхідно зберігати у полях класу: назву сайту, шлях до сайту, опис сайту, ip-адресу сайту. Реалізуйте методи класу для введення даних, виведення даних. Реалізуйте доступ до окремих полів через методи класу. 

 */
namespace Propertise
{
    class WebSite
    {
        private string _name;
        private string _path;
        private string _ipres;
        private string _description;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }
        public string Ipres
        {
            get
            {
                return _ipres;
            }
            set
            {
                _ipres = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }
}
