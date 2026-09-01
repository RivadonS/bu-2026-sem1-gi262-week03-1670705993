using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car //Blueprint
    {
        //Field
        public string Name;
        public float Speed;
        public string Color;

        public void Move()
        {
            Debug.Log("Car is Moving");
        }

        public void Turn()
        {
            Debug.Log("Car is Turning");
        }

        public void Honk()
        {
            Debug.Log("Car is Honking");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...
            Car car = new Car();// New object
            //Car car2 = new();

            car.Name = "Honda";
            car.Speed = 80;
            car.Color = "Black";

            car.Move();
            car.Turn();
            car.Honk();
            // Student code ends HERE 
        }
    }
}
