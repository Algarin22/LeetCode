public class Solution {
    public bool IsValid(string s) {
         Stack<char> stack = new Stack<char>();

        Dictionary<char, char> pairs = new Dictionary<char, char>() {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s) {
            if (pairs.ContainsKey(c)) {
              
                if (stack.Count == 0 || stack.Pop() != pairs[c])
                    return false;
            } else {
          
                stack.Push(c);
            }
        }

     
        return stack.Count == 0;
    }
}