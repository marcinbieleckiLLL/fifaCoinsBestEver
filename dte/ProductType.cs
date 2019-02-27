namespace fifaCoinsBestEver.dte
{
    public class ProductType : AEnum
    {
        public static ProductType COINS = new ProductType("coins", 1);
        public static ProductType BOT = new ProductType("bot", 2);
        
        public ProductType(string name, int value)
        {
            this.name = name;
            this.value = value;   
        }

        public ProductType()
        {
        }   
    }
}