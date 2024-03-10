using GeneralLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.Models;



public class CostumerAddresses
{
    public int Id { get; set; } 
    public Costumer Costumer { get; set; }
    public string Address_Line { get; set; }


}
