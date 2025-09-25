namespace Mytra.Core
{
    public interface ICollegeService
    {
		Task<Utilize.DataService<College>> InsertAsync(Utilize.CollegeInsert Model);
		Task<Utilize.DataService<College>> UpdateAsync(Utilize.CollegeUpdate Model);
		Task<Utilize.DataService<College>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<College>> SelectAsync(Utilize.CollegeSelect Model);
		Task<Utilize.DataService<College>> SelectSingleAsync(Utilize.CollegeSelectSingle Model);
	}
}