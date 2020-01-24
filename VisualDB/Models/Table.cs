using System;
using System.Collections.Generic;
using System.Text;

namespace VisualDB.Models
{
    class Table
    {
        private string _tableName;
        public string TableName
        {
            get => _tableName;
            set => _tableName = value;
        }
        private int PositionX { get; set; }
        private int PositionY { get; set; }
    }
}
