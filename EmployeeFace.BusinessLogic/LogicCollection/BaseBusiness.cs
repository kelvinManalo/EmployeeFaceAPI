using AutoMapper;
using EmployeeFace.BusinessLogic.DataTransferObjects;
using EmployeeFace.Common.Entities;
using EmployeeFace.Common.Exceptions;
using EmployeeFace.Service.Entities;
using Newtonsoft.Json;

namespace EmployeeFace.BusinessLogic.LogicCollection
{
    public abstract class BaseBusiness<T>
    {
        protected BaseBusiness(IMapper mapper)
        {
            Mapper = mapper;
        }

        protected IMapper Mapper { get; }

        protected ResultGeneric<TOutput> GetResultGeneric<TOutput>(TOutput request)
        {
            var result = new ResultGeneric<TOutput>()
            {
                Data = request
            };

            return result;
        }

        protected abstract void ValidateResponse<TModel>(ApiResult<TModel> response);

        protected TReturn DeserializeResult<TReturn>(string rawData)
        {
            return JsonConvert.DeserializeObject<TReturn>(rawData);
        }

        protected BaseException GetBaseException(ErrorResponse errorResponse)
        {
            return new BaseException(errorResponse);
        }
    }
}
