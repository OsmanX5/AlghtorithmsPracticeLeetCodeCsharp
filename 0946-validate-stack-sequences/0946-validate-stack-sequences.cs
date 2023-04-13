public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        var st = new Stack<int>();
		int PopIndex = 0;
		foreach (var p in pushed)
		{
			st.Push(p);
			while (st.Count > 0 && st.Peek() == popped[PopIndex])
			{
				st.Pop();
				PopIndex++;
			}
		}
		return st.Count == 0;
    }
}