namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidatePhotoService : ICandidatePhotoService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidatePhoto> Validator;

		public CandidatePhotoService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidatePhoto> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> InsertAsync(CandidatePhotoInsert Model)
		{
			return new ServiceResponse<CandidatePhotoResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> UpdateAsync(CandidatePhotoUpdate Model)
		{
			return new ServiceResponse<CandidatePhotoResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> DeleteAsync(CandidatePhotoDelete Model)
		{
			return new ServiceResponse<CandidatePhotoResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> SelectAsync(CandidatePhotoSelect Model)
		{
			return new ServiceResponse<CandidatePhotoResponse>()
			{
				//ResponseDataSource = new List<CandidatePhotoResponse>()
				//{
				//	new CandidatePhotoResponse()
				//	{
				//		Id = 1,
				//		CandidateId = 1,
				//		PhotoPath = "path/to/photo1.jpg",
				//		CreatedAt = DateTime.UtcNow,
				//		UpdatedAt = DateTime.UtcNow
				//	},
				//	new CandidatePhotoResponse()
				//	{
				//		Id = 2,
				//		CandidateId = 2,
				//		PhotoPath = "path/to/photo2.jpg",
				//		CreatedAt = DateTime.UtcNow,
				//		UpdatedAt = DateTime.UtcNow
				//	}
				//},
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> SelectSingleAsync(CandidatePhotoSelectSingle Model)
		{
			return new ServiceResponse<CandidatePhotoResponse>()
			{
				//ResponseDataSource = new List<CandidatePhotoResponse>()
				//{
				//	new CandidatePhotoResponse()
				//	{
				//		Id = Model.Id,
				//		CandidateId = 1,
				//		PhotoPath = "path/to/photo1.jpg",
				//		CreatedAt = DateTime.UtcNow,
				//		UpdatedAt = DateTime.UtcNow
				//	}
				//},
				//Success = 1
			};
		}
	}
}