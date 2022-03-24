namespace ModuleTests
{
    public static class QuadraticHelper
    {
        public static double[] SolveIncompleteQuadraticEquation(double b)
        {
            ValidateDoubleParameter(b, "Argument b is incorrect");

            if (b.CompareTo(0) < 0)
                return new double[0];

            var res = Math.Sqrt(b);
            return new double[] { res, res * -1 };
        }

        public static double[] Solve(double a, double b, double c)
        {
            
            ParametersValidation(a, b, c);
                
            double d = b * b - 4 * a * c;

            if (d.CompareTo(0) < 0)
                return new double[0];
            else if (d.CompareTo(0) == 0)
            {
                var x1 = (-b) / 2 * a;
                return new double[] { x1 };
            } else
            {
                var x1 = (-b + Math.Sqrt(d)) / 2 * a;
                var x2 = (-b - Math.Sqrt(d)) / 2 * a;
                return new double[] { x1, x2 };
            }
        }

        private static void ParametersValidation(double a, double b, double c)
        {
            if (a.EqualsExact(0))
                throw new ArgumentException("Argument a can not be 0");

            ValidateDoubleParameter(a, "Argument a is incorrect");
            ValidateDoubleParameter(b, "Argument b is incorrect");
            ValidateDoubleParameter(c, "Argument c is incorrect");
        }

        private static void ValidateDoubleParameter(double val, string errorMessage)
        {
            if (!double.IsFinite(val) || double.IsNaN(val))
                throw new ArgumentException(errorMessage);
        }
    }
}
