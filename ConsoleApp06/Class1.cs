using System;
using System.Reflection.Metadata;
using ConsoleApp2;
using ConsoleApp06;

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

        public Pet() { }

        public Pet(string name, string gender, int age, int price)
        {
            Nickname = name;
            Gender = gender;
            Age = age;
            Price = price;
            MealQuantity = 0;
        }

        public string Gender
        {
            get => gender;
            set
            {
                if (value is not string)
                    throw new Exception("ValueIsNotString");
                //if (value.CompareTo("Male") != 0 || value.CompareTo("Female") != 0)
                //    throw new Exception("ValueDoesNotMatchDescription");
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
                if (!(value is int))
                    throw new Exception("ValueIsNotInt");
                if (value < 0)
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
        private Cat[] _cat = null;
        private Dog[] _dog = null;
        private Fish[] _fish = null;
        private Bird[] _bird = null;

        public PetShop(string name)
        {
            _name = name;
        }

        public string Info
        {
            get => _info;
            set
            {
                if (value is not string)
                    throw new Exception("ValueIsNotString");
                if (value.Length <= 0)
                    throw new Exception("ValueIsTooShort");
                _info = value;
            }
        }

        public void AllPets()
        {
            if (_cat!=null) {
                foreach (var item in _cat)
                {
                    item.Show();
                    Console.WriteLine(item.Price);
                }
            }
            if (_dog != null) {
                foreach (var item in _dog)
                {
                    item.Show();
                    Console.WriteLine(item.Price);
                }
            }
            if (_bird != null) {
                foreach (var item in _bird)
                {
                    item.Show();
                    Console.WriteLine(item.Price);
                }
            }
            if (_fish != null) {
                foreach (var item in _fish)
                {
                    item.Show();
                    Console.WriteLine(item.Price);
                }
            }
            if(_cat==null&&_dog==null&&_fish==null&&_bird==null) Console.WriteLine("Nothing to display");
        }

        public void AddPet()
        {
            int index = Program.makeMenu(4, "Cat", "Dog", "Bird", "Fish");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            if (index == 0)
            {
                Cat cat = new Cat(name, gender, age, price);
                Cat[] newCat;
                if (_cat != null)
                {
                    newCat = new Cat[_cat.Length + 1];
                    int i = 0;
                    for (; i < _cat.Length; i++)
                    {
                        Array.Copy(_cat, i, newCat, 1, _cat.Length);
                        newCat[_cat.Length] = cat;
                        _cat = newCat;
                    }
                }

                else
                {
                    _cat = new Cat[1];
                    _cat[0] = cat;
                }
               
            }
            else if (index == 1)
            {
                Dog dog = new Dog(name, gender, age, price);
                Dog[] newDog;
                if (_cat != null)
                {
                    newDog = new Dog[_dog.Length + 1];
                    int i = 0;
                    for (; i < _dog.Length; i++)
                    {
                        Array.Copy(_dog, i, newDog, 1, _dog.Length);
                        newDog[_dog.Length] = dog;
                        _dog = newDog;
                    }
                }

                else
                {
                    _dog = new Dog[1];
                    _dog[0] = dog;
                }
            }
            else if (index == 2)
            {
                Bird bird = new Bird(name, gender, age, price);
                Bird[] newBird;
                if (_bird != null)
                {
                    newBird = new Bird[_bird.Length + 1];
                    int i = 0;
                    for (; i < _bird.Length; i++)
                    {
                        Array.Copy(_bird, i, newBird, 1, _bird.Length);
                        newBird[_bird.Length] = bird;
                        _bird = newBird;
                    }
                }
                else
                {
                    _bird = new Bird[1];
                    _bird[0] = bird;
                }
            }
            else if (index == 3)
            {
                Fish fish = new Fish(name, gender, age, price);
                Fish[] newFish;
                if (_fish != null)
                {
                    newFish = new Fish[_fish.Length + 1];
                    int i = 0;
                    for (; i < _fish.Length; i++)
                    {
                        Array.Copy(_fish, i, newFish, 1, _fish.Length);
                        newFish[_fish.Length] = fish;
                        _fish = newFish;
                    }
                }
                else
                {
                    _fish = new Fish[1];
                    _fish[0] = fish;
                }
            }




        }
        public void Buy(Guid id, User user)
        {
            dynamic pet = findById(id);
            user.Add(pet);
            if(pet is Cat)
            {
                if (_cat != null)
                {
                    for (int i = 0; i < _cat.Length; i++)
                    {
                        if (pet.Id == _cat[i].Id)
                        {
                            _cat[i] = null;
                        }
                    }
                }
            }
            else if(pet is Dog)
            {
                if (_dog != null)
                {
                    for (int i = 0; i < _dog.Length; i++)
                    {
                        if (pet.Id == _dog[i].Id)
                        {
                            _dog[i] = null;
                        }
                    }
                }
            }
            else if(pet is Bird)
            {
                if (_bird != null)
                {
                    for (int i = 0; i < _bird.Length; i++)
                    {
                        if (pet.Id == _bird[i].Id)
                        {
                            _bird[i] = null;
                        }
                    }
                }
            }
            else if(pet is Fish)
            {
                if (_fish != null)
                {
                    for (int i = 0; i < _fish.Length; i++)
                    {
                        if (pet.Id == _fish[i].Id)
                        {
                            _fish[i] = null;
                        }
                    }
                }
            }



        }

        public dynamic findById(Guid id)
        {
            for (int i = 0; i < _cat.Length; i++)
            {
                if (id == _cat[i].Id) return _cat[i];
            }
            for (int i = 0; i < _dog.Length; i++)
            {
                if (id == _dog[i].Id) return _dog[i];
            }
            for (int i = 0; i < _fish.Length; i++)
            {
                if (id == _fish[i].Id) return _fish[i];
            }
            for (int i = 0; i < _bird.Length; i++)
            {
                if (id == _bird[i].Id) return _bird[i];
            }
            return null;
        }


    }

   




}