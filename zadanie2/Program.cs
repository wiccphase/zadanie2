using System;
using System.Collections.Generic;
using System.Linq;

namespace bars3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Entity>()
                {
                new Entity { Id = 1, ParentId = 0, Name = "Root entity" },
                new Entity { Id = 2, ParentId = 1, Name = "Child of 1 entity" },
                new Entity { Id = 3, ParentId = 1, Name = "Child of 1 entity" },
                new Entity { Id = 4, ParentId = 2, Name = "Child of 2 entity" },
                new Entity { Id = 5, ParentId = 4, Name = "Child of 4 entity" }
            };

            int n = 0;

            while (n != 5)
            {

                var Dictionary = new Dictionary<int, List<int>>();




                var listpapa = new List<int>();



                IEnumerable<Entity> zhopa = list
                .Where(x => x.ParentId == n);



                foreach (var p in zhopa)
                {
                    listpapa.Add(p.Id);

                }



                if (listpapa.Count != 0)
                {

                    Dictionary.Add(n, listpapa);
                    foreach (var p in Dictionary)
                    {
                        var count = listpapa.Count();
                        string result = "";
                        for (int i = 0; i < count; i++)
                        {
                            result += listpapa[i] + ",";
                        }
                        Console.WriteLine($"Id = {p.Key}, Value = List [{result}]");

                    }

                }

                n++;



            }

        }


        public class Entity
        {
            public int Id { get; set; }
            public int ParentId { get; set; }
            public string Name { get; set; }
        }

    }



}