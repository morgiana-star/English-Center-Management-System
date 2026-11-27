# GHI CHÉP HỌC SÂU SOURCE CODE (`PROJECT_DEEP_NOTES.md`)

> Tài liệu này lưu lại kiến thức nền tảng C#/.NET, phân tích code thực tế, ví dụ minh họa và luồng thực thi sau từng buổi học.

---

## Lộ trình học tập (10 Module)

1. **Module 1:** Cấu trúc Solution, phụ thuộc giữa 4 tầng và các thư viện NuGet.
2. **Module 2:** Entry Point (`Program.cs`) và vòng đời khởi động WinForms.
3. **Module 3:** Cấu hình & Khởi tạo SQLite (`DatabaseConfig`, `DatabaseInitializer`, DDL & Seed Data).
4. **Module 4:** Tầng `ECMS.Core` — Entities, DTOs, Enums và `StatusFormatter`.
5. **Module 5:** Tầng `ECMS.Data` — `BaseRepository`, Dapper và mẫu thiết kế Repository.
6. **Module 6:** Tầng `ECMS.Business` — Services, xác thực BCrypt và quản lý phiên (`SessionManager`).
7. **Module 7:** Giao diện khởi đầu & Phân quyền RBAC (`LoginForm`, `AppSession`, `MainForm`).
8. **Module 8:** Hệ thống Custom Controls (`FigmaTheme`, `AppDialog`, `AppDataGrid`...) và cách WinForms vẽ UI.
9. **Module 9:** Học chuyên sâu theo từng chức năng hoàn chỉnh (End-to-End: Học viên, Khóa/Lớp/Lịch, Điểm danh/Điểm số, Tài chính/Học phí, Chứng chỉ, Tài khoản/Cấu hình/Dashboard).
10. **Module 10:** Đánh giá chất lượng code, phát hiện kỹ thuật nợ (technical debt) và chuẩn bị câu hỏi bảo vệ đồ án.

---

## Bài 1 (Module 1 & 2): Cấu trúc Solution & Entry Point (`Program.cs`)

- **4 tầng:** `ECMS.Core` (nền tảng, không tham chiếu ai) ← `ECMS.Data` (SQLite + Dapper) ← `ECMS.Business` (Services + `SessionManager`) ← `ECMS.UI` (`WinExe`, tham chiếu cả 3 project).
- **Entry Point (`ECMS.UI/Program.cs`):**
  1. `ApplicationConfiguration.Initialize()` — bật Visual Styles, DPI, font mặc định WinForms.
  2. `DatabaseInitializer.Initialize()` — tạo `%APPDATA%\ECMS\ecms_data.db`, 28 bảng và seed data.
  3. Tạo file mẫu `E:\ECMS\DanhSachHocVien_Import.xlsx` nếu thư mục `E:\ECMS` tồn tại và chưa có file.
  4. `try / catch` bọc bước 2–3 để báo lỗi qua `AppDialog.ShowError(...)` nếu DB lỗi.
  5. `Application.Run(new LoginForm())` — mở màn hình đăng nhập và chạy vòng lặp thông điệp WinForms.

---

## Bài 2 (Module 3): Cấu hình & Khởi tạo SQLite (`DatabaseConfig` & `DatabaseInitializer`)

- **`DatabaseConfig.cs`:**
  - Lưu file DB tại `%APPDATA%\ECMS\ecms_data.db` để đảm bảo luôn có quyền ghi.
  - `ConnectionString`: `Data Source=...;Mode=ReadWriteCreate;Cache=Shared;`.
  - `CreateOpenConnection()`: mở `SqliteConnection` và chạy `PRAGMA foreign_keys = ON; PRAGMA journal_mode = WAL;` (bắt buộc khóa ngoại vì SQLite mặc định tắt, và bật Write-Ahead Logging để đọc/ghi đồng thời mượt hơn).
