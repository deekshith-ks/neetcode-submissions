public class Solution {
    public int CalPoints(string[] operations) {
        
        Stack<int> scores = new Stack<int>();

        foreach(var operation in operations)
        {
            if(operation == "C")
            {
                scores.Pop();
            }
            else if(operation == "D")
            {
                scores.Push(scores.Peek() * 2);
            }
            else if(operation == "+")
            {
                int last = scores.Pop();
                int secondLast = scores.Peek();

                scores.Push(last);
                scores.Push(last+secondLast);
            }
            else
            {
                scores.Push(int.Parse(operation));
            }
        }

        var sum = 0;
        foreach(int score in scores)
        {
            sum+=score;
        }
        return sum;
    }
}