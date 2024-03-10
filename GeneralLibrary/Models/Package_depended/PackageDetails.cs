using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.Models;

public enum PackageStatus { New, Pending, Success, Failed}
public class PackageDetails
{
    public int Id { get; set; }
    public Package Package { get; set; }

    public double WeightRate { get; set; }
    public PackageStatus Status { get; set; } = PackageStatus.New;



}
