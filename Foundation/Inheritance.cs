using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Inheritance
    {
        public static void Execute()
        {
            //Animal animal = new Animal();
            //animal.Name = "Cat";
            Animal animal2 = new Animal("Cat", 17, false);
            animal2.Speak();

            Mammal humanM = new Mammal("Bob", 75, false, true, false);
            humanM.Speak();

            Animal humanA = new Mammal("Bobby", 30, true, true, false);
            humanA.Speak();

        }

        class Animal
        {
            private int LifeSpan;

            public string Name { get; set; }

            private bool IsNocturnal { get; }

            public Animal() { }

            public Animal(string name, int lifeSpan, bool isNocturnal = false)
            {
                Name = name;
                LifeSpan = lifeSpan;
                IsNocturnal = isNocturnal;
            }

            public void Speak()
            {
                Console.WriteLine(Name + " speaks (Animal class)");
            }
        }

        class Mammal : Animal
        {
            public bool IsCarnivore { get; set; }
            public bool LivesOnLand { get; set; }

            public Mammal (string name, int lifeSpan, bool isCarnivore, bool livesOnLand, bool isNocturnal = false) : base(name, lifeSpan, isNocturnal)
            {
                this.IsCarnivore = isCarnivore;
                this.LivesOnLand = livesOnLand;
            }

            public void Speak()
            {
                Console.WriteLine(Name + " speaks (Mammal class)");
            }
        }

        class Fish : Animal
        {
            public bool CanSpeak { get; set; }

            public Fish(string name, int lifeSpan, bool canSpeak, bool isNocturnal = false) : base(name, lifeSpan, isNocturnal)
            {
                this.CanSpeak = canSpeak;
            }

            public void Speak()
            {
                if(CanSpeak)
                {
                    Console.WriteLine(Name + " speaks (Fish class)");
                }
                else
                {
                    base.Speak();
                    Console.WriteLine(Name + " produces bubbles (Fish class)");
                }
            }
        }
    }
}
