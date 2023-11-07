using CommandPatternExample2;

var modifyPrice = new ModifyPrice();
var product = new Product("Celular", 1200);

Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
Console.WriteLine($"{product}\n");

Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 120));
Console.WriteLine($"{product}\n");

Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 30));
Console.WriteLine($"{product}\n");

Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 80));
Console.WriteLine($"{product}\n");

//desfazendo as ações
modifyPrice.UndoActions();
Console.WriteLine(product);

static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCommand)
    { 
    modifyPrice.SetCommand(productCommand);
    modifyPrice.Invoke();
}