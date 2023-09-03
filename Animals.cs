using System;

namespace ConsoleApp2
{
    internal class Cat : Pet
    {
        public Cat(string name, string gender, int age, int price)
            : base(name, gender, age, price)
        { }

        public Cat() { }

        public override void Eat()
        {
            MealQuantity++;
            if (MealQuantity >= 5)//pisikler 5 defe yedikden sonra buyuyurler
            {
                MealQuantity = 0;
                Age += 1;
            }

        }

        public override void Play()
        {
            if (Energy == 0)
            {
                Console.WriteLine($"{Nickname} is tired. Feed your pet.");
                return;
            }

            Energy--;
        }

        public override void Sleep()
        {
            Energy++;
        }

        public void Show()
        {
            Console.WriteLine($"Nickname: {Nickname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");

        }

    }

    internal class Dog : Pet
    {
        public Dog(string name, string gender, int age, int price)
            : base(name, gender, age, price)
        { }

        public override void Eat()
        {
            MealQuantity++;
            if (MealQuantity >= 3)//itler 3 defe yedikden sonra buyuyurler
            {
                MealQuantity = 0;
                Age += 1;
            }

        }

        public override void Play()
        {
            if (Energy == 0)
            {
                Console.WriteLine($"{Nickname} is tired. Feed your pet.");
                return;
            }

            Energy -= 2;
        }

        public override void Sleep()
        {
            Energy++;
        }
        public void Show()
        {
            Console.WriteLine($"Nickname: {Nickname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");

        }
    }

    internal class Fish : Pet
    {

        public Fish(string name, string gender, int age, int price) :
            base(name, gender, age, price)
        { }

        public override void Eat()
        {
            MealQuantity++;
            if (MealQuantity >= 10)//baliqlar 10 defe yedikden sonra buyuyurler
            {
                MealQuantity = 0;
                Age += 1;
            }

        }

        public override void Play()
        {
            if (Energy == 0)
            {
                Console.WriteLine($"{Nickname} is tired. Feed your pet.");
                return;
            }

            Energy--;
        }

        public override void Sleep()
        {
            Energy++;
        }
        public void Show()
        {
            Console.WriteLine($"Nickname: {Nickname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");

        }

    }

    internal class Bird : Pet
    {
        public Bird(string name, string gender, int age, int price) : base(name, gender, age, price)
        {

        }

        public override void Eat()
        {
            MealQuantity++;
            if (MealQuantity >= 8)
            {
                MealQuantity = 0;
                Age++;
            }
        }

        public override void Play()
        {
            if (Energy == 0)
            {
                Console.WriteLine($"{Nickname} is tired. Feed your pet.");
                return;
            }

            Energy--;
        }

        public override void Sleep()
        {
            Energy++;
        }
        public void Show()
        {
            Console.WriteLine($"Nickname: {Nickname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");

        }
    }

}
