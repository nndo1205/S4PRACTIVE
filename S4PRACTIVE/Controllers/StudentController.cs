using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    public class StudentController : Controller
    {
        [Route("HomeStudent")]
        [Route("Student")]
        [Route("Student/ListAll")]
        [Route("Liet-ke-danh-sach-sinh-vien")]
        public string ListAll()
        {
            return "Liệt kê danh sách sinh viên";
        }
        public ContentResult Index()
        {
            return new ContentResult()
            {
                Content = "Welcome to Student Page",
             ContentType = "text/plain"
            };
        }
        [Route("File/Download-file")]
        public FileResult  Index()
        {   
            return File("/ling.pdf","application/pdf");
        }
        public string ListOnlyOne()
        {
            return "Liệt kê một sinh viên có id cụ thể";
        }

        public string EditStudent()
        {
            return "Chỉnh sửa thông tin một sinh viên có id cụ thể";
        }

        public string AddStudent()
        {
            return "Thêm thông tin một sinh viên";
        }

        public string DelStudent()
        {
            return "Xóa thông tin một sinh viên";
        }
    }
}
