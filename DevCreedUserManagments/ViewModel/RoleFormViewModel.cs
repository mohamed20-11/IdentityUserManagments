using System.ComponentModel.DataAnnotations;

namespace DevCreedUserManagments.ViewModel
{
    public class RoleFormViewModel
    {
        [Required , StringLength(256)]
        public string Name { get; set; }
    }
}
