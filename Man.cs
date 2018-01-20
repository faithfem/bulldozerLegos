using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien("Purple");
            alien.color();

            Console.WriteLine("Alien is " + alien.color);
        }
    }

    //moves and color are common amongst man, kart & alien
    public class GeneralObject //objectThatMovesSizeColor
    {
        //enter constructor (has same name as class)
        public GeneralObject() {
        }
        //give constructor the common properties ur objects have
        //then delete those properties from the objects
        public bool moves { get; set; }
        public string color { get; set; }
    }

    public class Human: GeneralObject
    {
        public Human(){
        }
            public string name { get; set; }
    }

    public class Man: Human //inherit from human as human also inherits from generalobject
    {
        public Man()
        {
        }
        //public bool moves { get; set; } //moves & color common denominator
        //public string name { get; set; } //exists under woman, so create new inheritance class called human so as not to repeat code
        //public string color { get; set; } //moves & color common denominator
    }

    public class Woman : Human
    {
        public Woman()//this is the constructor. See it's in every object
        {
        }
        //public bool moves { get; set; } //moves & color common denominator
        //public string name { get; set; }
        //public string color { get; set; } //moves & color common denominator
    }

    public class Kart: GeneralObject
    {
        public Kart() {
        }
        //public bool moves { get; set; } after constructor is created, removed all moves & color properties from all objects
        public string manufacturer { get; set; }
        //public string color { get; set; }
    }

    public class Alien: GeneralObject
    {
        public Alien() {
        }

        //public bool moves { get; set; }
        public string planet { get; set; }
        //public string color { get; set; }
    }
}

