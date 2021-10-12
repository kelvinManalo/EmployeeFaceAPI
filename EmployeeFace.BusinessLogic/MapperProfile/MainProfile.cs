using AutoMapper;
using EmployeeFace.BusinessLogic.DataTransferObjects.Face;
using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroup;
using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPerson;
using EmployeeFace.BusinessLogic.DataTransferObjects.PersonGroupPersonFace;
using EmployeeFace.Service.Entities.Face;
using EmployeeFace.Service.Entities.PersonGroup;
using EmployeeFace.Service.Entities.PersonGroupPerson;
using EmployeeFace.Service.Entities.PersonGroupPersonFace;

namespace EmployeeFace.BusinessLogic.MapperProfile
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            PersonGroup();
            PersonGroupPerson();
            PersonGroupPersonFace();
            Face();
        }

        private void PersonGroup()
        {
            CreateMap<PersonGroupServiceListOutput, PersonGroupServiceListOutputDto>().ReverseMap();
            CreateMap<PersonGroupServiceCreateInputDto, PersonGroupServiceCreateInput>().ReverseMap();
            CreateMap<PersonGroupServiceUpdateInputDto, PersonGroupServiceUpdateInput>().ReverseMap();
        }

        private void PersonGroupPerson()
        {
            CreateMap<PersonGroupPersonCreateInputDto, PersonGroupPersonCreateInput>().ReverseMap();
            CreateMap<PersonGroupGetTrainingOutput, PersonGroupGetTrainingOutputDto>().ReverseMap();
            CreateMap<PersonGroupPersonItemOutput, PersonGroupPersonItemOutputDto>().ReverseMap();
            CreateMap<PersonGroupPersonListOutput, PersonGroupPersonListOutputDto>().ReverseMap();
            CreateMap<PersonGroupPersonUpdateInputDto, PersonGroupPersonUpdateInput>().ReverseMap();
            CreateMap<PersonGroupPersonCreateOutput, PersonGroupPersonCreateOutputDto>().ReverseMap();
        }

        private void PersonGroupPersonFace()
        {
            CreateMap<PersonGroupPersonFaceCreateOutput, PersonGroupPersonFaceCreateOutputDto>().ReverseMap();
            CreateMap<PersonGroupPersonFaceCreateInputDto, PersonGroupPersonFaceCreateInput>().ReverseMap();
            CreateMap<PersonGroupPersonFaceGetOutput, PersonGroupPersonFaceGetOutputDto>().ReverseMap();
            CreateMap<PersonGroupPersonFaceUpdateInputDto, PersonGroupPersonFaceUpdateInput>().ReverseMap();
        }

        private void Face()
        {
            CreateMap<FaceDetectOutput, FaceDetectOutputDto>().ReverseMap();
            CreateMap<FaceRectangle, FaceRectangleDto>().ReverseMap();
            CreateMap<PupilLeft, PupilLeftDto>().ReverseMap();
            CreateMap<PupilRight, PupilRightDto>().ReverseMap();
            CreateMap<NoseTip, NoseTipDto>().ReverseMap();
            CreateMap<MouthLeft, MouthLeftDto>().ReverseMap();
            CreateMap<MouthRight, MouthRightDto>().ReverseMap();
            CreateMap<EyebrowLeftOuter, EyebrowLeftOuterDto>().ReverseMap();
            CreateMap<EyebrowLeftInner, EyebrowLeftInnerDto>().ReverseMap();
            CreateMap<EyeLeftOuter, EyeLeftOuterDto>().ReverseMap();
            CreateMap<EyeLeftTop, EyeLeftTopDto>().ReverseMap();
            CreateMap<EyeLeftBottom, EyeLeftBottomDto>().ReverseMap();
            CreateMap<EyeLeftInner, EyeLeftInnerDto>().ReverseMap();
            CreateMap<EyebrowRightInner, EyebrowRightInnerDto>().ReverseMap();
            CreateMap<EyebrowRightOuter, EyebrowRightOuterDto>().ReverseMap();
            CreateMap<EyeRightInner, EyeRightInnerDto>().ReverseMap();
            CreateMap<EyeRightTop, EyeRightTopDto>().ReverseMap();
            CreateMap<EyeRightBottom, EyeRightBottomDto>().ReverseMap();
            CreateMap<EyeRightOuter, EyeRightOuterDto>().ReverseMap();
            CreateMap<NoseRootLeft, NoseRootLeftDto>().ReverseMap();
            CreateMap<NoseRootRight, NoseRootRightDto>().ReverseMap();
            CreateMap<NoseLeftAlarTop, NoseLeftAlarTopDto>().ReverseMap();
            CreateMap<NoseRightAlarTop, NoseRightAlarTopDto>().ReverseMap();
            CreateMap<NoseLeftAlarOutTip, NoseLeftAlarOutTipDto>().ReverseMap();
            CreateMap<NoseRightAlarOutTip, NoseRightAlarOutTipDto>().ReverseMap();
            CreateMap<UpperLipTop, UpperLipTopDto>().ReverseMap();
            CreateMap<UpperLipBottom, UpperLipBottomDto>().ReverseMap();
            CreateMap<UnderLipTop, UnderLipTopDto>().ReverseMap();
            CreateMap<UnderLipBottom, UnderLipBottomDto>().ReverseMap();
            CreateMap<FaceLandmarks, FaceLandmarksDto>().ReverseMap();
            CreateMap<FacialHair, FacialHairDto>().ReverseMap();
            CreateMap<HeadPose, HeadPoseDto>().ReverseMap();
            CreateMap<Emotion, EmotionDto>().ReverseMap();
            CreateMap<HairColor, HairColorDto>().ReverseMap();
            CreateMap<Hair, HairDto>().ReverseMap();
            CreateMap<Makeup, MakeupDto>().ReverseMap();
            CreateMap<Occlusion, OcclusionDto>().ReverseMap();
            CreateMap<Accessory, AccessoryDto>().ReverseMap();
            CreateMap<Blur, BlurDto>().ReverseMap();
            CreateMap<Exposure, ExposureDto>().ReverseMap();
            CreateMap<Noise, NoiseDto>().ReverseMap();
            CreateMap<FaceAttributes, FaceAttributesDto>().ReverseMap();
            CreateMap<FaceDetectInputDto, FaceDetectInput>().ReverseMap();

            CreateMap<FaceIdentifyInputDto, FaceIdentifyInput>().ReverseMap();
            CreateMap<FaceIdentifyOutput, FaceIdentifyOutputDto>().ReverseMap();
            CreateMap<Candidates, CandidatesDto>().ReverseMap();


        }
    }
}
