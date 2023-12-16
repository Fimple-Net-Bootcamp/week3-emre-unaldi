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
    public class PetManager : IPetService
    {
        IPetDal _petDal;
        IMapper _mapper;

        public PetManager(IPetDal petDal, IMapper mapper)
        {
            _petDal = petDal;
            _mapper = mapper;
        }

        public IResult Add(AddPetRequest addPetRequest)
        {
            try
            {
                Pet pet = _mapper.Map<Pet>(addPetRequest);
                _petDal.Add(pet);

                return new SuccessResult("Pet added successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Update(UpdatePetRequest updatePetRequest)
        {
            try
            {
                Pet pet = _mapper.Map<Pet>(updatePetRequest);
                _petDal.Update(pet);

                return new SuccessResult("Pet updated successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(int petId)
        {
            try
            {
                Pet pet = _petDal.Get(pet => pet.Id == petId);
                _petDal.Delete(pet);

                return new SuccessResult("Pet deleted successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<GetPetResponse>> GetAll()
        {
            try
            {
                List<GetPetResponse> pets = _mapper.Map<List<GetPetResponse>>(_petDal.GetAll());

                return new SuccessDataResult<List<GetPetResponse>>(pets, "Pets listed successfully");

            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<GetPetResponse>>(ex.Message);
            }
        }

        public IDataResult<GetPetResponse> GetPetById(int petId)
        {
            try
            {
                GetPetResponse pet = _mapper.Map<GetPetResponse>(_petDal.Get(pet => pet.Id == petId));
                return new SuccessDataResult<GetPetResponse>(pet, "Pet listed successfully");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<GetPetResponse>(ex.Message);
            }
        }
    }
}
