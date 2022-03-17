namespace Ex1.Class
{
    public class Person
    {
		private string _name;
		private DateTime _birthDate;
		private double _height;

		public string Name { get => _name; set => _name = value; }
		public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
		public double Height { get => _height; set => _height = value; }
		
		public string RetornarDados()
		{
			return $"Nome: {Name}, Data de Nascimento: {BirthDate}, Altura: {Height}";
		}
    }
}