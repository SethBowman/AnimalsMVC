using Google.Protobuf;

namespace AnimalsMVC.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }        

    }
}
