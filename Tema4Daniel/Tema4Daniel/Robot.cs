using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4Daniel
{
    public enum Job
    {
        Work,
        War
    }
    public class Robot
    {
        public string name;
        public Job job;
        public int distance;
        public string weapon;

        public string Name { get; set; }
        //public int Distance
        //{
        //    get { return this.distance; }
        //    set { this.distance = value; }
        //}

        public Robot(string name, Job job)
        {
            this.name = name;
            this.job = job;
        }
        
        public virtual string Move()
        {
            return "Deplasare: ";
        }

        public virtual string GetReady()
        {
            return "Get Ready: ";
        }

        public virtual string Work()
        {
            return "Work: ";
        }
    }
}
