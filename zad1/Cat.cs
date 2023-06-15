using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Cat
    {
        private string ves;
        public bool check=true;
        public bool Check ()
        {
            return check;
        }
        public string Ves
        {
            get
            {
                return ves;
            }
            set
            {
                bool OnlyDigits = true;
                foreach (var ch in value.ToString())
                {
                    if (ch == '.' || ch == ',')
                        continue;
                    if (!char.IsDigit(ch))
                    {
                        OnlyDigits = false;
                    }
                }

                if (OnlyDigits&&Convert.ToInt32(value)>0)
                {
                    ves = value;
                } else
                {
                    check = false;
                    Console.WriteLine($"{value} - неправильный вес!!!");
                }
            }
        }
        private string name; 
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    check = true;
                    name = value;
                } else
                {
                    check = false;
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public Cat (string CatName,string ves)
        {
            Name = CatName;
            Ves = ves;
        }
        public void Meow ()
        {
            if(check)
                Console.WriteLine($"{name} весит {ves} кг. и говорит: МЯЯЯЯУ!!!!");
        }
    }
}
