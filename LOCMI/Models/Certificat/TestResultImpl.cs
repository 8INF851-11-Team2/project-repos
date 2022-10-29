using System;
namespace LOCMI.Models.Certificat
{
    public class TestResultImpl : TestResult
    {
        public int failureCounter;
        public int runCounter;

        public void addFailure(Test test, string cause)
        {
            throw new NotImplementedException();
        }

        public void getFailureCount()
        {
            throw new NotImplementedException();
        }

        public void getRunCount()
        {
            throw new NotImplementedException();
        }

        public void incrementRunCounter()
        {
            throw new NotImplementedException();
        }

        public bool isSuccessful()
        {
            throw new NotImplementedException();
        }
    }
}

