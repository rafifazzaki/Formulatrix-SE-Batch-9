namespace CalculatorBaru.Test;

public class CalculatorTests
{
    Calculator calc;
    [SetUp]
    public void Setup()
    {
        calc = new();
    }

    public void Add_ReturnResult(){
        // 3A
        // Arrange:
        int a = 2;
        int b = 5;
        int expected = 7;
        
        // Action:

        int result = calc.Add(a, b);
        
        // Assert:

        // // Old Model
        Assert.AreEqual(expected, result);

        //  // Constraint Model
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(1, 2, 3)]
    [TestCase(1, 3, 4)]
    [TestCase(9, 3, 12)]
    [TestCase(-1, 4, 3)]
    public void Add_ReturnCorrectNumber_UsingTestCase(int a, int b, int expected)
    {

        //3A
		//Arrange

		//Action
		int result = calc.Add(a, b);

        //Assert
        //Old model
		Assert.AreEqual(expected, result);
		//Assert.Throws<Exception>(() => );
		//Constraint Model
		Assert.That(result, Is.EqualTo(expected));

    }
}