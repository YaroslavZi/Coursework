namespace Ambulance.Entities
{
    class Brigade : IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Rayon { get; set; }
        public string Adress { get; set; }
        public string Amount { get; set; }
    }
}
