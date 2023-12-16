using AutoMapper;
using VirtualPetCareWebAPI.Business.Abstracts;
using VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts;
using VirtualPetCareWebAPI.Core.Utilities.Results.Concretes;
using VirtualPetCareWebAPI.DataAccess.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Entities;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;
using VirtualPetCareWebAPI.Entity.Concretes.Responses;

namespace VirtualPetCareWebAPI.Business.Concretes
{
    public class HealthStatusManager : IHealthStatusService
    {
        IHealthStatusDal _healthStatusDal;
        IMapper _mapper;

        public HealthStatusManager(IHealthStatusDal healthStatusDal, IMapper mapper)
        {
            _healthStatusDal = healthStatusDal;
            _mapper = mapper;
        }

        public IResult Add(AddHealthStatusRequest addHealthStatusRequest)
        {
            try
            {
                HealthStatus healthStatus = _mapper.Map<HealthStatus>(addHealthStatusRequest);
                _healthStatusDal.Add(healthStatus);

                return new SuccessResult("Health Status added successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Update(UpdateHealthStatusRequest updateHealthStatusRequest)
        {
            try
            {
                HealthStatus healthStatus = _mapper.Map<HealthStatus>(updateHealthStatusRequest);
                _healthStatusDal.Update(healthStatus);

                return new SuccessResult("Health Status updated successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(int healthStatusId)
        {
            try
            {
                HealthStatus healthStatus = _healthStatusDal.Get(healthStatus => healthStatus.Id == healthStatusId); 
                _healthStatusDal.Delete(healthStatus);

                return new SuccessResult("Health Status deleted successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<GetHealthStatusResponse>> GetAll()
        {
            try
            {
                List<GetHealthStatusResponse> healthStatus = _mapper.Map<List<GetHealthStatusResponse>>(_healthStatusDal.GetAll());

                return new SuccessDataResult<List<GetHealthStatusResponse>>(healthStatus, "Health conditions listed successfully");

            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<GetHealthStatusResponse>>(ex.Message);
            }
        }

        public IDataResult<GetHealthStatusResponse> GetHealthStatusById(int healthStatusId)
        {
            try
            {
                GetHealthStatusResponse healthStatus = _mapper.Map<GetHealthStatusResponse>(_healthStatusDal.Get(healthStatus => healthStatus.Id == healthStatusId));
                
                return new SuccessDataResult<GetHealthStatusResponse>(healthStatus, "Health Status listed successfully");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<GetHealthStatusResponse>(ex.Message);
            }
        }
    }
}
