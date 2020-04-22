namespace AP.Properties.Lession3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Man m= new Man();
            m.Running();
            Woman wm= new Woman();
            m.Running();
            wm.Running();
            m.SayHello();
            m.SayHello("chao anh");
        }
    }
}