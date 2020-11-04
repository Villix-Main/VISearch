namespace VISearch.ConsoleTesting
{
    public class Person
    {
        [SearchItem(0)]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
