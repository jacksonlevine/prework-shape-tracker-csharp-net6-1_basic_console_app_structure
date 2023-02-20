namespace PingPong.Business 
{
  public class Game 
  {
    public Game() 
    {

    }

    public string GetResponse(int input) 
    {
      if(input%3==0)
      {
        return "ping";
      }
      if(input%5==0) {
        return "pong";
      }

      return "" + input;
    }
  }
}