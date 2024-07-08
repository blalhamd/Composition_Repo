
namespace composition
{
    internal class Engine
    {
        private string _Name;
        private int _Power;
        private string _Type;


        public Engine() { }
        public Engine(string name, int power, string type)
        {
            Name = name;
            Power = power;
            Type = type;
        }

		public string Name { get => _Name; set => _Name = value; }
		public int Power { get => _Power; set => _Power = value; }
		public string Type { get => _Type; set => _Type = value; }
	}
}
