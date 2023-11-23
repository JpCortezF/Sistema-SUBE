namespace MyExceptions
{
    public class MyExceptions : Exception
    {
        string message;

        public MyExceptions(string message) : base(message)
        {
            this.message = message;
        }
    }
}