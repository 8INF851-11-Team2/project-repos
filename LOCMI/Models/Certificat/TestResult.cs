using System;
namespace LOCMI.Models.Certificat
{
    public interface TestResult
    {
        public void addFailure(Test test, string cause);
        public void getFailureCount();
        public void getRunCount();
        public bool isSuccessful();
        public void incrementRunCounter();
    }
}

