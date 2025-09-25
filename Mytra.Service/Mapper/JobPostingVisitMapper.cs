namespace Mytra.Service
{
	public class JobPostingVisitMapper : AutoMapper.Profile
	{
		public JobPostingVisitMapper()
		{
			CreateMap<Utilize.JobPostingVisitInsert, Core.JobPostingVisit>().ReverseMap();
			CreateMap<Utilize.JobPostingVisitUpdate, Core.JobPostingVisit>().ReverseMap();
			CreateMap<Utilize.JobPostingVisitSelect, Core.JobPostingVisit>().ReverseMap();
			CreateMap<Utilize.JobPostingVisitSelectSingle, Core.JobPostingVisit>().ReverseMap();
			CreateMap<Utilize.JobPostingVisitResponse, Core.JobPostingVisit>().ReverseMap();
		}
	}
}