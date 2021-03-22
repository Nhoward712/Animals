using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Teacher : Person , Talkable
    {
    private int age;

        public Teacher(int age, String name)
        {
                base.name = name;
            this.age = age;
        }

        public int getAge()
        {
            return age;
        }

            public string getName()
            {
            return talk();
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        //@Override
        public String talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}
