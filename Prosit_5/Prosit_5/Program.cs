namespace Prosit_5
{
    class Program
    {
        static void Main(string[] args)
        {
            viewmodel viewmodel = new viewmodel();
            List<string> userinput = viewmodel.askusertext();
            viewmodel.displayresult(userinput[0], userinput[1], userinput[2]);
        }
    }
}