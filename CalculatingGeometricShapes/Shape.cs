using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftShapes
{
    public class Shape
    {
        public virtual double S { get; set; }
        public virtual double Radius { get; set; }
        public virtual double P { get; set; }       
        public virtual double[] Parameters { get; set; }
        public virtual double SquereCalc(params double[] Parameters)
        {
            return S;
        }   
        
        public void AutoDetect (Type obj)
        {
            
            if (obj.GetType() == typeof(Circle))
            {
                Console.WriteLine("Circle");
            }
        }
    }

    public class Circle : Shape
    {
        public override double S { get => base.S; set => base.S = value; }
        public override double Radius { get => base.Radius; set => base.Radius = value; }
        public override double[] Parameters { get => base.Parameters; set => base.Parameters = value; }
        public override double SquereCalc(params double[] Parameters)
        {           
            S = Parameters.Single() * Parameters.Single() * Math.PI;

            return S;            
        }
    }

    public class Triangle :Shape
    {
        public override double S { get => base.S; set => base.S = value; }
        public override double[] Parameters { get => base.Parameters; set => base.Parameters = value; }
        public override double P { get => base.P; set => base.P = value; }
        public override double SquereCalc(params double[] Parameters)
        {
            P = (Parameters.ElementAt(0) + Parameters.ElementAt(1) + Parameters.ElementAt(2)) / 2;
            S = Math.Sqrt(P * (P - Parameters.ElementAt(0)) * (P - Parameters.ElementAt(1)) * (P - Parameters.ElementAt(2)));
            return (double)System.Math.Round(S, 3);            
        }
        public bool TriangleCheck(params double[] Parameters) // Determine Right Triangle by Pythagorean theorem
        {
            Array.Sort(Parameters);
            Array.Reverse(Parameters);

            if (Parameters.ElementAt(0) * Parameters.ElementAt(0) == (Parameters.ElementAt(1) * Parameters.ElementAt(1)) + (Parameters.ElementAt(2) * Parameters.ElementAt(2)))
                return true;
            else
                return false;
        }
    }
}
