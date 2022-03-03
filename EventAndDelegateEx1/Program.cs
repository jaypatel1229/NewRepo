//Pass Data From one Class To another  using Event Delegate

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateEx1
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartProgram sp = new StartProgram();
            sp.completeProcess += Sp_completeProcess;
            sp.StartProcess();

            EventDelegate ed = new EventDelegate();
            ed.Plus += Ed_Plus;
            ed.process();

            AddBuiltinEvent abe = new AddBuiltinEvent();
            abe.Addnumbers += Abe_Addnumbers;
            abe.Add();
        }

        private static int Ed_Plus(int x, int y)
        {
            Console.WriteLine("\n x + y = " + (x + y));
            return x + y;
        }

        private static void Sp_completeProcess()
        {
            Console.WriteLine("\n Welocme to the World of friends");
        }

        private static void Abe_Addnumbers(object sender, EventArgs e)
        {
            Console.WriteLine("\n Event is Executed.....");
        }
        
       
    }
    

}

public class StartProgram
{
    public  delegate void start();

    public event start completeProcess;

    public void StartProcess()
    {
        Console.WriteLine("\n Process started");
        Console.ReadLine();
        OnCompletedProcess();
    }
    private void OnCompletedProcess()
    {
        completeProcess?.Invoke();
    }
}

public class EventDelegate
{
    public delegate int Sum(int x, int y);

    public event Sum Plus;
    public void process()
    {
        Console.WriteLine("\n Process Started");
        Console.ReadLine();
        OnSumProcess();
    }
    private void OnSumProcess()
    {
        Plus.Invoke(30, 40);
        Console.Read();
    }
}


