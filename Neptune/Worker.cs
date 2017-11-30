using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptuneLib
{
    class Worker
    {
        public string WorkerID { get; set; }
        public string WorkerFirstName { get; set; }
        public string WorkerLastName { get; set; }
        public string WorkerPosition { get; set; }
        public string WorkerPhoneNumber { get; set; }
        public string Display
        {
            get
            {
                return String.Format("{0}, {1} {2} - {3}", WorkerID, WorkerFirstName, WorkerLastName, WorkerPosition);
            }
        }
    }
}