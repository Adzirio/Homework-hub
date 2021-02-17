using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;

namespace Mask5
{
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo()
        {
            Title = "";
            IsDone = true;
        }
        
    }
}
