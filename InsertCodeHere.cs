namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            DiceCup mydicecup = new DiceCup();
            System.Console.WriteLine($"The 2 dices rolled {mydicecup.TotalValue}");

            mydicecup.Shake();
            System.Console.WriteLine($"The 2 dices rolled {mydicecup.TotalValue}");

            // The LAST line of code should be ABOVE this line
        }
    }
}