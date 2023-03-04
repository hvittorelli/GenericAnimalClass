using System;
using System.Security.Cryptography.X509Certificates;

namespace GenericAnimalClass
{
    public class Animal <T>
    {
        public T data;

        public Animal(T data) 
        {
            this.data = data;
        }

        public T getAnimal()
        {
            return data;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Goat");
            Animal<string> animalHabitat = new Animal<string>("Mountain Ranges");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(18);

            Console.WriteLine($"Animal Name: {animalName.getAnimal()}");
            Console.WriteLine($"Animal Habitat: {animalHabitat.getAnimal()}");
            Console.WriteLine($"Is a {animalName.getAnimal()} endangered? {endangered.getAnimal()}");
            Console.WriteLine($"Is a {animalName.getAnimal()} extinct? {extinct.getAnimal()}");
            Console.WriteLine($"What is the average life span of a {animalName.getAnimal()}? {averageLifespan.getAnimal()} years");

        }
    }
}