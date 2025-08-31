namespace Mytra.Core
{
    public interface ICollegeService
    {
		Task<Common.DataService<College>> InsertAsync(Common.CollegeInsert Model);
		//Task<Common.ServiceResponse<Common.CollegeResponse>> UpdateAsync(Common.CollegeUpdate Model);
		//Task<Common.ServiceResponse<Common.CollegeResponse>> DeleteAsync(Common.CollegeDelete Model);
		//Task<Common.ServiceResponse<Common.CollegeResponse>> SelectAsync(Common.CollegeSelect Model);
		//Task<Common.ServiceResponse<Common.CollegeResponse>> SelectSingleAsync(Common.CollegeSelectSingle Model);
	}
}