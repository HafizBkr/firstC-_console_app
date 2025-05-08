public class Functions{
    public static int Addition (int a, int b){
        return a + b;
    }   
    public static double Division (int a, int b){
        if(b<=0){
            Console.WriteLine("Division par zero impossible");
            return 0;
         }
         else{
            return (double)a / b;
         }
    }
      public static double Div (int a, int b){
        if(b==0)return 0;
        return a/b;
    
    }

    private static int Soustraction (int a, int b){
        return a - b;
    }
}