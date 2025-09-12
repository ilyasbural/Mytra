namespace Mytra.Core
{
    public interface ICollegeService
    {
		Task<Common.DataService<College>> InsertAsync(Common.CollegeInsert Model);
		Task<Common.DataService<College>> UpdateAsync(Common.CollegeUpdate Model);
		Task<Common.DataService<College>> DeleteAsync(Guid Id);
		Task<Common.DataService<College>> SelectAsync(Common.CollegeSelect Model);
		Task<Common.DataService<College>> SelectSingleAsync(Common.CollegeSelectSingle Model);
	}
}