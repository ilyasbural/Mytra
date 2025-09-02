namespace Mytra.Core
{
	public interface ICandidateLoginService
	{
		Task<Common.DataService<Candidate>> LoginAsync(Common.CandidateLogin Model);
	}
}