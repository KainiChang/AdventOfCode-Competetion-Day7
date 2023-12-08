namespace code;
public class Processor1
{
    public static long Process(List<(string, long)> hands)
    {
        int length = hands.Count;

        List<(string, long, int, long)> bids = new List<(string, long, int, long)>();
        // copy hands to bids
        foreach (var hand in hands)
        {
            bids.Add((hand.Item1, hand.Item2, 0, 0));
        }
        for (int i = 0; i < length; i++)
        {
            int level = GetStrengthLevel(bids[i].Item1);
            //replace A chars in Item1 with Z, replace K with Y,replace Q with X, replace J with W, replace T with V
            bids[i] = (bids[i].Item1.Replace('A', 'Z').Replace('K', 'Y').Replace('Q', 'X').Replace('J', 'W').Replace('T', 'V'), bids[i].Item2, level, bids[i].Item4);
        }
        //sort by level, then by card value
        bids.Sort((x, y) =>
 {
     int compareLevel = y.Item3.CompareTo(x.Item3); // Descending sort for Item3
     if (compareLevel != 0)
         return compareLevel;

     return y.Item1.CompareTo(x.Item1); // Descending sort for Item1 when Item3s are equal
 });
        long count = 0;
        for (int i = 0; i < length; i++)
        {

            long product = (length -i) * bids[i].Item2;
            // Console.WriteLine($"product: {product} = {length -i} * {bids[i].Item2}");
            bids[i] = (bids[i].Item1, bids[i].Item2, bids[i].Item3, product);
            count += product;
        }
        return count;
    }

    public static int GetStrengthLevel(string cardsInHand)
    {
        int length = cardsInHand.Length;
        // get the distinct cards and their counts
        Dictionary<char, int> cards = new Dictionary<char, int>();
        for (int i = 0; i < length; i++)
        {
            if (cards.ContainsKey(cardsInHand[i]))
            {
                cards[cardsInHand[i]]++;
            }
            else
            {
                cards.Add(cardsInHand[i], 1);
            }
        }

        if (cards.Count == 1)
        {
            return 7;
        }
        else if (cards.Count == 2)
        {
            foreach (var card in cards)
            {
                if (card.Value == 4)
                {
                    return 6;
                }
            }
            return 5;
        }
        else if (cards.Count == 3)
        {
            foreach (var card in cards)
            {
                if (card.Value == 3)
                {
                    return 4;
                }
            }
            return 3;
        }
        else if (cards.Count == 4)
        { return 2; }
        else
        {
            return 1;
        }
    }
}
