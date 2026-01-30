namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;

    // Add your code here
    int PrefixIncrement = ++Visitors;
    int PostfixIncrement = Visitors++;
    int PrefixDecrement = --Visitors;
    int PostfixDecrement = Visitors--;
}

