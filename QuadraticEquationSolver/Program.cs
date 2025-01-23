using System;

namespace QuadraticEquationSolver
{
    public class Solver
    {
        public static (double?, double?) SolveQuadratic(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("Coefficient 'a' cannot be zero.");

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return (null, null); // No real roots

            if (discriminant == 0)
                return (-b / (2 * a), null); // One real root

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            return (
                (-b + sqrtDiscriminant) / (2 * a),
                (-b - sqrtDiscriminant) / (2 * a)
            );
        }
    }
}

