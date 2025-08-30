namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class LanguageService : BusinessObject<Language>, ILanguageService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Language> Validator;

		public LanguageService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Language> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<LanguageResponse>> InsertAsync(LanguageInsert Model)
		{
			Data = Mapper.Map<Language>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<Language>(Data);
			await UnitOfWork.Language.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<LanguageResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<LanguageResponse>(Data)
			};
		}

		public async Task<ServiceResponse<LanguageResponse>> UpdateAsync(LanguageUpdate Model)
		{
			Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			Language Language = Collection.SingleOrDefault()!;
			Language.Name = Model.Name;
			await UnitOfWork.Language.UpdateAsync(Language);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<LanguageResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<LanguageResponse>(Language)
			};
		}

		public async Task<ServiceResponse<LanguageResponse>> DeleteAsync(LanguageDelete Model)
		{
			Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			Language Language = Collection.SingleOrDefault()!;
			await UnitOfWork.Language.DeleteAsync(Language);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<LanguageResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<LanguageResponse>(Language)
			};
		}

		public async Task<ServiceResponse<LanguageResponse>> SelectAsync(LanguageSelect Model)
		{
			return new ServiceResponse<LanguageResponse>
			{
				ResponseDataSource = Mapper.Map<List<LanguageResponse>>
				(await UnitOfWork.Language.SelectAsync(x => x.IsActive == true))
			};
		}

		public async Task<ServiceResponse<LanguageResponse>> SelectSingleAsync(LanguageSelectSingle Model)
		{
			return new ServiceResponse<LanguageResponse>
			{
				ResponseDataSource = Mapper.Map<List<LanguageResponse>>
				(await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
			};
		}
	}
}