using GeneralLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.Models;

public class Post_Agent
{
    public int Id { get; set; }
    public string Name { get; set; }
    private string _personalId;
    public string PersonalId
    {
        get { return _personalId; }
        set
        {
            _personalId = CheckNumerialsExtension.CheckNumerials(value);
        }
    }


}
