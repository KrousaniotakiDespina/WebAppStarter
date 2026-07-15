namespace WebAppStarter.DTO
{
    public record StudentReadOnlyDTO(int Id, string? Firstname, string? Lastname)
    {
        public StudentReadOnlyDTO() : this(default, default, default) { }
    }
}
