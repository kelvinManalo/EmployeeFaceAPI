namespace EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPerson
{
    public class PersonGroupPersonListOutputDto
    {
        public string PersonId { get; set; }
        public string Name { get; set; }
        public string UserData { get; set; }
        public string[] PersistedFaceIds { get; set; }
    }
}
