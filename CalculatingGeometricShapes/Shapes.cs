using System;

namespace CalculatingGeometricShapes
{
    public class Shapes
    {
        public double Circle(double circle_radius) // Find Circle Square
        {
            double S = 0;

            S = circle_radius * circle_radius * Math.PI;

            return S;

        }

        public double Triangle(double a, double b, double c) // Find Triangle Square by Heron's formula.
        {
            double P = 0;
            double S = 0;

            P = (a + b + c) / 2;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return (double)System.Math.Round(S, 3);
        }

        public bool TriangleCheck(params double[] parameters) // Determine Right Triangle by Pythagorean theorem
        {
            Array.Sort(parameters);
            Array.Reverse(parameters);

            if (parameters[0] * parameters[0] == (parameters[1] * parameters[1]) + (parameters[2] * parameters[2]))
                return true;
            else
                return false;
        }

        public double AutoShapesDetect(params double[] parameters) // Find Circle Or Triangle Square Simple To Add Additional Shape
        {
            double S = 0;
            double P = 0;
            int i = 0;
            foreach (double a in parameters)
            {
                i++;
            }
            if (i == 1) //one parametr is a circle
            {
                S = parameters[0] * parameters[0] * Math.PI;

                return S;
            }
            else if (i == 3) //three parametrs is a triangle
            {
                P = (parameters[0] + parameters[1] + parameters[2]) / 2;
                S = Math.Sqrt(P * (P - parameters[0]) * (P - parameters[1]) * (P - parameters[2]));

                return (double)System.Math.Round(S, 3);

            }
            //else if ( i == 4 ){} // for square

            else
                //throw new Exception("Wrong Number Of Parameters Sent");
                return 0;
        }
    }
}

