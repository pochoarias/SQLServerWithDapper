using DapperDemo.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Service
{
    public class PrinterService
    {
        public void PersonPrinter(IEnumerable<Person> collection)
        {
            var list = collection as IList<Person> ?? collection.ToList();
            if(list.Count == 0)
            {
                Console.WriteLine("No Elements Found");
                return;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
