using Recrovit.RecroGridFramework;
using RGF.Demo.Northwind.Models;
using System;
using System.Linq;

namespace RGF.Demo.Northwind.Entities
{
    public partial class RG_Orders : RecroGridDBC<Orders>
    {
        public RG_Orders(IRecroGridContext rgContext) : base(rgContext) { }
    }

    public partial class RG_Order_Details : RecroGridDBC<Order_Details>
    {
        public RG_Order_Details(IRecroGridContext rgContext) : base(rgContext) { }
    }
}