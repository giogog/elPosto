using GeneralLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.Models;

public enum ContactType { Email, PhoneNumber }
public class CostumerContacts
{
    public int Id { get; set; }
    public Costumer Costumer { get; set; }
    public ContactType ContactType { get; set; }

    private string _contactdesc;
    public string ContactDESC
    {
        get { return _contactdesc; }
        set
        {
            // Check if the value contains only numbers
            _contactdesc = value.CheckContactDesc(ContactType);
        }
    }
}
