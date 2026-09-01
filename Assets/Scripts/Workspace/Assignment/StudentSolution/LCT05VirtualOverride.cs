using UnityEngine;


namespace Assignment.StudentSolution.LCT05
{
    public class Animal
    {
        // 0. make MakeSound method to virtual method
        public virtual void MakeSound()
        {
            Debug.Log("Generic animal sound");
        }
    }

    public class Dog : Animal
    {
        // student code here ...
        // 1. declare overridden MakeSound() method
        public override void MakeSound()
        {
            Debug.Log("Woof!");
        }
        // student code ends ...
    }

    public class Cat : Animal
    {
        // student code here ...
        // 2. declare overridden MakeSound() method
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
        // student code ends ...    
    }



    public class LCT05VirtualOverride
    {
        public void Start()
        {
            // 3. create instance of Dog and call MakeSound()
            Animal myDog = new Dog();
            myDog.MakeSound();
            // 4. create instance of Cat and call MakeSound()
            Animal myCat = new Cat();
            myCat.MakeSound();
            // 5. create instance of Animal and call MakeSound()
            Animal myAnimal = new Animal();
            myAnimal.MakeSound();
        }
    }
}
