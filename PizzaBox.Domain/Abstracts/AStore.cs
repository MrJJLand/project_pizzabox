using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    [XmlInclude(typeof(ChicagoStore))]
    [XmlInclude(typeof(NewYorkStore))]
    public abstract class AStore
    {
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }

    }
}