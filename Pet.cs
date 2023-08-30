using System;

namespace ConsoleApp2
{
    internal abstract class Pet
    {

        public Guid Id;

        private string nickname;
        private int age;
        private string gender;
        private int price;
        private int energy;
        protected int MealQuantity;

        public Pet(string name,string gender,int age,int price)
        {
            Nickname = name;
            Gender = gender;
            Age = age;
            Price = price;
            MealQuantity = 0;
        }

        public string Gender
        {
            get=>gender;
            set
            {
                if (value is not string)
                    throw new Exception("ValueIsNotString");
                if (value.CompareTo("Male") != 0 || value.CompareTo("Female") != 0)
                    throw new Exception("ValueDoesNotMatchDescription");
                gender = value;
            }
        }

        public int Energy
        {
            get => energy;
            protected set
            {
                if (!(value is int))
                    throw new Exception("ValueIsNotInt");
                if (value < 0)
                    throw new Exception("ValueIsLessThanZero");
                energy = value;
            }
        }

        public int Price
        {
            get => price;
            set
            {
                if(!(value is int))
                    throw new Exception("ValueIsNotInt");
                if(value<0)
                    throw new Exception("ValueIsLessThanZero");
                price = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (!(value is int))
                    throw new Exception("ValIsNotInt");
                if (value <= 0)
                    throw new Exception("ValueIsNotValid");
                age = value;
            }
        }

        public string Nickname
        {
            get => nickname;
            set
            {
                if (value is not string)
                    throw new Exception("ValueIsNotString");
                if (value == null)
                    throw new Exception("ValueIsNull");
                nickname = value;
            }
        }


        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play();



    }

    internal class PetShop 
    {
        public string _name { get; set; }
        private string _info;
        private Cat? _cat = null;
        private Dog? _dog = null;
        private Fish? _fish = null;
        private Bird? _bird = null;

        public PetShop(string name)
        {
            _name = name;
        }

        public string Info
        {
            get=>_info;
            set
            {
                if(value is not string)
                    throw new Exception("ValueIsNotString");
                if(value.Length<=0)
                    throw new Exception("ValueIsTooShort");
                _info = value;
            }
        }

        public void AddPet()
        {

        }
    }


}