- **`DatabaseInitializer.cs`:**
  1. Chạy `CREATE TABLE IF NOT EXISTS` cho **28 bảng**.
  2. Migrate cột bổ sung bằng `try { conn.Execute("ALTER TABLE ..."); } catch { }` để tương thích DB cũ.
  3. `SeedInitialData()`: nạp 8 Roles, Employees/Teachers/Student/Parent mẫu, 8 Users (băm mật khẩu bằng `BCrypt.Net.BCrypt.HashPassword`), dữ liệu học vụ/tài chính mẫu (khi `Courses` rỗng), `SystemConfigs`, và danh mục `Permissions` + `RolePermissions`.

---

## Bài 3 (Module 4 & 5): Tầng `ECMS.Core` & Tầng `ECMS.Data` (Repositories + Dapper)

- **`ECMS.Core`:**
  - **Entities (`BaseEntity`):** Lớp đối tượng ánh xạ 1-1 với bảng CSDL (`User`, `Student`, `Teacher`, `Course`...).
  - **DTOs (`UserSession`, `StudentListItemDto`, `UserListItemDto`...):** Đối tượng đóng gói dữ liệu tùy biến (gộp từ nhiều bảng, tính toán sẵn cột hiển thị) để truyền giữa Data ↔ Business ↔ UI.
  - **Enums (`AppEnums.cs`):** Kiểu liệt kê cố định (`StudentStatus`, `AttendanceStatus`, `ClassStatus`...) tránh gõ sai chuỗi.
  - **Helpers (`StatusFormatter`):** Chuẩn hóa chuỗi hiển thị ca học, cấp độ, trạng thái.
- **`ECMS.Data` (Repositories + Dapper):**
  - `BaseRepository`: Lớp cha `abstract` cung cấp `CreateConnection()`.
  - Các Repository (`StudentRepository`, `UserRepository`...) triển khai Interface (`IStudentRepository`, `IUserRepository`...) để tách biệt phần SQL khỏi Business.
  - Dùng `Dapper` (`QueryAsync<T>`, `DynamicParameters`) để map tự động cột SQL sang DTO và truyền tham số `@Pattern` chống SQL Injection.

---

## Bài 4 (Module 6): Tầng `ECMS.Business` (`AuthService`, `RbacService`, `UserService`, `SessionManager`)

- **Vai trò tầng Business:** Kiểm tra dữ liệu đầu vào (Validation), thực thi quy tắc nghiệp vụ (chống tự xóa quyền Admin, băm mật khẩu BCrypt, ghi Audit Log) và điều phối gọi Repository.
- **Kỹ thuật nổi bật:**
  - **Value Tuple `(bool Success, string Message, ...)`:** Trả về kết quả kèm thông báo lỗi thân thiện cho UI hiển thị mà không phải ném Exception cho các lỗi nghiệp vụ thông thường.
  - **Optional Constructor Injection (`IUserRepository? userRepo = null`):** Hỗ trợ truyền mock repository khi test, nhưng mặc định tự `new UserRepository()` vì không dùng DI Container.
  - **`AuthService`:** Xác thực qua `BCrypt.Verify()`, kiểm tra `IsActive`, lấy Role + Permissions + FullName từ bảng liên kết (`Employees`/`Teachers`...), tạo `UserSession` và ghi `AuditLogs`.
  - **`RbacService`:** Đọc/lưu ma trận phân quyền Sidebar theo `RoleCode` (`Toàn quyền`, `Chỉ xem`, `Không có quyền`), luôn bảo vệ quyền tối thiểu cho `ROLE_ADMIN`.
  - **`SessionManager`:** Lưu `UserSession` hiện tại ở tầng Business bằng biến `static`.

---

## Bài 5 (Module 7): Giao diện gốc & Phân quyền RBAC (`LoginForm`, `AppSession`, `MainForm`)

