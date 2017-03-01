using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet // declaring properties for virtual pet class
    {
        public string petName;
        public int petAge;
        public string skinType;

        public VirtualPet (string petName)
        {
            this.petName = petName;
        }

        public VirtualPet (string petName, int petAge)
        {
            this.petName = petName;
            this.petAge = petAge;
        }

        public VirtualPet (string petName, int petAge, string skinType)
        {
            this.petName = petName;
            this.petAge = petAge;
            this.skinType = skinType;
        }

        public VirtualPet()
        {

        }

        public string GetPetName()
        {
            return this.petName;
        }

        public void Speak() // declaring methods to interact with pet
        {
            Console.WriteLine(petName + " says Hello!");

        }

        public void Eat()
        {
            Console.WriteLine(this.petName + " is eating their food!");
        }

        public void Play()
        {
            Console.WriteLine(this.petName + " is having a roll around in the yard!");

        }

        public string Name // Declaring properties for VirtualPet class
        {
            get { return Name; } // Get method for returning value
            set { Name = value; } // Set method for storing value in the Name field
        }

        internal void Speak(string v)
        {
            throw new NotImplementedException();
        }

        public string Color
        {
            get { return Color; } // Get method for returning value
            set { Color = value; } // Set method for storing value in the Color field
        }

        public int Age
        {
            get { return Age; } // Get method for returning value
            set { Age = value; } // Set method for storing value in the Age field
        }
    }




}



  


        

   
    
