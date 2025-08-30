namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerSettingsService : BusinessObject<ManagerSettings>, IManagerSettingsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<ManagerSettings> Validator;

		public ManagerSettingsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagerSettings> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> InsertAsync(ManagerSettingsInsert Model)
		{
			Data = Mapper.Map<ManagerSettings>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<ManagerSettings>(Data);
			await UnitOfWork.ManagerSettings.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerSettingsResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerSettingsResponse>(Data)
			};
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> UpdateAsync(ManagerSettingsUpdate Model)
		{
			Collection = await UnitOfWork.ManagerSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			ManagerSettings ManagerSettings = Collection.SingleOrDefault()!;
			ManagerSettings.Name = Model.Name;
			await UnitOfWork.ManagerSettings.UpdateAsync(ManagerSettings);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerSettingsResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerSettingsResponse>(ManagerSettings)
			};
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> DeleteAsync(ManagerSettingsDelete Model)
		{
			Collection = await UnitOfWork.ManagerSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			ManagerSettings ManagerSettings = Collection.SingleOrDefault()!;
			await UnitOfWork.ManagerSettings.DeleteAsync(ManagerSettings);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerSettingsResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerSettingsResponse>(ManagerSettings)
			};
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> SelectAsync(ManagerSettingsSelect Model)
		{
			return new ServiceResponse<ManagerSettingsResponse>
			{
				ResponseDataSource = Mapper.Map<List<ManagerSettingsResponse>>
				(await UnitOfWork.ManagerSettings.SelectAsync(x => x.IsActive == true))
			};
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> SelectSingleAsync(ManagerSettingsSelectSingle Model)
		{
			return new ServiceResponse<ManagerSettingsResponse>
			{
				ResponseDataSource = Mapper.Map<List<ManagerSettingsResponse>>
				(await UnitOfWork.ManagerSettings.SelectAsync(x => x.IsActive == true))
			};
		}
	}
}