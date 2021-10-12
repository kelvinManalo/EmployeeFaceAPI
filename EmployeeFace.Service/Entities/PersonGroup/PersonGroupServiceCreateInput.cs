namespace EmployeeFace.Service.Entities.PersonGroup
{
    public class PersonGroupServiceCreateInput
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public string UserData { get; set; }
        public string RecognitionModel { get; set; }
    }
}
