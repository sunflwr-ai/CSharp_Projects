using System ;
public class Pattern{
        for(int i = 1 ; i<=4 ; i++){
            for(int j = 1 ; j<=4 ; j++){
                if(j<=5-i){
                    Console.Write("*");
                    else{
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
        }
    }
