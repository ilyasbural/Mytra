namespace Mytra.Core
{
    public class CategoryResponse : BaseResponse<CategoryResponse>
    {
        public Category Category { get; set; } = null!; 
    }
}