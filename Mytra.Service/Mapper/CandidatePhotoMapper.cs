namespace Mytra.Service
{
	public class CandidatePhotoMapper : AutoMapper.Profile
	{
		public CandidatePhotoMapper()
		{
			CreateMap<Common.CandidatePhotoInsert, Core.CandidatePhoto>().ReverseMap();
			CreateMap<Common.CandidatePhotoUpdate, Core.CandidatePhoto>().ReverseMap();
			CreateMap<Common.CandidatePhotoSelect, Core.CandidatePhoto>().ReverseMap();
			CreateMap<Common.CandidatePhotoSelectSingle, Core.CandidatePhoto>().ReverseMap();
			CreateMap<Common.CandidatePhotoResponse, Core.CandidatePhoto>().ReverseMap();
		}
	}
}