- **`LoginForm.cs`:**
  - `LoginForm_Load`: Gọi `SystemConfigService` lấy tên app, tên trung tâm, logo.
  - `btnLogin_Click`: Gọi `AuthService.LoginAsync()` (có `UsernameAliases`), chặn `ROLE_STU`/`ROLE_PAR`, đồng bộ `SessionManager.SetSession(session)` + gán `AppSession`, kiểm tra `MustChangePassword` (mở `ForceChangePasswordDialog`), rồi mở `MainForm`.
- **`AppSession.cs`:** Lưu thông tin phiên ở tầng UI + `ModuleAccessLevels` (`Dictionary<string, string>`) phục vụ `IsReadOnlyModule(moduleKey)` và `HasFullAccountAccess()`.
- **`MainForm.cs`:**
  - `WireUpNavigationEvents()`: Gắn sự kiện click cho 12 nút Sidebar.
  - `ApplyRoleBasedAccessControlAsync()`: Đọc ma trận RBAC từ `RbacService`, ẩn/hiện nút Sidebar, gọi `LayoutSidebarMenu()` dồn tọa độ Y tránh khoảng trắng, tự mở màn hình mặc định theo Role.
  - `LoadView(UserControl, moduleKey)`: Xóa view cũ + `Dispose()`, nhúng `UserControl` mới vào `pnlContent` (`DockStyle.Fill`), và tự gọi `ApplyReadOnlyRestrictions()` để ẩn nút ghi / khóa `DataGridView` nếu Role chỉ có quyền `"Chỉ xem"`.

---

## Bài 6 (Module 8 & 9): Custom Controls & Luồng End-to-End các phân hệ chính

- **Custom Controls (`ECMS.UI/Controls/`):**
  - `FigmaTheme`: Lưu bảng màu chuẩn (`Primary #2563EB`, `AppBackground #F5F7FA`, `Success`, `Warning`, `Danger`) và Typography `Segoe UI`.
  - `AppDialog`: Hộp thoại chuẩn thay cho `MessageBox.Show`, hỗ trợ 4 loại (`Info`, `Success`, `Warning`, `Danger`) với các hàm static `ShowError`, `ShowSuccess`, `ShowConfirm`...
  - `AppButton`, `AppCard`, `AppDataGrid`, `AppTextBox`, `MiniBarChart`: Các control tự bo góc / custom style giúp giao diện đồng nhất.
- **6 Luồng End-to-End trọng tâm:**
  1. **Học viên & Nhập Excel:** `StudentManagementView` / `ImportStudentsDialog` → `StudentService` (ClosedXML) → `StudentRepository` → `Students`.
  2. **Lịch học & Chống trùng:** `ScheduleManagementView` / `CreateScheduleDialog` → `ScheduleService.GenerateClassSchedulesAsync` → `ScheduleRepository` → `ClassSchedules`.
  3. **Điểm danh & Điểm số (GPA):** `TeacherAttendanceCheckView` / `ClassAttendanceDialog` → `AttendanceService` (và một phần gọi thẳng Dapper) → `AttendanceRecords`; `TeacherGradeManagementView` / `GradeEntryDialog` → `ExamService.SaveClassGradeEntriesAsync` → `ExamScores` + cập nhật `Enrollments.FinalGPA`.
  4. **Học phí & Biên lai:** `TuitionPaymentView` / `CollectTuitionDialog` → `FinanceService.CollectTuitionAsync` → `FinanceRepository` → `Payments` + cập nhật `Invoices` + `ReceiptPrintPreviewDialog`.
  5. **Chứng chỉ:** `CertificateManagementView` → `ECMS.Business.Services.CertificateService.IssueCertificateAsync` → `CertificateRepository` → `Certificates` + `CertificatePrintPreviewDialog`.
  6. **Tài khoản, RBAC & Sao lưu:** `AccountManagementView` → `UserService` / `RbacService`; `SystemConfigView` / `CreateBackupDialog` → `SystemConfigService` + copy file `ecms_data.db`.
