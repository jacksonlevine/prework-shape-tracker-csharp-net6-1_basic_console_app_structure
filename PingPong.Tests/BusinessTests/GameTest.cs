using PingPong.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PingPong.Tests 
{
  [TestClass]
  public class GameTests 
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
       Game newGame = new Game();
       Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GetResponse_ReturnsNumber1AsString_string()
    {
      Game newGame = new Game();
      Assert.AreEqual(newGame.GetResponse(1), "1");
    }

    [TestMethod]
    public void GetResponse_ReturnsPingIfNumberIsDivisibleBy3_string()
    {
      Game newGame = new Game();
      Assert.AreEqual("ping", newGame.GetResponse(3));
      Assert.AreEqual("ping", newGame.GetResponse(9));
      Assert.AreEqual("ping", newGame.GetResponse(12));
    }

    [TestMethod]
    public void GetResponse_ReturnsPongIfNumberIsDivisibleBy5_string()
    {
      Game newGame = new Game();
      Assert.AreEqual("pong", newGame.GetResponse(5));
    }

    [TestMethod]
    public void GetResponse_ReturnsPingPongIfNumberIsDivisibleBy3And5_string()
    {
      Game newGame = new Game();
      Assert.AreEqual("ping-pong", newGame.GetResponse(30));
    }
  }
}