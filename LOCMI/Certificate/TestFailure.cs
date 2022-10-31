namespace LOCMI.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Certificate.TestCase;

public class TestFailure
{
    public string Cause { get; set; }
    public TestCase TestCase { get; set; }

    public TestFailure(string r, TestCase tc) //Obligé de prendre un TestCase ou on doit cast le type
    {
        Cause = r;
        TestCase = tc;
    }

}
