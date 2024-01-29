using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamDepartment.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Tên phòng ban là bắt buộc")]
        [StringLength(100, ErrorMessage = "Tên phòng ban không vượt quá 100 ký tự")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "Mã phòng ban là bắt buộc")]
        [StringLength(20, ErrorMessage = "Mã phòng ban không vượt quá 20 ký tự")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "Địa điểm là bắt buộc")]
        [StringLength(150, ErrorMessage = "Địa điểm không vượt quá 150 ký tự")]
        public string Location { get; set; }

        public int NumberOfEmployees { get; set; }

        // Navigation property để thiết lập mối quan hệ
        public virtual ICollection<Employee> Employees { get; set; }

        // Các trường khác có thể được thêm vào theo yêu cầu
    }
}
