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
    public class ActivityManager : IActivityService
    {
        IActivityDal _activityDal;
        IMapper _mapper;

        public ActivityManager(IActivityDal activityDal, IMapper mapper)
        {
            _activityDal = activityDal;
            _mapper = mapper;
        }

        public IResult Add(AddActivityRequest addActivityRequest)
        {
            try
            {
                Activity activity = _mapper.Map<Activity>(addActivityRequest);
                _activityDal.Add(activity);

                return new SuccessResult("Activity added successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Update(UpdateActivityRequest updateActivityRequest)
        {
            try
            {
                Activity activity = _mapper.Map<Activity>(updateActivityRequest);
                _activityDal.Update(activity);

                return new SuccessResult("Activity updated successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(int activityId)
        {
            try
            {
                Activity activity = _activityDal.Get(activity => activity.Id == activityId);
                _activityDal.Delete(activity);

                return new SuccessResult("Activity deleted successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<GetActivityResponse>> GetAll()
        {
            try
            {
                List<GetActivityResponse> activities = _mapper.Map<List<GetActivityResponse>>(_activityDal.GetAll());

                return new SuccessDataResult<List<GetActivityResponse>>(activities, "Activities listed successfully");

            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<GetActivityResponse>>(ex.Message);
            }
        }

        public IDataResult<GetActivityResponse> GetActivityById(int activityId)
        {
            try
            {
                GetActivityResponse activity = _mapper.Map<GetActivityResponse>(_activityDal.Get(activity => activity.Id == activityId));
                return new SuccessDataResult<GetActivityResponse>(activity, "Activity listed successfully");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<GetActivityResponse>(ex.Message);
            }
        }
    }
}
