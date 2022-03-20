namespace ModuleTests
{
    public static class DoubleExtension
    {
        private const double Eps = 0.000001;
        public static bool EqualsExact(this double left, double right)
            => Math.Abs(left - right) < Eps;
    }
}
