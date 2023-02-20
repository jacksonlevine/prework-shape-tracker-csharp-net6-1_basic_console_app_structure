using System;
using PingPong.Business;

namespace PingPong
{
  class Program
  {
    static void Main()
    {
      Game game = new Game();
      Console.WriteLine("Hello!");
      Console.WriteLine("Please enter a number:");
      string response = Console.ReadLine();
      int usersRange = int.Parse(response);
      for(int i = 0; i < usersRange; i++) 
      {
        Console.WriteLine(game.GetResponse(i));
      }
      Console.ReadLine();
    }
  }
}