using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ping;

namespace Ping.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void IsFilter_OutPutsListContainsAString()
    {
      Assert.AreEqual("ping-pong", NumberList.Filter(5));
    }
    [TestMethod]
    public void Filter_ReturnsAstringOfInt()
    {
      Assert.AreEqual("10", NumberList.Filter(10));
    }
  }
}








//a list stores strings
//otherwise if its divisble by neither then just output the number
// if it is only divisible by 3 then its ping
// if its only divisible by 5 then its pong
// if divisible by 3 and  5 then its ping-pong
