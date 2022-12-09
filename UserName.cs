class Node {
    private char value;
    private Node next = null;

    public Node(char value) {
        this.value = value;
    }

    public void SetNext(Node next) {
        this.next = next;
    }

    public Node Next() {
        return this.next;
    }

    public char GetValue() {
        return this.value;
    }
}

class Program {

    static void Main(string[] args) {
        Node a = new Node('A');
        Node b = new Node('B');
        a.SetNext(b);
        b.SetNext(a);
        Console.WriteLine(a.Next().Next().Next().Next().Next().GetValue());
    }

}