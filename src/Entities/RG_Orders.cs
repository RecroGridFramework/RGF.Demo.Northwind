using Recrovit.RecroGridFramework;
using Recrovit.RecroGridFramework.Core;
using RGF.Demo.Northwind.Models;

namespace RGF.Demo.Northwind.Entities;

public partial class RG_Orders : RgfCore<Orders>
{
    public RG_Orders(IRecroGridContext rgContext) : base(rgContext) { }
}