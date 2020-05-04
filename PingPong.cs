using System;
class NumberList
{
  static void Main()
  {
     Console.WriteLine("Enter a number");
     string str = Console.ReadLine();
    int number = int.Parse(str);

    for (int index = 1; index <= number; index ++)
    {
      
      if(index % 3 == 0 && index % 5 == 0) {
        Console.WriteLine("ping-pong");
      }else if(index % 5 == 0){
        Console.WriteLine("pong");
      }else if( index % 3 == 0 )
      {
        Console.WriteLine("ping");
      }
      else{
        Console.WriteLine(index);
      }

    }
  }
}
