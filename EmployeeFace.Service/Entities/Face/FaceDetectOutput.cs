using Newtonsoft.Json;
using System.Collections.Generic;

namespace EmployeeFace.Service.Entities.Face
{
    public class FaceDetectOutput
    {
        [JsonProperty("faceId")]
        public string FaceId { get; set; }

        [JsonProperty("recognitionModel")]
        public string RecognitionModel { get; set; }

        [JsonProperty("faceRectangle")]
        public FaceRectangle FaceRectangle { get; set; }

        [JsonProperty("faceLandmarks")]
        public FaceLandmarks FaceLandmarks { get; set; }

        [JsonProperty("faceAttributes")]
        public FaceAttributes FaceAttributes { get; set; }
    }

    public class FaceRectangle
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("left")]
        public int Left { get; set; }

        [JsonProperty("top")]
        public int Top { get; set; }
    }

    public class PupilLeft
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class PupilRight
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseTip
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class MouthLeft
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class MouthRight
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyebrowLeftOuter
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyebrowLeftInner
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeLeftOuter
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeLeftTop
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeLeftBottom
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeLeftInner
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyebrowRightInner
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyebrowRightOuter
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeRightInner
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeRightTop
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeRightBottom
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeRightOuter
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseRootLeft
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseRootRight
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseLeftAlarTop
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseRightAlarTop
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseLeftAlarOutTip
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseRightAlarOutTip
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class UpperLipTop
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class UpperLipBottom
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class UnderLipTop
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class UnderLipBottom
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class FaceLandmarks
    {
        [JsonProperty("pupilLeft")]
        public PupilLeft PupilLeft { get; set; }

        [JsonProperty("pupilRight")]
        public PupilRight PupilRight { get; set; }

        [JsonProperty("noseTip")]
        public NoseTip NoseTip { get; set; }

        [JsonProperty("mouthLeft")]
        public MouthLeft MouthLeft { get; set; }

        [JsonProperty("mouthRight")]
        public MouthRight MouthRight { get; set; }

        [JsonProperty("eyebrowLeftOuter")]
        public EyebrowLeftOuter EyebrowLeftOuter { get; set; }

        [JsonProperty("eyebrowLeftInner")]
        public EyebrowLeftInner EyebrowLeftInner { get; set; }

        [JsonProperty("eyeLeftOuter")]
        public EyeLeftOuter EyeLeftOuter { get; set; }

        [JsonProperty("eyeLeftTop")]
        public EyeLeftTop EyeLeftTop { get; set; }

        [JsonProperty("eyeLeftBottom")]
        public EyeLeftBottom EyeLeftBottom { get; set; }

        [JsonProperty("eyeLeftInner")]
        public EyeLeftInner EyeLeftInner { get; set; }

        [JsonProperty("eyebrowRightInner")]
        public EyebrowRightInner EyebrowRightInner { get; set; }

        [JsonProperty("eyebrowRightOuter")]
        public EyebrowRightOuter EyebrowRightOuter { get; set; }

        [JsonProperty("eyeRightInner")]
        public EyeRightInner EyeRightInner { get; set; }

        [JsonProperty("eyeRightTop")]
        public EyeRightTop EyeRightTop { get; set; }

        [JsonProperty("eyeRightBottom")]
        public EyeRightBottom EyeRightBottom { get; set; }

        [JsonProperty("eyeRightOuter")]
        public EyeRightOuter EyeRightOuter { get; set; }

        [JsonProperty("noseRootLeft")]
        public NoseRootLeft NoseRootLeft { get; set; }

        [JsonProperty("noseRootRight")]
        public NoseRootRight NoseRootRight { get; set; }

        [JsonProperty("noseLeftAlarTop")]
        public NoseLeftAlarTop NoseLeftAlarTop { get; set; }

        [JsonProperty("noseRightAlarTop")]
        public NoseRightAlarTop NoseRightAlarTop { get; set; }

        [JsonProperty("noseLeftAlarOutTip")]
        public NoseLeftAlarOutTip NoseLeftAlarOutTip { get; set; }

        [JsonProperty("noseRightAlarOutTip")]
        public NoseRightAlarOutTip NoseRightAlarOutTip { get; set; }

        [JsonProperty("upperLipTop")]
        public UpperLipTop UpperLipTop { get; set; }

        [JsonProperty("upperLipBottom")]
        public UpperLipBottom UpperLipBottom { get; set; }

        [JsonProperty("underLipTop")]
        public UnderLipTop UnderLipTop { get; set; }

        [JsonProperty("underLipBottom")]
        public UnderLipBottom UnderLipBottom { get; set; }
    }

    public class FacialHair
    {
        [JsonProperty("moustache")]
        public double Moustache { get; set; }

        [JsonProperty("beard")]
        public double Beard { get; set; }

        [JsonProperty("sideburns")]
        public double Sideburns { get; set; }
    }

    public class HeadPose
    {
        [JsonProperty("roll")]
        public double Roll { get; set; }

        [JsonProperty("yaw")]
        public double Yaw { get; set; }

        [JsonProperty("pitch")]
        public double Pitch { get; set; }
    }

    public class Emotion
    {
        [JsonProperty("anger")]
        public double Anger { get; set; }

        [JsonProperty("contempt")]
        public double Contempt { get; set; }

        [JsonProperty("disgust")]
        public double Disgust { get; set; }

        [JsonProperty("fear")]
        public double Fear { get; set; }

        [JsonProperty("happiness")]
        public double Happiness { get; set; }

        [JsonProperty("neutral")]
        public double Neutral { get; set; }

        [JsonProperty("sadness")]
        public double Sadness { get; set; }

        [JsonProperty("surprise")]
        public double Surprise { get; set; }
    }

    public class HairColor
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class Hair
    {
        [JsonProperty("bald")]
        public double Bald { get; set; }

        [JsonProperty("invisible")]
        public bool Invisible { get; set; }

        [JsonProperty("hairColor")]
        public List<HairColor> HairColor { get; set; }
    }

    public class Makeup
    {
        [JsonProperty("eyeMakeup")]
        public bool EyeMakeup { get; set; }

        [JsonProperty("lipMakeup")]
        public bool LipMakeup { get; set; }
    }

    public class Occlusion
    {
        [JsonProperty("foreheadOccluded")]
        public bool ForeheadOccluded { get; set; }

        [JsonProperty("eyeOccluded")]
        public bool EyeOccluded { get; set; }

        [JsonProperty("mouthOccluded")]
        public bool MouthOccluded { get; set; }
    }

    public class Accessory
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

    }

    public class Blur
    {
        [JsonProperty("blurLevel")]
        public string BlurLevel { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class Exposure
    {
        [JsonProperty("exposureLevel")]
        public string ExposureLevel { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class Noise
    {
        [JsonProperty("noiseLevel")]
        public string NoiseLevel { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FaceAttributes
    {
        [JsonProperty("age")]
        public double Age { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("smile")]
        public double Smile { get; set; }

        [JsonProperty("facialHair")]
        public FacialHair FacialHair { get; set; }

        [JsonProperty("glasses")]
        public string Glasses { get; set; }

        [JsonProperty("headPose")]
        public HeadPose HeadPose { get; set; }

        [JsonProperty("emotion")]
        public Emotion Emotion { get; set; }

        [JsonProperty("hair")]
        public Hair Hair { get; set; }

        [JsonProperty("makeup")]
        public Makeup Makeup { get; set; }

        [JsonProperty("occlusion")]
        public Occlusion Occlusion { get; set; }

        [JsonProperty("accessories")]
        public List<Accessory> Accessories { get; set; }

        [JsonProperty("blur")]
        public Blur Blur { get; set; }

        [JsonProperty("exposure")]
        public Exposure Exposure { get; set; }

        [JsonProperty("noise")]
        public Noise Noise { get; set; }
    }
}
