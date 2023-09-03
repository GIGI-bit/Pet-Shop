using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp06
{
    internal class User
    {
        public string Name { get; set; }
        private Cat[] _cat = null;
        private Dog[] _dog = null;
        private Fish[] _fish = null;
        private Bird[] _bird = null;

        public void ShowMyPets()
        {
            foreach (var item in _cat)
            {
                item.Show();
            }
            foreach (var item in _dog)
            {
                item.Show();
            }
            foreach (var item in _bird)
            {
                item.Show();
            }
            foreach (var item in _fish)
            {
                item.Show();
            }
        }

        public void Add(dynamic pet)
        {
            if(pet is Cat)
            {
                Cat[] newCat;
                if (_cat != null)
                {
                    newCat = new Cat[_cat.Length + 1];
                    int i = 0;
                    for (; i < _cat.Length; i++)
                    {
                        Array.Copy(_cat, i, newCat, 1, _cat.Length);
                        newCat[_cat.Length] = pet;
                        _cat = newCat;
                    }
                }

                else
                {
                    _cat = new Cat[1];
                    _cat[0] = pet;
                }
            }
            else if(pet is Dog)
            {
                Dog[] newDog;
                if (_cat != null)
                {
                    newDog = new Dog[_dog.Length + 1];
                    int i = 0;
                    for (; i < _dog.Length; i++)
                    {
                        Array.Copy(_dog, i, newDog, 1, _dog.Length);
                        newDog[_dog.Length] = pet;
                        _dog = newDog;
                    }
                }

                else
                {
                    _dog = new Dog[1];
                    _dog[0] = pet;
                }
            }
            else if(pet is Bird)
            {
                Bird[] newBird;
                if (_bird != null)
                {
                    newBird = new Bird[_bird.Length + 1];
                    int i = 0;
                    for (; i < _bird.Length; i++)
                    {
                        Array.Copy(_bird, i, newBird, 1, _bird.Length);
                        newBird[_bird.Length] = pet;
                        _bird = newBird;
                    }
                }
                else
                {
                    _bird = new Bird[1];
                    _bird[0] = pet;
                }
            }
            else if(pet is Fish)
            {
                Fish[] newFish;
                if (_fish != null)
                {
                    newFish = new Fish[_fish.Length + 1];
                    int i = 0;
                    for (; i < _fish.Length; i++)
                    {
                        Array.Copy(_fish, i, newFish, 1, _fish.Length);
                        newFish[_fish.Length] = pet;
                        _fish = newFish;
                    }
                }
                else
                {
                    _fish = new Fish[1];
                    _fish[0] = pet;
                }
            }



        }

    }
}
