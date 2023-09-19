namespace CSharpNotes;

public class UnitTest1
{
    [Fact] //attribute - marker/flag
    public void CanAddTwoSpecificIntegers()
    {
        // fact is one specific thing, a theory is generalized
        // given 
        int a = 10;
        int b = 20;
        int sum;

        // when
        sum = a + b;

        // then
        Assert.Equal(30, sum);
    }

    [Theory]
    [InlineData(10, 20, 30)] // a=10, b=20, sum=30 and would run with this data
    [InlineData(2, 2, 4)]
    [InlineData(10, 2, 12)]  // would do all these examples when run
    public void GivenAnyTwoIntegersWeCanAddThemTogether(int a, int b, int expected)
    {
        int sum = a + b;

        // the expected value should equal to the sum or fail
        Assert.Equal(expected, sum);
    }
}