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
            if (a == default)
                throw new ArgumentException("Argument a can not be 0");


            double d = b * b - 4 * a * c;

            var x1 = (-b + Math.Sqrt(d)) / 2 * a;
            var x2 = (-b - Math.Sqrt(d)) / 2 * a;

            return new double[] { x1, x2 };
        }
    }
}
