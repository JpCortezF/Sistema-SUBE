namespace MyExceptions
{
    public class MyExceptions : Exception
    {
        public MyExceptions()
        {
        }
        public MyExceptions(string message) : base(message)
        {
        }
    }
}