namespace Mytra.Service
{
	using Core;
	using Utilize;
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
				if (Collection == null) return DataService<Candidate>.FailureResult("");
				return DataService<Candidate>.SuccessResult(Collection.OrderByDescending(x => x.Id).FirstOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "");
			}
		}
	}
}