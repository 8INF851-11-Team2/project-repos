namespace LOCMI.Models.Certificates;

using LOCMI.Core;

public class Certificate
{
    protected string Date;

    private bool _isSuccess;

    private Microcontroller _microController;

    private string _name;

    private ITestResult _testResult;

    public Certificate(ITest test, Microcontroller microController)
    {
    }

    public void Certify()
    {
    }

    public bool IsSuccess()
    {
        throw new NotImplementedException();
    }
}