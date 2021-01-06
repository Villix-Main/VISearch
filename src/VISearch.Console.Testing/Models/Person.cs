namespace VISearch.ConsoleTesting
{
    [SearchObject]
    public class Person
    {
        [SearchIgnore]
        public string Name { get; set; }

        [SearchIgnore]
        public int Age { get; set; }
    }
}
