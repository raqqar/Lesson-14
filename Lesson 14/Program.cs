using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    //Разработать абстрактный класс Animal, который описывает животное.Класс содержит следующие элементы:
    //      абстрактное свойство - название животного.
    //В классе Animal нужно определить следующие методы:
    //      конструктор, устанавливающий значение по умолчанию для названия;
    //      абстрактный метод Say(), который выводит звук, который издает животное;
    //      неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).
    //Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.В классах реализовать следующие элементы:
    //      свойство – название животного;
    //      метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
    //Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кот","Мяу");
            cat.ShowInfo();

            Dog dog = new Dog("Пёс", "Гав");
            dog.ShowInfo();
            Console.ReadKey();
        }
        

        
        
        
    }
    abstract class Animal
    {
        public abstract string TitleAnimal { get; set; }
        public Animal(string title)
        {
            TitleAnimal = title;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(TitleAnimal);
            Say();
        }


    }
    class Cat : Animal
    {
        public string Sound { get; set; }
        public override string TitleAnimal { get; set; }
        public Cat(string TitleAnimal, string sound)
            : base(TitleAnimal)
        {
            Sound = sound;
        }
        public override void Say()
        {
            Console.WriteLine(Sound);
        }
    }
    class Dog : Animal
    {
        public string Sound { get; set; }
        public override string TitleAnimal { get; set; }
        public Dog(string TitleAnimal, string sound)
            : base(TitleAnimal)
        {
            Sound = sound;
        }
        public override void Say()
        {
            Console.WriteLine(Sound);
        }
    }

}
