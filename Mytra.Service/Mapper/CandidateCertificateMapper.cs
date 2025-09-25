namespace Mytra.Service
{
	public class CandidateCertificateMapper : AutoMapper.Profile
	{
		public CandidateCertificateMapper()
		{
			CreateMap<Common.CandidateCertificateInsert, Core.CandidateCertificate>().ReverseMap();
			CreateMap<Common.CandidateCertificateUpdate, Core.CandidateCertificate>().ReverseMap();
			CreateMap<Common.CandidateCertificateSelect, Core.CandidateCertificate>().ReverseMap();
			CreateMap<Common.CandidateCertificateSelectSingle, Core.CandidateCertificate>().ReverseMap();
			CreateMap<Common.CandidateCertificateResponse, Core.CandidateCertificate>().ReverseMap();
		}
	}
}