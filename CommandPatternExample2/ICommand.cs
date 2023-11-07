namespace CommandPatternExample2
{
    public interface ICommand
    {
        void ExecuteAction();
    }

    public enum PriceAction
    {
        Increase,
        Decrease
    }
}
