namespace EmployeeFace.Service.Entities.Face
{
    public class FaceIdentifyInput
    {
        public string PersonGroupId { get; set; }
        public string[] FaceIds { get; set; }
        public int MaxNumOfCandidatesReturned { get; set; }
        public double ConfidenceThreshold { get; set; }
    }
}
