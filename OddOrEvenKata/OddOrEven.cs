using System.Linq;
public class OorE
{
    public static string OddOrEven(int[] array)
    {
        int total = array.Sum();
        var OddorEven = "Odd";
        if (total % 2 == 0)
        {
            OddorEven = "Even";
        }
       
        return OddorEven;
        
    }
}