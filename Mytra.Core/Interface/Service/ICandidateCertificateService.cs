namespace Mytra.Core
{
    public interface ICandidateCertificateService
    {
		Task<Common.DataService<CandidateCertificate>> InsertAsync(Common.CandidateCertificateInsert Model);
		//Task<Common.ServiceResponse<Common.CandidateCertificateResponse>> UpdateAsync(Common.CandidateCertificateUpdate Model);
		//Task<Common.ServiceResponse<Common.CandidateCertificateResponse>> DeleteAsync(Common.CandidateCertificateDelete Model);
		//Task<Common.ServiceResponse<Common.CandidateCertificateResponse>> SelectAsync(Common.CandidateCertificateSelect Model);
		//Task<Common.ServiceResponse<Common.CandidateCertificateResponse>> SelectSingleAsync(Common.CandidateCertificateSelectSingle Model);
	}
}