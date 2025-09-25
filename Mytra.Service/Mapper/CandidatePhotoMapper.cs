namespace Mytra.Service
{
	public class CandidatePhotoMapper : AutoMapper.Profile
	{
		public CandidatePhotoMapper()
		{
			CreateMap<Utilize.CandidatePhotoInsert, Core.CandidatePhoto>().ReverseMap();
			CreateMap<Utilize.CandidatePhotoUpdate, Core.CandidatePhoto>().ReverseMap();
			CreateMap<Utilize.CandidatePhotoSelect, Core.CandidatePhoto>().ReverseMap();
			CreateMap<Utilize.CandidatePhotoSelectSingle, Core.CandidatePhoto>().ReverseMap();
			CreateMap<Utilize.CandidatePhotoResponse, Core.CandidatePhoto>().ReverseMap();
		}
	}
}