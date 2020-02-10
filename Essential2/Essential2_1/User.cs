using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2.Essential2_1
{
    class User
    {
        string login, name, surname;
        int age;
        public readonly DateTime date;

        public string Login
        {
            set { login = value; }
            get
            {
                if (login == null)
                {
                    return "The field is not filled";
                }
                return login;
            }
        }

        public string Name
        {
            set { name = value; }
            get
            {
                if (name == null)
                {
                    return "The field is not filled";
                }
                return name;
            }
        }

        public string Surname
        {
            set { surname = value; }
            get
            {
                if (surname == null)
                {
                    return "The field is not filled";
                }
                return surname;
            }
        }

        public int Age
        {
            set { age = value; }
            get
            {
                if (age <= 0)
                {
                    return 0;
                }
                return age;
            }
        }

        public User()
        {
            date = DateTime.Now;
        }

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            date = DateTime.Now;
        }
    }
}
