namespace Mytra.Core
{
    public interface ICandidatePhotoService
    {
		Task<Common.DataService<CandidatePhoto>> InsertAsync(Common.CandidatePhotoInsert Model);
		Task<Common.DataService<CandidatePhoto>> UpdateAsync(Common.CandidatePhotoUpdate Model);
		Task<Common.DataService<CandidatePhoto>> DeleteAsync(Guid Id);
		Task<Common.DataService<CandidatePhoto>> SelectAsync(Common.CandidatePhotoSelect Model);
		Task<Common.DataService<CandidatePhoto>> SelectSingleAsync(Common.CandidatePhotoSelectSingle Model);
	}
}