namespace CalculatorBaru.Test2;

public class CalculatorTests
{
    Calculator calc;
    public CalculatorTests(){
        calc = new Calculator();
    }


    [Fact]
    public void Add_ReturnResult()
    {
        //3A
		//Arrange
		int a = 1;
		int b = 2;
		int expected = 3;

		//Action
		int result = calc.Add(a, b);

		//Assert
		//Old model
		Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, 12, 13)]
    [InlineData(-1, 2, 1)]
    public void Add_ReturnCalculation_UsingInlineData(int a, int b, int expected){
        //3A
		//Arrange

		//Action
		int result = calc.Add(a, b);

		//Assert
		//Old model
		Assert.Equal(expected, result);
		//Assert.Throws<Exception>(() => );
    }


    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(2, 2, 0)]
    [InlineData(-1, -6, 5)]
    public void Substract_ReturnCalculation_UsingInlineData(int a, int b, int expected){
        //3A
		//Arrange

		//Action
		int result = calc.Subtract(a, b);

		//Assert
		//Old model
		Assert.Equal(expected, result);
		//Assert.Throws<Exception>(() => );
    }


}