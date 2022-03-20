using Xunit;
using Shouldly;

namespace ModuleTests;

public class MathTests
{

    [Fact]
    [Trait("Category", "Unit")]
    public void SolveQaudratic_WithPositive_C_Argument_Should_ReturnEmpty()
    {
        // Arange
        var b = -1;  // x2 + 1 = 0;

        // Act
        var result = QuadraticHelper.SolveIncompleteQuadraticEquation(b);

        // Assert
        result.Length.ShouldBe(0);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void SolveQaudratic_WithPositive_C_Argument_Should_ReturnTwoRoots()
    {
        // Arange
        var b = 1;

        // Act
        var result = QuadraticHelper.SolveIncompleteQuadraticEquation(b);

        // Assert
        result.Length.ShouldBe(2);
        result[1].ShouldBe(result[0] * -1);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void SolveQaudratic_WithPositive_C_Argument_Should_ReturnOneSameRoot()
    {
        // Arange
       // x ^ 2 + 2x + 1 = 0
        var a = 1;
        var b = -2;
        var c = 1;

        // Act
        var result = QuadraticHelper.Solve(a, b, c);

        // Assert
        result.Length.ShouldBe(2);
        result[1].ShouldBe(result[0]);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void SolveQaudratic_WithPositive_A_Argument_Should_NotBeNull()
    {
        // Arange
        // x ^ 2 + 2x + 1 = 0
        var a = 0;
        var b = -2;
        var c = 1;

        // Act
        try
        {
            var result = QuadraticHelper.Solve(a, b, c);
        }catch(Exception e)
        {
            // Assert
            e.Message.ShouldBe("Argument a can not be 0");
        }

    }

    [Theory]
    [Trait("Category", "Unit")]
    [InlineData(double.NaN, 2, 3, "Argument a is incorrect")]
    [InlineData(4, double.NaN, 3, "Argument b is incorrect")]
    [InlineData(5, 2, double.NaN, "Argument c is incorrect")]
    public void SolveQaudratic_With_A_NaN_Argument_Should_ThrowException(double a, double b, double c, string messageError)
    {

        // Act
        try
        {
            var result = QuadraticHelper.Solve(a, b, c);
        }
        catch (Exception e)
        {
            // Assert
            e.Message.ShouldBe(messageError);
        }

    }
}
