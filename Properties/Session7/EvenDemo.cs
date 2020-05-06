using System;

namespace AP.Properties.Session7
{
    public delegate void ButtonHandle(string msg);
    public class EvenDemo
    {
        public event ButtonHandle OnClick;

        public void ClickButton()
        {
            Console.WriteLine("Button clicked!");
            DateTime now=DateTime.Now;
            if (OnClick == null)
            {
                OnClick += ShowAlert;
                //Nếu muốn làm nhiều hàm cứ cộng vào đây là được.
            }

            OnClick("User click at: " + now);

        }

        public static void ShowAlert(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}