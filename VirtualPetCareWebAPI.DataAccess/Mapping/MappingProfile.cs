using AutoMapper;
using VirtualPetCareWebAPI.Entity.Concretes.Entities;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;
using VirtualPetCareWebAPI.Entity.Concretes.Responses;

namespace VirtualPetCareWebAPI.DataAccess.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // User
            CreateMap<User, AddUserRequest>().ReverseMap();
            CreateMap<User, UpdateUserRequest>().ReverseMap();
            CreateMap<User, GetUserResponse>().ReverseMap();

            // Pet
            CreateMap<Pet, AddPetRequest>().ReverseMap();
            CreateMap<Pet, UpdatePetRequest>().ReverseMap();
            CreateMap<Pet, GetPetResponse>().ReverseMap();

            // HealthStatus
            CreateMap<HealthStatus, AddHealthStatusRequest>().ReverseMap();
            CreateMap<HealthStatus, UpdateHealthStatusRequest>().ReverseMap();
            CreateMap<HealthStatus, GetHealthStatusResponse>().ReverseMap();

            // Food
            CreateMap<Food, AddFoodRequest>().ReverseMap();
            CreateMap<Food, UpdateFoodRequest>().ReverseMap();
            CreateMap<Food, GetFoodResponse>().ReverseMap();

            // Activity
            CreateMap<Activity, AddActivityRequest>().ReverseMap();
            CreateMap<Activity, UpdateActivityRequest>().ReverseMap();
            CreateMap<Activity, GetActivityResponse>().ReverseMap();


            CreateMap<GetActivityPetResponse, Pet>().ReverseMap();
            CreateMap<GetFoodPetResponse, Pet>().ReverseMap();
            CreateMap<GetHealthStatusPetResponse, Pet>().ReverseMap();
            CreateMap<GetUserPetResponse, Pet>().ReverseMap();

            CreateMap<GetPetActivityResponse, Activity>().ReverseMap();
            CreateMap<GetPetFoodResponse, Food>().ReverseMap();
            CreateMap<GetPetHealthStatusResponse, HealthStatus>().ReverseMap();
            CreateMap<GetPetUserResponse, User>().ReverseMap();
        }
    }
}
