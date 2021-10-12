namespace EmployeeFace.BusinessLogic.DataTransferObjects.Face
{
    public class FaceIdentifyInputDto
    {
        public string PersonGroupId { get; set; }
        public string[] FaceIds { get; set; }
        public int MaxNumOfCandidatesReturned { get; set; }
        public double ConfidenceThreshold { get; set; }
    }
}
