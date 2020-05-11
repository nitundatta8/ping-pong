using System;

namespace Ping
{
  class NumberList
  {
    static void Main()
    {
      //takes user's input; input question
      Console.WriteLine("Enter a number");
      string str = Console.ReadLine();
      int number = int.Parse(str);
      //stores the input and makes it an integer; output


      for (int index = 1; index <= number; index ++)
      {
        // if divisible by 3 and  5 then its ping-pong
        if(index % 3 == 0 && index % 5 == 0) {
          Console.WriteLine("ping-pong");
          // if its only divisible by 5 then its pong
        }else if(index % 5 == 0){
          Console.WriteLine("pong");
          //and if it is only divisible by 3 then its ping
        }else if( index % 3 == 0 )
        {
          Console.WriteLine("ping");
        }
        //otherwise if its divisble by neither then just output the number
        else{
          Console.WriteLine(index);
        }

      }
    }
  }
}