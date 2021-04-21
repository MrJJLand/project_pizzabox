using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
    public class StoreSingletons
    {
        private const string _path = @"data/store.xml";
        private readonly FileRepository _fr = new FileRepository();
        private static readonly StoreSingletons _instance;


        public List<AStore> Stores { get; }
        public static List<AStore> stores = new List<AStore>
        {
            new ChicagoStore(),
            new NewYorkStore()
        };

        public static StoreSingletons Instance
        {
            get
            {
                if (_instance == null)
                {
                    return new StoreSingletons();
                }

                return _instance;
            }
        }
        private StoreSingletons()
        {
            Stores = new List<AStore>()
            {
                new ChicagoStore(),
                new NewYorkStore()
            };

            _fr.WriteToFile<List<AStore>>(_path, Stores);

            if (Stores == null)
            {
                Stores = _fr.ReadFromFile<List<AStore>>(_path);
            }
        }

    }
}
