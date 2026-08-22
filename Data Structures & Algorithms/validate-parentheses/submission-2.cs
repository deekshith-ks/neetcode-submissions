public class Solution {
    public bool IsValid(string s) {
        Stack<char> result = new Stack<char>();

        foreach(char c in s)
        {
            if(c == '(')
            {
                result.Push(')');
            }
            else if(c == '[')
            {
                result.Push(']');
            }
            else if(c == '{')
            {
                result.Push('}');
            }
            else
            {
                if(result.Count == 0)
                {
                    return false;
                }
                char last = result.Pop();
                if (last != c)
                 {
                    return false;
                 }
            }
       }
       return result.Count == 0;
   }
}