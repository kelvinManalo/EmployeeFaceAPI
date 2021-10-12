namespace EmployeeFace.Service.Entities.Face
{
    public class FaceIdentifyOutput
    {
        public string FaceId { get; set; }
        public Candidates[] Candidates { get; set; }
    }

    public class Candidates
    {
        public string PersonId { get; set; }
        public double Confidence { get; set; }
    }
}
