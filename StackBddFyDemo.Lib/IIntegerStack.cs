namespace StackBddFyDemo.Lib
{
    public interface IIntegerStack
    {
        bool IsEmpty();
        void Push(int x);
        int Peek();
        int Pop();
    }
}
