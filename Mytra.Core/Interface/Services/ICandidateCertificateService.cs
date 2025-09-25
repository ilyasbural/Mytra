namespace Mytra.Core
{
    public interface ICandidateCertificateService
    {
		Task<Utilize.DataService<CandidateCertificate>> InsertAsync(Utilize.CandidateCertificateInsert Model);
		Task<Utilize.DataService<CandidateCertificate>> UpdateAsync(Utilize.CandidateCertificateUpdate Model);
		Task<Utilize.DataService<CandidateCertificate>> DeleteAsync(Guid Id);
		Task<Utilize.DataService<CandidateCertificate>> SelectAsync(Utilize.CandidateCertificateSelect Model);
		Task<Utilize.DataService<CandidateCertificate>> SelectSingleAsync(Utilize.CandidateCertificateSelectSingle Model);
	}
}