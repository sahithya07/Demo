using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class TrackerMain
    {
        public enum Priority { P1, P2, P3, P4, P5 };
        public enum Status { Opened = 1, Assigned, Resolved, Closed }
        static void Main(String[] args)
        {
            IssueTracker tracker = new IssueTracker(1, "Fix headset driver", Enum.GetName(typeof(Priority), 3),Enum.GetName(typeof(Status),1));
            Console.WriteLine(tracker);

        }

    }
}
