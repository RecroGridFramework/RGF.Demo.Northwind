using Recrovit.RecroGridFramework;
using RGF.Demo.Northwind.Models;
using System;
using System.Linq;

namespace RGF.Demo.Northwind.Entities
{
    public partial class RG_Employee : RecroGridDBC<Employees>
    {
        public RG_Employee(IRecroGridContext rgContext) : base(rgContext) { }
    }
}