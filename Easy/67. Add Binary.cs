public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder result = new StringBuilder();

        int i     = a.Length - 1; 
        int j     = b.Length - 1; 
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0) {
            int digitA = (i >= 0) ? (a[i--] - '0') : 0;
            int digitB = (j >= 0) ? (b[j--] - '0') : 0;

            int sum = digitA + digitB + carry;
            carry   = sum / 2;        
            result.Append(sum % 2);     
        }


        return new string(result.ToString().Reverse().ToArray());
    }
}