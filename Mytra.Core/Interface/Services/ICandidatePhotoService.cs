namespace Mytra.Core
{
    public interface ICandidatePhotoService
    {
		Task<Utilize.DataService<CandidatePhoto>> InsertAsync(Utilize.CandidatePhotoInsert Model);
		Task<Utilize.DataService<CandidatePhoto>> UpdateAsync(Utilize.CandidatePhotoUpdate Model);
		Task<Utilize.DataService<CandidatePhoto>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidatePhoto>> SelectAsync(Utilize.CandidatePhotoSelect Model);
		Task<Utilize.DataService<CandidatePhoto>> SelectSingleAsync(Utilize.CandidatePhotoSelectSingle Model);
	}
}