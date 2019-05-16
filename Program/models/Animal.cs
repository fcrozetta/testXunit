namespace Program.Models
{
    abstract class Animal
    {
        public string Race { get; set; }
        public string Sound { get; set; }

        public string bark()
        {
            return $"{Sound} {Sound}!";
        }
    }
}