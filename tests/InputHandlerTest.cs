namespace tests;

[TestClass]
public class InputHandlerTest : code.InputHandler
{
    [TestMethod]
    public void ReadInputListTest()
    {
        string input = @"32T3K 765
T55J5 684
KK677 28
KTJJT 220
QQQJA 483";
        List<(string, long)> expected = new List<(string, long)>()
        {
            ("32T3K", 765),
            ("T55J5", 684),
            ("KK677", 28),
            ("KTJJT", 220),
            ("QQQJA", 483)
        };
        List<(string, long)>  actual = code.InputHandler.ReadInputLines(input);
        CollectionAssert.AreEqual(expected, actual);

    }
}
