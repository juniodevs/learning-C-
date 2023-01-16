namespace _9._Palindrome_Number
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            String textX = x.ToString();
            String textY = new string(textX.Reverse().ToArray());

            if (textX == textY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
