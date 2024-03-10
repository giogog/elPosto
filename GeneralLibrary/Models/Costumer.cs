using GeneralLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.Models;

public class Costumer
{
    public int Id { get; set; }
    public string Name { get; set; }
    private string _personalId;
    public string PersonalId
    {
        get { return _personalId; }
        set
        {
            // Check if the value contains only numbers
            _personalId = CheckNumerialsExtension.CheckNumerials(value);
        }
    }
    public ICollection<CostumerAddresses> CostumerAddresses { get; set; }
    public ICollection<CostumerContacts> CostumerContacts { get; set; }

}
