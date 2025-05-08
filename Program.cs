using System;

namespace MyApp{
public class Program
{
     static void Main(string[] args)
    {
        // double resultat=Functions.Division(10, 3);
        // Console.WriteLine("Le resultat est: " + resultat);

        // double result=Functions.Div(10, 3);
        // Console.WriteLine("Le resultat est: " + result);

        // Dog test = new Dog();
        // Console.WriteLine(test);

        // Homme jean = new Homme(); 
        //  jean.Nom="Jean";
        //  jean.Manger();
        //  jean.Sauter();


         Personne hafiz = new Homme { Nom = "Hafiz" }; 
         Console.WriteLine(hafiz.Nom);
         hafiz.Manger();
         hafiz.Sauter();
        
    }

}
}
