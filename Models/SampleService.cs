using Models;
using System;
using System.Xml.Linq;

public class SampleService : ISampleService {

    public string Test(string s) {
        Console.WriteLine("Test invoked");
        return "Tested " + s;
    }

    public void XmlMethod(XElement xele) {
        Console.WriteLine(xele.ToString());
    }

    public MyCustomModel TestCustomModel(MyCustomModel customModel) {
        Console.WriteLine("MyCustom model invoked");
        customModel.Email = "update" + customModel.Email;
        return customModel;
    }

}