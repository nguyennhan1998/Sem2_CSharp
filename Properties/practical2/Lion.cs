namespace AP.Properties.practical2
{
    public class Lion:Animal
    {
        public string Name1
        {
            get => name;
            set => name = value;
        }

        public int Weight1
        {
            get => weight;
            set => weight = value;
        }

        public Lion(string name, int weight) : base(name, weight)
        {
        }

        public override void Show()
        {
            base.Show();
        }
    }
}