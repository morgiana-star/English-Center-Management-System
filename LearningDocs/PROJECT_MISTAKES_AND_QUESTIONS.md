# NHẬT KÝ CÂU HỎI, LỖI SAI VÀ ÔN TẬP BẢO VỆ (`PROJECT_MISTAKES_AND_QUESTIONS.md`)

> Tài liệu này theo dõi những điểm cần ôn tập, câu hỏi kiểm tra sau mỗi buổi học và các câu hỏi phản biện giảng viên có thể đặt ra khi bảo vệ đồ án ECMS.

---

## 1. Các điểm cần lưu ý sớm khi bảo vệ đồ án (Phát hiện từ Giai đoạn 1)

1. **Tại sao `ECMS.UI` lại tham chiếu trực tiếp `ECMS.Data`?**
   - Cần giải thích được: (a) `Program.cs` gọi `DatabaseInitializer.Initialize()`, (b) một số màn hình (`ClassAttendanceDialog`, `CreateClassDialog`, `TeacherAttendanceCheckView`, `SystemConfigView`, `CreateBackupDialog`) đang truy cập trực tiếp `DatabaseConfig` / `Dapper` — đây là điểm phá vỡ chuẩn kiến trúc phân tầng cần nhận diện trung thực.
2. **Tại sao có tới 2 nơi lưu phiên đăng nhập (`SessionManager` và `AppSession`)?**
   - Cần hiểu sự khác nhau giữa tầng Business và UI, và lưu ý `HandleLogout()` hiện chưa gọi `SessionManager.ClearSession()`.
3. **Tại sao có 2 class cùng tên `CertificateService`?**
   - `ECMS.Business.Services.CertificateService` (dùng SQLite) và `ECMS.UI.Services.CertificateService` (dữ liệu giả lập trong RAM dùng làm fallback).

---

## 2. Nhật ký trả lời câu hỏi theo từng buổi học

*(Sẽ được cập nhật sau mỗi bài kiểm tra ở Bước 7 của từng chủ đề.)*
