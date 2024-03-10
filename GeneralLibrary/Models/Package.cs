using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.Models;

public enum DistanceType { City, Country, Global }
public class Package
{
    public int Id { get; set; }
    public PackageType Type { get; set; }
    public PackageDetails PackageDetails { get; set; }
    public Costumer Costumer { get; set; }
    public Post_Agent Post_Agent { get; set; }
    public DistanceType DistanceType { get; set; }


}
