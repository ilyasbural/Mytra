namespace Mytra.Core
{
	public interface ICandidateLoginService
	{
		Task<Utilize.DataService<Candidate>> LoginAsync(Utilize.CandidateLogin Model);
	}
}