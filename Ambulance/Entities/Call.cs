namespace Ambulance.Entities
{
    class Call : IEntity
    {
        public int Id { get; set; }
        public string Situation { get; set; }
        public string Number { get; set; }
        public string Adress { get; set; }
        public string PatientName { get; set; }
        public string PatientAge { get; set; }
        public string CallName { get; set; }
    }
}
