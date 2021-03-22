using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Pet , Talkable
    {
    private bool friendly;

    public Dog(bool friendly, String name)
    {
            base.name = name;
        this.friendly = friendly;
    }

        public string getName()
        {
            return toString();
        }

        public bool isFriendly()
    {
        return friendly;
    }

    
    public String talk()
    {
        return "Bark";
    }

    
    public String toString()
    {
        return "Dog: " + "name=" + name + " friendly=" + friendly;
    }


}
}
