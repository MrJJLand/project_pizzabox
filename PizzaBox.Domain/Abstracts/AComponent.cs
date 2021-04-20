namespace PizzaBox.Domain.Abstracts
{
    public abstract class AComponent : AModel
    {
        public string name { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}