using System;
using System.Collections.Generic;
using System.Text;

namespace VisualDB.Models
{
    class Property
    {
        private string ColumnName { get; set; } = "Untitled";
        private string DataType { get; set; } = "Untitled";
        private string Default { get; set; } = "";
        private bool Unique { get; set; } = false;
        private bool Autoincrement { get; set; } = false;
        private bool NotNull { get; set; } = false;
    }
}
