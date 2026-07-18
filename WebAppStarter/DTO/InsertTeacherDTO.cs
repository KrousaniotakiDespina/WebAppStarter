using System.ComponentModel.DataAnnotations;

namespace WebAppStarter.DTO
{
    public record InsertTeacherDTO
        (
            [property: Required(ErrorMessage = "Firstname is required.")]
            [property: MinLength(1, ErrorMessage = "Firstname must not be empty.")]
            string? Firstname,

            [property: Required(ErrorMessage = "Lastname is required.")]
            [property: MinLength(1, ErrorMessage = "Lastname must not be empty.")]
            string? Lastname,

            int SelectedCityId
        )
    {
        public InsertTeacherDTO() : this(default, default, default) { }
    }
}