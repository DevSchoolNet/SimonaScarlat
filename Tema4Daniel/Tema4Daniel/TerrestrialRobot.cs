using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4Daniel
{
    public class TerrestrialRobot:Robot
    {

        public TerrestrialRobot(string name, Job job):base(name, job)
        {

        }
        public override string Move()
        {
            return name+" is going "+distance+" km";
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
