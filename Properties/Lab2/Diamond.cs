namespace AP.Properties.Lab2
{
    public class Diamond : Product
    {
        private float weight;
        private float size;

        public Diamond(int id, string name, int price, int qty, string image, string desc, float weight, float size) : base(id, name, price, qty, image, desc)
        {
            this.weight = weight;
            this.size = size;
        }

        public bool RealOrFake()
        {
            if (Price > 20)
            {
                return true;
            }

            return false;
        }
    }
}