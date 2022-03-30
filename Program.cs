using System;


//dotnet run
class Program {
  public static void Main (string[] args) {
  // data types
    
  // Console.WriteLine ("Hello World");
  //   string name = "hamburger";
  //   Console.WriteLine(name);
  //   //int num = 15;
  //   long bignum = 11111;
  //   float floatnum = 22 / 7f;
  //   double mediumPreciseFloat = 22.0 / 7.0; // gotta put decimals in for doubles
  //   decimal preciseFloat = 22 / 7m;
  //   Console.WriteLine($"DATATYPES TEST | float: {floatnum} | double: {mediumPreciseFloat}, decimal: {preciseFloat}");

  //   // if statements

  //   int num = 5;
    
  //   if (num > 5) {
  //     Console.WriteLine("Number is greater than 5");
  //   } else if (num == 5) {
  //     Console.WriteLine("Number is 5");
  //   } else {
  //     Console.WriteLine("Number is not greater than 5");
  //   }
  // }

    // string choice = "A";  
    
    // switch(choice) {
    //   case "A":
    //     Console.WriteLine("A Selected");
    //     break;
        
    //   default:
    //     Console.WriteLine("None Selected Within Options");
    //     break;
    // }

    // while(i < 10) {
    //   Console.WriteLine($"value is {i}");
    //   i++;
    // }
    
    // do { // do runs at least once no matter if theres a while
    //   Console.WriteLine(i);
    //   i++;
    // }
    // while(i < 50000);

    // for (int i = 1; i < 10; i++) {
    //   Console.WriteLine(i);
    // }

    string[] arrayName = {"Joe", "Mama"};

    foreach(string x in arrayName) {
      Console.WriteLine(x);
    }

    
  }
}