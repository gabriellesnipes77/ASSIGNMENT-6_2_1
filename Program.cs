namespace ASSIGNMENT_6_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();
            //add elements to the stack using Push()
            //adding elements to the stack and printing the value on top of the stack using peek
            //adding elements using Push()


            stack.Push(1);
            //Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            //as ling as the count is > 0, as long as the stack is not empty
            while (stack.Count > 0)
            {
                //Pop() will return the element that was removed from the stack
                Console.WriteLine("The Top value {0} was removed from the stack", stack.Pop());
                //print the stack count
                Console.WriteLine("Current stack count is : {0}", stack.Count);
            }
        }
    }
}
