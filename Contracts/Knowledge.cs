namespace Contracts
{
    public class Knowledge {
        public string Name { get; set; }
        public string Description { get; set; }

        public Knowledge(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}