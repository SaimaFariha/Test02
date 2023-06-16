namespace C_AccessModifierr
{
    public class Bicycle : SellBicycle
    {
        public int Wheels { get; set; }
        public void StartBicycle()
        {
            Console.WriteLine("Bicycle Started");
        }
        public void AttachedWheel()
        {
            Console.WriteLine($"You have attacheds {Wheels} wheels");
        }
        public void GenerateInvoice()
        {
            var bicycle = new Bicycle();
            bicycle.SetPrice(0);
            bicycle.Amount = 2;
            bicycle.Invoice();
        }
    }
}