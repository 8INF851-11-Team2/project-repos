namespace LOCMI.Models.Certificates;

using LOCMI.Core;

public class Certificate
{
    protected string Date;

    private bool _isSuccess;

    private Microcontroller _microController;

    private string _name;

    private ITestResult _testResult;

    private ITest _test;

    public Certificate(ITest test, Microcontroller microController, string name) //Name rajouté 
    {
        _test = test;
        _microController = microController;
        _testResult = new TestResultImpl();
        _name = name;
        _isSuccess = false;
        Date = DateTime.Now.ToShortDateString();
    }

    public void Certify()
    {
        _test.Run(_testResult, _microController);
        if (_testResult.IsSuccessful())
        {
            _isSuccess = true;
        }
    }

    public bool IsSuccess()
    {
        return _isSuccess;
    }

    public ITestResult GetTestResult()
    {
        return _testResult;
    }

    public string GetName()
    {
        return _name;
    }
}