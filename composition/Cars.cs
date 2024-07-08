
namespace composition
{
	internal class Cars
    {
        private Name _Name;
        private int _Model;
        private double _Price;
        private Engine _Engine;

        public Cars() { }
        public Cars(Name name, int model, double price, Engine engine)
        {
            _Name = name;
            _Model = model;
            _Price = price;
            _Engine = engine;
        }

		public Name Name { get => _Name; set => _Name = value; }
		public int Model { get => _Model; set => _Model = value; }
		public double Price { get => _Price; set => _Price = value; }
		internal Engine Engine { get => _Engine; set => _Engine = value; }

		public override string ToString()
		{
            return $"Name:  {Name}\n" +
                   $"Model: {Model}\n" +
                   $"price: {Price}\n" +
                   $"power of engine: {_Engine.Power}";
		}
	}
}
