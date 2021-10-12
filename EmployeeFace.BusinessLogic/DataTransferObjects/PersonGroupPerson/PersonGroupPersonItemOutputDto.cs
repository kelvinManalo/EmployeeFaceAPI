namespace EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPerson
{
    public class PersonGroupPersonItemOutputDto
    {
        public string PersonId { get; set; }
        public string[] PersistedFaceIds { get; set; }
        public string Name { get; set; }
        public string UserData { get; set; }
    }
}
