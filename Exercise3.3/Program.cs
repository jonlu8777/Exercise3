namespace Exercise3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ImplementeraTalk()som skriver ut vadWolfmansäger.
            //.F:Om vi under utvecklingen kommer fram till att samtligafåglar behöver ett nyttattribut, i vilken klass bör vi lägga det?
            // F: SVAR: i Klassen Bird!  

            //14.F:Om alla djur behöver det nya attributet, vart skulleman lägga det då?
            //F: SVAR: i Animal! 
            Wolfman wolfman = new Wolfman(true,true,"wolfman", 200, 10);
            IPerson iwolfman = new Wolfman(true,true, "iwolfman",200,10);
           // iwolfman.Talk();
           // wolfman.Talk();

            Flamingo flamingo = new Flamingo(true, 120, "Flamingo", 100, 100);
            Swan swan = new Swan(true, 100, "Swan", 100, 10);
            Pelican pelican = new Pelican(true, 80, "Pelican", 90, 90);
            Dog dog = new Dog(true, "Dog", 10, 10);
            Dog dog2 = new Dog(true, "Dog2", 20, 20);
            Wolf wolf = new Wolf(true, "Wolf", 10, 10);
            Worm worm = new Worm(true, "Worm", 10, 10);
            Horse horse = new Horse("Horse", 600, 10, "eatscarrots");
            Hedgehog hedgehog = new Hedgehog(true, "Hedge", 10, 8);
            Bird bird = new Bird(100, "Bird", 22, 2);


            List<Animal> animalList = new List<Animal>();
            
            animalList.Add(wolfman);
            animalList.Add(swan);
            animalList.Add(pelican);
            animalList.Add(flamingo);
            animalList.Add(dog);
            animalList.Add(dog2);
            animalList.Add(worm);
            animalList.Add(wolf);
            animalList.Add(horse);
            animalList.Add(hedgehog);
            animalList.Add(bird);


            //PrintAnimalListWithIPersonTalks(animalList); // Exercise 3.4.7. type-Cast IPerson och kör IPerson.Talk() 

            // ForeachDogListNoHorse(); // Exercise 3.4.9

            // F: Försök att lägga till en häst i listan av hundar.Varför fungerar inte det?
            // Svar: För att en Häst och Hund har olika attribut! 
            //10.F:Vilken typ måste listan vara för att alla klasserskall kunna lagras tillsammans?
            // SVAR: Animal! 

            //Skriv ut samtliga Animal Stats()

            // ForeachAllAnimalStats(animalList);

            //Förklara: Alla intasierade objekt i List<Animal> animalList ärver från basklassen Animal.
            // Även wolfman:wolf då wolf:animal. Kan alla objekt behandlas som Animal.   

            //ForeachOnlyDogs(animalList); //Enbart Print Hundar
                                         //För att skriva ut  public string Dog.AgeStringDog(); behöver vi casta om animal till Dog,
                                         //För att metoden finns inte i Animal classen.  



        }

        private static void ForeachOnlyDogs(List<Animal> animalList)
        {
            foreach (Animal animal in animalList)
            {
                if (animal is Dog)
                {  
                    Console.WriteLine(animal.Stats());
                    Dog dogg = animal as Dog;
                    Console.WriteLine(dogg.AgeStringDog());
                }
            }

        }

        private static void ForeachAllAnimalStats(List<Animal> animalList)
        {
            foreach(Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
                Console.WriteLine();
            }
            
        }

        private static void ForeachDogListNoHorse()
        {
            Dog dog1 = new Dog(true,"dog1",10,10);
            Dog dog2 = new Dog(true,"dog2",20,20);
            Dog dog3 = new Dog(true,"dog3",30,30);
            Horse horse1 = new Horse("Horse", 600, 4, "carrotsPlease");
            //dogList.Add(horse1);
            
            List<Dog> dogList = new List<Dog>() {  };
            
            dogList.Add(dog1); 
            dogList.Add(dog2); 
            dogList.Add(dog3);

            foreach (Animal hund in dogList)
            {
                Console.WriteLine(hund.Stats()); 

            }

        }

        private static void PrintAnimalListWithIPersonTalks(List<Animal> animalList)
        {
            
            foreach (Animal animal in animalList)
            {
                if(animal is IPerson)           
                { 
                    IPerson iP = animal as IPerson;  
                     iP.Talk();   
                }
               animal.DoSound();
               Console.WriteLine(animal.Stats());
               Console.WriteLine();                                 
             }
        }
    }
}