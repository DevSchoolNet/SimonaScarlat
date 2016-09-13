using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4Daniel
{
    public class UndergroundRobot:Robot
    {

        public UndergroundRobot(string name, Job job):base(name, job)
        {

        }
        public override string Move()
        {
            return name+" is going underground "+distance+" km";
        }

        public override string GetReady()
        {
            return  name + " " + weapon;
        }

        public override string Work()
        {
            return name + " working with " + weapon;
        }
    }
}
