namespace pizburger.Entities
{
    public class order
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public order()
        {
            Id = Guid.NewGuid().ToString();

        }
    }
}
