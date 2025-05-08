
using System.Diagnostics;

public interface IAnimal
{
  public void Makesound();
}


public class Animal
{
   public  void MakeSound()
   {
       Console.WriteLine("Hello world");
   }
   
}

public class Dog : Animal
{
    public  void Makesound(){
     Console.WriteLine("Wow");
   }
}


public abstract class Personne {
     public required string Nom;

     public virtual  void Manger(){
        Console.WriteLine("Je mange ");
     }

     public abstract void Sauter();
}

public  class Homme : Personne
{
     public override void Sauter()
     {
        Console.WriteLine("A pied join");
     }

        public override  void Manger(){
        Console.WriteLine("Je graille");
     }

}
