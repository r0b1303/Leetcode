class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        list_s = list(s)
        list_t = list(t)
        for char in list_s:
            if char in list_t:
                list_t.remove(char)
            else:
                return False
        if not list_t:
            return True
        else:
            return False