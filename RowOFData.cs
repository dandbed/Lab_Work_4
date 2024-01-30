using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work_4
{
    internal class RowOFData
    {
        public object id { get; set; }
        public object Category { get; set; }
        public object Brand { get; set; }
        public object Model { get; set; }
        public object Year { get; set; }
        public object Fuel { get; set; }
        public object Inspection { get; set; }
        public object Owner { get; set; }

        public RowOFData() { }

        public RowOFData(object _id, object _category, object _brand, object _model, object _year, object _fuel, object _inspection, object _owner)
        {
            id = _id;
            Category = _category;
            Brand = _brand;
            Model = _model;
            Year = _year;
            Fuel = _fuel;
            Inspection = _inspection;
            Owner = _owner;
        }

        public void DataChange(object _id, object _category, object _brand, object _model, object _year, object _fuel, object _inspection, object _owner)
        {
            id = _id;
            Category = _category;
            Brand = _brand;
            Model = _model;
            Year = _year;
            Fuel = _fuel;
            Inspection = _inspection;
            Owner = _owner;
        }
    }
}