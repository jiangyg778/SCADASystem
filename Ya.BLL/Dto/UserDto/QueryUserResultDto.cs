namespace Ya.BLL
{
    public class QueryUserResultDto : BaseDto
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Role { get; set; }
    }
}