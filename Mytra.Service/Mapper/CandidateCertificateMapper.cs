namespace Mytra.Service
{
	public class CandidateCertificateMapper : AutoMapper.Profile
	{
		public CandidateCertificateMapper()
		{
			CreateMap<Utilize.CandidateCertificateInsert, Core.CandidateCertificate>().ReverseMap();
			CreateMap<Utilize.CandidateCertificateUpdate, Core.CandidateCertificate>().ReverseMap();
			CreateMap<Utilize.CandidateCertificateSelect, Core.CandidateCertificate>().ReverseMap();
			CreateMap<Utilize.CandidateCertificateSelectSingle, Core.CandidateCertificate>().ReverseMap();
			CreateMap<Utilize.CandidateCertificateResponse, Core.CandidateCertificate>().ReverseMap();
		}
	}
}