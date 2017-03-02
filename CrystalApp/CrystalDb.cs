using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalApp
{
    
    public class Invoice
    { 
        public string Customer { get; set; }
        public string Name { get; set; }
     
        public static List<Invoice> Invoices()
        {
            return new List<CrystalApp.Invoice>()
            {
                new CrystalApp.Invoice {  Customer="Raj", Name="Product1"},
                new CrystalApp.Invoice {  Customer="Raj", Name="Product2"},
                new CrystalApp.Invoice {  Customer="Raj", Name="Product3"},
                new CrystalApp.Invoice {  Customer="Raj", Name="Product4"},
                new CrystalApp.Invoice {  Customer="Raj", Name="Product5"},
                new CrystalApp.Invoice {  Customer="Man", Name="Pr1"},
                new CrystalApp.Invoice {  Customer="Man", Name="Pr2"},
                new CrystalApp.Invoice {  Customer="Man", Name="Pr3"},
                new CrystalApp.Invoice {  Customer="Man", Name="Pr4"},
                new CrystalApp.Invoice {  Customer="Tan", Name="Tr11"},
                new CrystalApp.Invoice {  Customer="Tan", Name="Tr12"},
                new CrystalApp.Invoice {  Customer="Tan", Name="Tr13"},
                new CrystalApp.Invoice {  Customer="Tan", Name="Tr14"},
                new CrystalApp.Invoice {  Customer="Tan", Name="Tr15"},
                new CrystalApp.Invoice {  Customer="Tan", Name="Tr16"}
            };
        }
    }
     
}
