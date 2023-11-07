namespace CommandPatternExample2
{
    public interface ICommand
    {
        void ExecuteAction();
        void UndoAction();
    }

    public enum PriceAction
    {
        Increase,
        Decrease
    }
}
