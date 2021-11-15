using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Generic
{
    public class Vectors:List<Vector>
    {
        public Vectors()
        {

        }

        public Vectors(IEnumerable<Vector> initialItems)
        {
            foreach(Vector item in initialItems)
            {
                Add(item);
            }
        }

        public string Sum()
        {
            StringBuilder sb = new StringBuilder();
            Vector currentPoint = new Vector(0.0, 0.0);
            sb.Append("origin");//原点
            foreach(Vector vector in this)
            {
                sb.Append($" + {vector}");
                currentPoint += vector;
            }

            sb.Append($" = {currentPoint}");
            return sb.ToString();
        }
    }
}
