namespace Mytra.Core
{
    public interface IInstitutionService
    {
		Task<Common.ServiceResponse<Common.InstitutionResponse>> InsertAsync(Common.InstitutionInsert Model);
		Task<Common.ServiceResponse<Common.InstitutionResponse>> UpdateAsync(Common.InstitutionUpdate Model);
		Task<Common.ServiceResponse<Common.InstitutionResponse>> DeleteAsync(Common.InstitutionDelete Model);
		Task<Common.ServiceResponse<Common.InstitutionResponse>> SelectAsync(Common.InstitutionSelect Model);
		Task<Common.ServiceResponse<Common.InstitutionResponse>> SelectSingleAsync(Common.InstitutionSelectSingle Model);
	}
}