using Newtonsoft.Json;
using System.Collections.Generic;

namespace EmployeeFace.BusinessLogic.DataTransferObjects.Face
{
    public class FaceDetectOutputDto
    {
        [JsonProperty("faceId")]
        public string FaceId { get; set; }

        [JsonProperty("recognitionModel")]
        public string RecognitionModel { get; set; }

        [JsonProperty("faceRectangle")]
        public FaceRectangleDto FaceRectangle { get; set; }

        [JsonProperty("faceLandmarks")]
        public FaceLandmarksDto FaceLandmarks { get; set; }

        [JsonProperty("faceAttributes")]
        public FaceAttributesDto FaceAttributes { get; set; }
    }

    public class FaceRectangleDto
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

    public class PupilLeftDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class PupilRightDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseTipDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class MouthLeftDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class MouthRightDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyebrowLeftOuterDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyebrowLeftInnerDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeLeftOuterDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeLeftTopDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeLeftBottomDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeLeftInnerDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyebrowRightInnerDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyebrowRightOuterDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeRightInnerDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeRightTopDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeRightBottomDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class EyeRightOuterDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseRootLeftDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseRootRightDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseLeftAlarTopDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseRightAlarTopDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseLeftAlarOutTipDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class NoseRightAlarOutTipDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class UpperLipTopDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class UpperLipBottomDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class UnderLipTopDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class UnderLipBottomDto
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class FaceLandmarksDto
    {
        [JsonProperty("pupilLeft")]
        public PupilLeftDto PupilLeft { get; set; }

        [JsonProperty("pupilRight")]
        public PupilRightDto PupilRight { get; set; }

        [JsonProperty("noseTip")]
        public NoseTipDto NoseTip { get; set; }

        [JsonProperty("mouthLeft")]
        public MouthLeftDto MouthLeft { get; set; }

        [JsonProperty("mouthRight")]
        public MouthRightDto MouthRight { get; set; }

        [JsonProperty("eyebrowLeftOuter")]
        public EyebrowLeftOuterDto EyebrowLeftOuter { get; set; }

        [JsonProperty("eyebrowLeftInner")]
        public EyebrowLeftInnerDto EyebrowLeftInner { get; set; }

        [JsonProperty("eyeLeftOuter")]
        public EyeLeftOuterDto EyeLeftOuter { get; set; }

        [JsonProperty("eyeLeftTop")]
        public EyeLeftTopDto EyeLeftTop { get; set; }

        [JsonProperty("eyeLeftBottom")]
        public EyeLeftBottomDto EyeLeftBottom { get; set; }

        [JsonProperty("eyeLeftInner")]
        public EyeLeftInnerDto EyeLeftInner { get; set; }

        [JsonProperty("eyebrowRightInner")]
        public EyebrowRightInnerDto EyebrowRightInner { get; set; }

        [JsonProperty("eyebrowRightOuter")]
        public EyebrowRightOuterDto EyebrowRightOuter { get; set; }

        [JsonProperty("eyeRightInner")]
        public EyeRightInnerDto EyeRightInner { get; set; }

        [JsonProperty("eyeRightTop")]
        public EyeRightTopDto EyeRightTop { get; set; }

        [JsonProperty("eyeRightBottom")]
        public EyeRightBottomDto EyeRightBottom { get; set; }

        [JsonProperty("eyeRightOuter")]
        public EyeRightOuterDto EyeRightOuter { get; set; }

        [JsonProperty("noseRootLeft")]
        public NoseRootLeftDto NoseRootLeft { get; set; }

        [JsonProperty("noseRootRight")]
        public NoseRootRightDto NoseRootRight { get; set; }

        [JsonProperty("noseLeftAlarTop")]
        public NoseLeftAlarTopDto NoseLeftAlarTop { get; set; }

        [JsonProperty("noseRightAlarTop")]
        public NoseRightAlarTopDto NoseRightAlarTop { get; set; }

        [JsonProperty("noseLeftAlarOutTip")]
        public NoseLeftAlarOutTipDto NoseLeftAlarOutTip { get; set; }

        [JsonProperty("noseRightAlarOutTip")]
        public NoseRightAlarOutTipDto NoseRightAlarOutTip { get; set; }

        [JsonProperty("upperLipTop")]
        public UpperLipTopDto UpperLipTop { get; set; }

        [JsonProperty("upperLipBottom")]
        public UpperLipBottomDto UpperLipBottom { get; set; }

        [JsonProperty("underLipTop")]
        public UnderLipTopDto UnderLipTop { get; set; }

        [JsonProperty("underLipBottom")]
        public UnderLipBottomDto UnderLipBottom { get; set; }
    }

    public class FacialHairDto
    {
        [JsonProperty("moustache")]
        public double Moustache { get; set; }

        [JsonProperty("beard")]
        public double Beard { get; set; }

        [JsonProperty("sideburns")]
        public double Sideburns { get; set; }
    }

    public class HeadPoseDto
    {
        [JsonProperty("roll")]
        public double Roll { get; set; }

        [JsonProperty("yaw")]
        public double Yaw { get; set; }

        [JsonProperty("pitch")]
        public double Pitch { get; set; }
    }

    public class EmotionDto
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

    public class HairColorDto
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class HairDto
    {
        [JsonProperty("bald")]
        public double Bald { get; set; }

        [JsonProperty("invisible")]
        public bool Invisible { get; set; }

        [JsonProperty("hairColor")]
        public List<HairColorDto> HairColor { get; set; }
    }

    public class MakeupDto
    {
        [JsonProperty("eyeMakeup")]
        public bool EyeMakeup { get; set; }

        [JsonProperty("lipMakeup")]
        public bool LipMakeup { get; set; }
    }

    public class OcclusionDto
    {
        [JsonProperty("foreheadOccluded")]
        public bool ForeheadOccluded { get; set; }

        [JsonProperty("eyeOccluded")]
        public bool EyeOccluded { get; set; }

        [JsonProperty("mouthOccluded")]
        public bool MouthOccluded { get; set; }
    }

    public class AccessoryDto
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

    }

    public class BlurDto
    {
        [JsonProperty("blurLevel")]
        public string BlurLevel { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ExposureDto
    {
        [JsonProperty("exposureLevel")]
        public string ExposureLevel { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class NoiseDto
    {
        [JsonProperty("noiseLevel")]
        public string NoiseLevel { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FaceAttributesDto
    {
        [JsonProperty("age")]
        public double Age { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("smile")]
        public double Smile { get; set; }

        [JsonProperty("facialHair")]
        public FacialHairDto FacialHair { get; set; }

        [JsonProperty("glasses")]
        public string Glasses { get; set; }

        [JsonProperty("headPose")]
        public HeadPoseDto HeadPose { get; set; }

        [JsonProperty("emotion")]
        public EmotionDto Emotion { get; set; }

        [JsonProperty("hair")]
        public HairDto Hair { get; set; }

        [JsonProperty("makeup")]
        public MakeupDto Makeup { get; set; }

        [JsonProperty("occlusion")]
        public OcclusionDto Occlusion { get; set; }

        [JsonProperty("accessories")]
        public List<AccessoryDto> Accessories { get; set; }

        [JsonProperty("blur")]
        public BlurDto Blur { get; set; }

        [JsonProperty("exposure")]
        public ExposureDto Exposure { get; set; }

        [JsonProperty("noise")]
        public NoiseDto Noise { get; set; }
    }
}
