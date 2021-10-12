namespace EmployeeFace.BusinessLogic.DataTransferObjects.Face
{
    public class FaceIdentifyOutputDto
    {
        public string FaceId { get; set; }
        public CandidatesDto[] Candidates { get; set; }
    }

    public class CandidatesDto
    {
        public string PersonId { get; set; }
        public double Confidence { get; set; }
    }
}
