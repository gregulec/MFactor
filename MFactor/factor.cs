using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFactor
{
    abstract class Pizza {

            protected String about;

            public abstract Pizza doPizza();
            
            protected void addBase(){
		        Console.WriteLine("Robiê cisto...");
	        }
        }

    class Margherita : Pizza {
	        public Margherita(){
		        about = "Margherita";
	        }

	        public void addSauce(){
		        Console.WriteLine("Dodaje sos pomidorowy...");
	        }
        	
	        public void addCheese(){
		        Console.WriteLine("Dodaje ser...");
	        }
        	
	        public override Pizza doPizza(){
		        Console.WriteLine(about);
		        addBase();
		        addSauce();
		        addCheese();
                Console.WriteLine("Gotowe!");
            return this;
	        }
    }

    class Capricciosa : Margherita{
	        public Capricciosa(){
		        about = "Capricciosa";
	        }

	        public void addMushrooms(){
                Console.WriteLine("Dodaje pieczarki...");
	        }
        	
	        public void addHam(){
                Console.WriteLine("Dodaje szykê...");
	        }
        	
	        public override Pizza doPizza(){
                Console.WriteLine(about);
                addBase();
                addSauce();
		        addHam();
		        addMushrooms();
		        addCheese();
                Console.WriteLine("Gotowe!");
            return this;
	        }
    }

    class Pepperoni : Margherita {
	        public Pepperoni(){
		        about = "Peperoni";
	        }
        	
	        public void addPepperoni(){
                Console.WriteLine("Dodaje pepperoni...");
	        }
        	
	        public override Pizza doPizza(){
                Console.WriteLine(about);
		        addBase();
		        addSauce();
                addPepperoni();
                addCheese();
                Console.WriteLine("Gotowe!");
            return this;
	        }
    }

    class ManufacturerPizza
    {
            public Pizza producePizza(String about)
            {
                Pizza pizza = null;

                if (about.Equals("Margherita"))
                {
                    pizza = new Margherita();
                }
                else if (about.Equals("Capricciosa"))
                {
                    pizza = new Capricciosa();
                }
                else if (about.Equals("Pepperoni"))
                {
                    pizza = new Pepperoni();
                }
                return pizza.doPizza();
            }
    }
}
