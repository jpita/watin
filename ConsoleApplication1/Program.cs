using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WatiN.Core;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread th = new Thread(new ThreadStart(Test));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            th.Join();
            
            
        }
        static void Test()
        {
            IE browser = null;
            browser = new IE("http://www.google.com");
            browser.TextField(Find.ByName("q")).TypeText("WatiN");
            browser.Button(Find.ByName("btnG")).Click();
            browser.Close();
        }
    }
}
