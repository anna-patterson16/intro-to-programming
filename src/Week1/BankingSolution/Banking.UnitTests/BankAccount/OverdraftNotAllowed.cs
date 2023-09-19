using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class OverdraftNotAllowed
{
    [Fact]
    public void BalanceDoesNotDecreaseOnOverdraft()
    {
        // Given
        // If you overdraft, what should be the "observable" thing that happens?
        // - it shouldn't decrease your balance
        //  - if I have 5000, and I take out 6000, then I should still have 5000
        var account = new Account();
        var openingBalance = account.GetBalance();

        var amountToWithdraw = openingBalance + .01M;

        // When
        try
        {
            account.Withdraw(amountToWithdraw);
        }
        catch (OverdraftException)
        {

            //ignore
        }
        finally
        {
            Assert.Equal(openingBalance, account.GetBalance());
        }

        // Then
        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void OverdraftThrowsAnException()
    {

        var account = new Account();
        var openingBalance = account.GetBalance();

        var amountToWithdraw = openingBalance + .01M;

        // When
        Assert.Throws<OverdraftException>(() =>
        {
            account.Withdraw(amountToWithdraw);
        });

        // Then - did the exception get thrown

    }

}
