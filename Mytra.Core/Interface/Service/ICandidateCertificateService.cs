namespace Mytra.Core
{
    public interface ICandidateCertificateService
    {
		Task<Common.DataService<CandidateCertificate>> InsertAsync(Common.CandidateCertificateInsert Model);
		Task<Common.DataService<CandidateCertificate>> UpdateAsync(Common.CandidateCertificateUpdate Model);
		Task<Common.DataService<CandidateCertificate>> DeleteAsync(Guid Id);
		Task<Common.DataService<CandidateCertificate>> SelectAsync(Common.CandidateCertificateSelect Model);
		Task<Common.DataService<CandidateCertificate>> SelectSingleAsync(Common.CandidateCertificateSelectSingle Model);
	}
}