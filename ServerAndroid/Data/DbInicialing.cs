using System;
using ServerAndroid.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerAndroid.Data
{
    public static class DbInicialing
    {
        public static void Initialize (ConttrolerFlow context)
        {
            var check = context.Database.EnsureCreated();
            if (context.Flowers.Any())
            {
                return;
            }
            var flowers = new Flower[]
            {
                new Flower {Name="endzela",Price="421",image="endzela.jpg"},
            new Flower { Name = "abutilon", Price = "421", image = "абутилон.jpg" },
            
            };
            foreach (Flower s in flowers)
            {
                context.Flowers.Add(s);
            }
        }
    }
}
