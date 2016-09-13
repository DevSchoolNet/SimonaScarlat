using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4Daniel
{
    public class FlyingRobot:Robot
    {
        public FlyingRobot(string name, Job job):base(name,job)
        {

        }
        public override string Move()
        {
           return base.Move() + name+" is flying "+distance+" miles";
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
