public class MinStack {

    private struct Node{
        public int Value;
        public int Min;

        public Node(int value, int min){
            this.Value = value;
            this.Min = min;
        }
    }

    Stack<Node> stack = new Stack<Node>();

    public void Push(int val){
        int currentMin;

        if(stack.Count == 0){
            currentMin = val;
        }
        else{
            currentMin = Math.Min(val, stack.Peek().Min);
        }

        stack.Push(new Node(val, currentMin));
    }

    public void Pop(){
        stack.Pop();
    }

    public int Top(){
        return stack.Peek().Value;
    }

    public int GetMin(){
        return stack.Peek().Min;
    }
}
