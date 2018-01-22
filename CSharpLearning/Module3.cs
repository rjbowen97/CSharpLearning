using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    class Module3
    {

        public class y
        {
            public void x()
            {
                var animal = new Animal();
                var dog = new Dog();
                var poodle = new Poodle();

                TakeAnimal(animal);
            }
            public void TakeAnimal(Animal a)
            {
                a.Temp = 10;
                //var dog = (Dog)a;
                var dog = a as Dog;

                if (dog is Dog)
                    dog.Name = "Daren";

            }
        }

        public class Animal { public int Temp { get; set; } }
        public class Dog : Animal { public string Name { get; set; }}
        public class Poodle : Dog { public string Groomer { get; set; }}

    }
}
