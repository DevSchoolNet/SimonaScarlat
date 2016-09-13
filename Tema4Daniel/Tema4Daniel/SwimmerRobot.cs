using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4Daniel
{
    public class SwimmerRobot:Robot
    {

        public SwimmerRobot(string name, Job job):base(name, job)
        {

        }
        public override string Move()
        {
            return name+" is swimming "+distance+" nautical miles";
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
