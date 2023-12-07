namespace tests;

[TestClass]
public class Processor1Test : code.Processor1
{
  [TestMethod]
  public void TimeArrayTest()
  {
    string input = @"Time:      7  15   30
        Distance:  9  40  200";

    var expected = new long[] { 7, 15, 30 };
    var actual = code.Processor1.ReadInput(input);
    CollectionAssert.AreEqual(expected, actual);
  }
  [TestMethod]
  public void DistanceArrayTest()
  {
    string input = @"Time:      7  15   30
        Distance:  9  40  200";

    var expected = new long[] { 9, 40, 200 };
    var actual = code.Processor1.ReadInput2(input);
    CollectionAssert.AreEqual(expected, actual);
  }
    [TestMethod]
  public void ExampleTest()
  {
    string input = @"Time:      7  15   30
        Distance:  9  40  200";

    long expected = 288;
    long actual = code.Processor1.Process(input);
    Assert.AreEqual(expected, actual);
  }
      [TestMethod]
  public void GetQ1AnswerTest()
  {
    string input = @"Time:        59707878
Distance:   430121812131276";

    long expected = 0;
    long actual = code.Processor1.Process(input);
    Assert.AreEqual(expected, actual);
  }
}
