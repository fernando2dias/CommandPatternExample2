namespace CommandPatternExample2
{
    public class ProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly PriceAction _priceAction;
        private readonly int _amount;

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public bool IsCommandExecuted { get; private set; }

        public void ExecuteAction()
        {
            if (_priceAction == PriceAction.Increase) 
            {
                _product.IncreasePrice(_amount);
                IsCommandExecuted = true;
            }
            else 
            {
               IsCommandExecuted = _product.DecreasePrice(_amount); //caso não seja possível descontar ele vai retornar false
            }
        }

        public void UndoAction()
        {
            if(!IsCommandExecuted) //caso o comando não tenha sido executado, ele irá retornar vazio, pulando este comando 
            {
                return;
            }

            if(_priceAction == PriceAction.Increase)
            {
                _product.DecreasePrice(_amount);
            }
            else
            {
                _product.IncreasePrice(_amount);
            }
        }
    }
}
