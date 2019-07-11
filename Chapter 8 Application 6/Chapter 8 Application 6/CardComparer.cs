using System.Collections.Generic;

namespace Chapter_8_Application_6
{
    class CardComparer : IComparer<Card>
    {

        public int Compare(Card x, Card y)
        {
            if (x.value > y.value)
                return 1;
            if (x.value < y.value)
                return -1;
            if (x.suit > y.suit)
                return 1;
            if (x.suit < y.suit)
                return -1;
            return 0;
        }
    }
}
