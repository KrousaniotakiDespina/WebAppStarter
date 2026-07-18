namespace WebAppStarter.DTO
{
    public record TeacherReadOnlyDTO(int Id, string? Firstname, string? Lastname)
    {
        public TeacherReadOnlyDTO() : this(default, default, default) { }
    }
}