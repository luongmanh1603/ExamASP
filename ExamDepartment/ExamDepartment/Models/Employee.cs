using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamDepartment.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Tên nhân viên là bắt buộc")]
        [StringLength(100, ErrorMessage = "Tên nhân viên không vượt quá 100 ký tự")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Mã nhân viên là bắt buộc")]
        [StringLength(20, ErrorMessage = "Mã nhân viên không vượt quá 20 ký tự")]
        public string EmployeeCode { get; set; }

        [Required(ErrorMessage = "Chức vụ là bắt buộc")]
        [StringLength(50, ErrorMessage = "Chức vụ không vượt quá 50 ký tự")]
        public string Rank { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }

        // Navigation property để thiết lập mối quan hệ
        public virtual Department Department { get; set; }

        // Các trường khác có thể được thêm vào theo yêu cầu
    }
}
