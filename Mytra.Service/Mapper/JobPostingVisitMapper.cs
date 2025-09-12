namespace Mytra.Service
{
	public class JobPostingVisitMapper : AutoMapper.Profile
	{
		public JobPostingVisitMapper()
		{
			CreateMap<Common.JobPostingVisitInsert, Core.JobPostingVisit>().ReverseMap();
			CreateMap<Common.JobPostingVisitUpdate, Core.JobPostingVisit>().ReverseMap();
			CreateMap<Common.JobPostingVisitSelect, Core.JobPostingVisit>().ReverseMap();
			CreateMap<Common.JobPostingVisitSelectSingle, Core.JobPostingVisit>().ReverseMap();
			CreateMap<Common.JobPostingVisitResponse, Core.JobPostingVisit>().ReverseMap();
		}
	}
}