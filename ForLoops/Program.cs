namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* For Loop will repeat for a finite amount of times 
            * The below for loop will continue loop until index is <= 10 
            * 'i' can also be displayed as 'index'
            * There are 3 statements to fill in
            * First - declares an index(i) int
            * Second - The condition for the loop
            * Third - How much to increment or decrement by
            * ++ will increment by 1, to increase this value change to i+=x 
            * -- will decrement by 1, to decrease this value change to i-=x
            */

            for (int i = 1; i <= 10; i ++)        
            { 
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
