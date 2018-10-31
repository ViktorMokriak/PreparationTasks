using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    class Task
    {
        public string NameOfTask { get; set; }
        public Complexity Complexity { get; set; }
        public Priority Priority { get; set; }
        public Task (string tempName, int tempPriority, int tempComplexity)
        {
            this.NameOfTask = tempName;
            this.Complexity = (Complexity)tempComplexity;
            this.Priority = (Priority)tempPriority;
        }
        
        public int getTimeForTask ()
        {
            return (int)Complexity;
        }

    }

}
