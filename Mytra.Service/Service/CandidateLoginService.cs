namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateLoginService : BusinessObject<Candidate>, ICandidateLoginService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Candidate> Validator;

		public CandidateLoginService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Candidate> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<Candidate>> LoginAsync(CandidateLogin Model)
		{
			try
			{
				Collection = await UnitOfWork.Candidate.SelectAsync(x => x.Email == Model.Email && x.Password == Model.Password && x.IsActive);
				if (Collection == null) return DataService<Candidate>.FailureResult("Kayıt bulunamadı");
				return DataService<Candidate>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}