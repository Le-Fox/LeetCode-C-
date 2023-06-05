public class Solution {
    public void ReverseString(char[] s) {
        int right = s.Length-1;
        
        char floatingValue;
        for(int left = 0;right > left;++left){
            floatingValue = s[right];
            s[right] = s[left];
            s[left] = floatingValue;
            right--;
            
        }
        
    }
}