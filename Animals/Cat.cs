using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Pet , Talkable
    {
        private int mousesKilled;
        

        public Cat(int mousesKilled, String name)
        {
            //super(name);
            this.mousesKilled = mousesKilled;
            base.name = name;
            
        }

        public int getMousesKilled()
        {
            return mousesKilled;
        }

        public void addMouse()
        {
            mousesKilled++;
        }

        public String talk()
        {
            return "Meow";
        }

        public String toString()
        {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }

        public string getName()
        {
            return toString();
        }
    }
}
