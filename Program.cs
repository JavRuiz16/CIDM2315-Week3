
using System;
class Homework3 {
  static void Main() 
  {
    bool flag = true;
    Console.WriteLine("Input an integer: ");//Prompts user to enter an integer
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);//Converting input of string to integer type
    for(int i=2;i<number/2;i++)//For loop checking if int is a prime number
    {
        if(number%i==0)
        {
               flag = false;
               break;
        }
    }
    if(flag)//If true, then input is a prime number, else number is not a prime number
    {
        Console.WriteLine( input +" is Prime ");
    }
    else{
        Console.WriteLine(input+" is non-prime ");
    }
    
  }
}

// class HW3Part2 {
//   static void Main() {
//        Console.WriteLine("Assign an int value to N: ");
//         int n = int.Parse(Console.ReadLine());
        
//         for(int i = 0;i<n;i++){
            
//         for(int j =0;j<n;j++){
//             Console.Write("#");
//         }
//             Console.WriteLine();
//         }
//   }
// }

//  class HW3Part3{
// 	public static void Main() {
// 		// get N from user
// 		Console.WriteLine("Assign an int value to N:");
// 		int N=Convert.ToInt16(Console.ReadLine());
// 		for(int i=0;i<N;i++) {
// 			for(int j=0;j<N;j++) {
// 				if(i<j)
// 					Console.Write(" ");
// 				else
// 					Console.Write("*");
// 			}
// 			Console.Write("\n");
// 		}
// 	}
// }



// class HW3Bonus
// {
//   static void Main ()
//   {
//     int x, y, z, n;
//     //recieve value of n from the user
//     Console.WriteLine ("Assign an int value to N:");
//     n = Convert.ToInt32 (Console.ReadLine ());
//     //the first for loop starts with x=1 and ends at x<=n
//     for (x = 1; x <= n; x++) {
//         for (y = 0; y < n - x; y++) {
//             //prints empty spaces
//             Console.Write (" ");
// 	    }
// 	    for (z = 1; z <= x; z++) {
// 	        //prints the value of x
// 	        Console.Write (x);
// 	    }
// 	    //prints a new line
// 	    Console.WriteLine ();
        
//     }
      
//   }
// }