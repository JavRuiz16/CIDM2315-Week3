
using System;
// class Homework3 {
//   static void Main() 
//   {
//     bool flag = true;
//     Console.WriteLine("Input an integer: ");//Prompt User to enter integer
//     string input = Console.ReadLine();
//     int number = Convert.ToInt32(input);//Converting input of string to integer type
//     for(int i=2;i<number/2;i++)//For loop for checking prime number
//     {
//         if(number%i==0)
//         {
//                flag = false;
//                break;
//         }
//     }
//     if(flag)//If flag is true then input is prime else number is non-prime
//     {
//         Console.WriteLine( input +" is Prime ");
//     }
//     else{
//         Console.WriteLine(input+" is non-prime ");
//     }
    
//   }
// }

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

//     class HW3Part3{
// 	public static void Main() {
// 		// get N from user
// 		Console.WriteLine("Assign an int value to N:");
// 		int N=Convert.ToInt16(Console.ReadLine());
// 		// i will run from 0 to N-1, i represent row number
// 		for(int i=0;i<N;i++) {
// 			// j will run from 0 to N-1, j represent column number
// 			for(int j=0;j<N;j++) {
// 				// if row number is less than column number print space else print *
// 				if(i<j)
// 					Console.Write(" ");
// 				else
// 					Console.Write("*");

// 			}
// 			Console.Write("\n");
// 		}
// 	}
// }



class HW3Bonus
{
  static void Main ()
  {
    int x, y, z, n;
    //get value of n from the user
    Console.WriteLine ("Assign an int value to N:");
    n = Convert.ToInt32 (Console.ReadLine ());
    //the first for loop starts with x=1 and ends at x<=n
    for (x = 1; x <= n; x++) {
        //second for loop starts with y=0 and ends at y=n-x-1
        for (y = 0; y < n - x; y++) {
            //print empty spaces
            Console.Write (" ");
	    }
	    for (z = 1; z <= x; z++) {
	        //print the value of x
	        Console.Write (x);
	    }
	    //print new line
	    Console.WriteLine ();
        
    }
      
  }
}