// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Serialization;

namespace _3_2;
 public abstract class Program {
    public bool WayOfInputtingTheArray;
    public abstract void countAverage();
    public abstract void RandFill();
    public abstract void Output();
    public abstract void Initializ();
    public abstract void UserFill();
    static void Main()
    {
        OneDimentionArr OneD = new OneDimentionArr();
        TwoDimentionArr TwoD = new TwoDimentionArr();
        SteppedArr StepD = new SteppedArr();
        Program[] arrs = new Program[3];
        arrs[0] = new OneDimentionArr();
        arrs[1] = new TwoDimentionArr();
        arrs[2] = new SteppedArr();

        foreach (Program i in arrs)
        {
            i.Initializ();
            i.Output(); 
            i.countAverage();
        }

    }
}