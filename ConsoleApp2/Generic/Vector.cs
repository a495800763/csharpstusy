using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp2.Generic
{
    public class Vector
    {
        public double? R = null;
        public double? Theta = null;
        public double? ThetaRadians
        {
            //Convert degrees to radians
            get
            {
                return (Theta * Math.PI / 180.0);
            }
        }

        public Vector(double? r ,double? theta)
        {
            //Normalize
            if (r < 0)
            {
                r = -r;
                Theta += 180;
            }
            theta = theta % 360;
            //Assign fileds
            R = r;
            Theta = theta;
        }

        public static Vector operator + (Vector op1,Vector op2)
        {
            try
            {
                //Get(x,y) coodinates for new vector
                double newX = op1.R.Value * Sin(op1.ThetaRadians.Value) + op2.R.Value * Sin(op2.ThetaRadians.Value);
                double newY = op1.R.Value * Cos(op1.ThetaRadians.Value) + op2.R.Value * Cos(op2.ThetaRadians.Value);
                //convert to (R,theta);
                double newR = Sqrt(newX * newX + newY * newY);
                double newTheta = Atan2(newX, newY) * 180.0 / PI;

                // return new Vector
                return new Vector(newR, newTheta);
            }
            catch
            {
                //return null vector
                return new Vector(null, null);
            }
        }

        public static Vector operator -(Vector op) => new Vector(-op.R, op.Theta);
        public static Vector operator -(Vector op1, Vector op2) => op1 + (-op2);

        public override string ToString()
        {
            //Get string representation of coordinates.
            string rString = R.HasValue ? R.ToString() : "null";
            string thetaString = Theta.HasValue ? Theta.ToString() : "null";

            return string.Format($"{rString},{thetaString}");
        }
    }
}
