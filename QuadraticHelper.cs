namespace ModuleTests
{
    public static class QuadraticHelper
    {
        public static double[] SolveIncompleteQuadraticEquation(double b)
        {
            if (b < 0)
                return new double[0];

            var res = Math.Sqrt(b);
            return new double[] { res, res * -1 };
        }

        public static double[] Solve(double a, double b, double c)
        {
            
            ParametersValidation(a, b, c);
                
            double d = b * b - 4 * a * c;

            var x1 = (-b + Math.Sqrt(d)) / 2 * a;
            var x2 = (-b - Math.Sqrt(d)) / 2 * a;

            return new double[] { x1, x2 };

        }

        private static void ParametersValidation(double a, double b, double c)
        {
            if (a.EqualsExact(0))
                throw new ArgumentException("Argument a can not be 0");

            if (!double.IsFinite(a) || double.IsNaN(a))
                throw new ArgumentException("Argument a is incorrect");

            if (!double.IsFinite(b) || double.IsNaN(b))
                throw new ArgumentException("Argument b is incorrect");

            if (!double.IsFinite(c) || double.IsNaN(c))
                throw new ArgumentException("Argument c is incorrect");
        }
    }
}
