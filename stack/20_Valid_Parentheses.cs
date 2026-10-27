public class Solution {
    public bool IsValid(string s) {
        Stack<int> stack = new ();
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                stack.Push(s[i]);
            }
            if(stack.Count > 0){
                if(s[i] == ')'){
                    if(stack.Peek() == '('){
                        stack.Pop();
                    }
                    else{
                        return false;
                    }
                }
                if(s[i] == '}'){
                    if(stack.Peek() == '{'){
                        stack.Pop();
                    }
                    else{
                        return false;
                    }
                }
                if(s[i] == ']'){
                    if(stack.Peek() == '['){
                        stack.Pop();
                    }
                    else{
                        return false;
                    }
                }
            }
            else{
                return false;
            }
        }
        if(stack.Count == 0){
            return true;
        }
        return false;
    }
}
