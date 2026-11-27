# BẢN ĐỒ TRI THỨC DỰ ÁN ECMS (`PROJECT_KNOWLEDGE_MAP.md`)

> Tài liệu này được xây dựng trực tiếp từ việc khảo sát source code thực tế của solution `E:\ECMS\ECMS\ECMS.sln` (không chỉnh sửa mã nguồn).

---

## 1. Xác minh thông tin dự án (Thực tế vs Mô tả ban đầu / README)

| Hạng mục | Thông tin ban đầu / README | Thực tế trong source code |
| :--- | :--- | :--- |
| **Ngôn ngữ & Nền tảng** | C#, .NET / Windows Forms | **Đúng** — C# trên `.NET 10` (`net10.0-windows`, `UseWindowsForms=true` ở `ECMS.UI`). |
| **Database** | SQLite (README ghi 26 bảng) | **SQLite** (`Microsoft.Data.Sqlite` 11.0.0-rc.3 + `Dapper` 2.1.89), lưu tại `%APPDATA%\ECMS\ecms_data.db`. Thực tế `DatabaseInitializer.cs` tạo **28 bảng** (không phải 26). |
| **Kiến trúc** | Phân tầng: `ECMS.Core`, `ECMS.Data`, `ECMS.Business`, `ECMS.UI` | **Đúng có 4 project**, nhưng phụ thuộc thực tế **không thuần túy 1 chiều**: `ECMS.UI` tham chiếu trực tiếp cả `ECMS.Data`, một số Form/UserControl và 3 Service gọi thẳng `DatabaseConfig` + `Dapper` (bỏ qua Repository). |
| **Dependency Injection (DI)** | Chưa rõ | **Không dùng DI Container** (`Microsoft.Extensions.DependencyInjection` không được cài). Các tầng khởi tạo đối tượng thủ công bằng `new ...()` (có hỗ trợ constructor injection ở một số Service/Repo nhưng mặc định tự `new`). |
| **Thư viện bên thứ 3** | Chưa liệt kê đủ | `Dapper`, `Microsoft.Data.Sqlite`, `BCrypt.Net-Next`, `ClosedXML` (xuất/nhập Excel), `FontAwesome.Sharp` (bị cài dư ở cả `ECMS.Core` và `ECMS.Data`). |
| **Thư mục `Docs/`** | README nhắc đến `Docs/` | **Không tồn tại** trong workspace hiện tại. |
| **Phân hệ UI** | README nhắc đến Leads, Parents, QuickLookupKiosk, Lively Wallpaper | **Không có màn hình UI** cho Leads, Parents, QuickLookupKiosk, StudyMaterials, Notifications (dù bảng DB có tồn tại). Hệ thống hiện có **12 màn hình chính** trong `MainForm` + **30 Forms/Dialogs**. |

---

## 2. Cấu trúc thư mục và bản đồ thành phần

### 2.1. Tầng `ECMS.Core` (Không tham chiếu project nào khác)

| Thư mục / File | Vai trò | Thành phần quan trọng | Trạng thái |
| :--- | :--- | :--- | :--- |
| `Entities/BaseEntity.cs` | Lớp cơ sở chứa `CreatedAt`, `UpdatedAt` | `BaseEntity` | Đang dùng |
| `Entities/SecurityEntities.cs` | Thực thể bảo mật & phân quyền | `User`, `Role`, `Permission`, `UserRole`, `RolePermission` | Một phần chưa dùng (`UserRole`, `RolePermission`) |
| `Entities/HumanEntities.cs` | Thực thể nhân sự, học viên, tuyển sinh | `Employee`, `Teacher`, `Lead`, `ConsultationLog`, `Student`, `Parent`, `StudentParent` | Một phần chưa dùng (`ConsultationLog`, `StudentParent`) |
| `Entities/AcademicEntities.cs` | Thực thể đào tạo | `Course`, `ClassRoom`, `ClassEntity`, `ClassSchedule`, `AttendanceRecord`, `Exam`, `ExamScore`, `Certificate`, `StudyMaterial` | Nhiều entity chưa dùng trực tiếp (Repository map thẳng sang DTO/dynamic) |
| `Entities/FinanceEntities.cs` | Thực thể tài chính | `Invoice`, `Payment`, `FeeDiscount` | Chưa dùng trực tiếp trong C# (dùng DTO) |
| `Entities/SystemEntities.cs` | Thực thể hệ thống | `AuditLog`, `SystemConfig`, `Notification` | `SystemConfig`, `Notification` chưa dùng |
| `DTOs/*.cs` (17 file) | Đối tượng truyền dữ liệu giữa UI ↔ Business ↔ Data | `UserSession`, `StudentDtos`, `ClassListItemDto`, `DashboardDtos`, `EnrollmentDtos`, `ExamDtos`, `TuitionProfileDto`, `PaymentReceiptDto`, `RbacDtos`, `ScheduleDtos`, `SystemConfigDtos`, `UserDtos`, `TeacherDtos`, `AuditLogDtos`, `EligibleStudentDto`, `IssuedCertificateDto`, `StudyMaterialDto` | Hầu hết đang dùng; `UpdateRolePermissionsRequest`, `ChangePasswordDto`, `ResetPasswordAdminDto` chưa thấy gọi; `StudyMaterialDto` chỉ tới Service chưa tới UI |
| `Enums/AppEnums.cs` | Các kiểu liệt kê nghiệp vụ | `StudentStatus`, `ClassStatus`, `AttendanceStatus`, `InvoiceStatus`, `UserRoleType`... | Đang dùng (`UserRoleType` chưa thấy gọi) |
| `Helpers/DomainFormatters.cs` | Chuẩn hóa hiển thị ca học, cấp độ, trạng thái | `StatusFormatter` | Đang dùng |

### 2.2. Tầng `ECMS.Data` (Tham chiếu: `ECMS.Core`)

| Thư mục / File | Vai trò | Thành phần quan trọng | Trạng thái |
| :--- | :--- | :--- | :--- |
| `Database/DatabaseConfig.cs` | Quản lý đường dẫn DB, chuỗi kết nối, mở `SqliteConnection` kèm `PRAGMA foreign_keys = ON; PRAGMA journal_mode = WAL;` | `DatabasePath`, `ConnectionString`, `CreateOpenConnection()`, `GetConnection()` | Đang dùng xuyên suốt |
| `Database/DatabaseInitializer.cs` | Tạo 28 bảng SQLite (DDL), migrate cột cho bảng `Users`, nạp dữ liệu mẫu (Seed Data) & ma trận quyền mặc định | `Initialize()`, `SeedInitialData()`, `SeedPermissionsAndDefaults()`, `AssignRolePerms()` | Đang dùng lúc khởi động |
| `Repositories/IRepository.cs` | Interface CRUD tổng quát `IRepository<T>` | `IRepository<T>` | **Chưa được sử dụng** (không class nào implement) |
| `Repositories/BaseRepository.cs` | Lớp cha cung cấp `CreateConnection()` | `BaseRepository` | Đang dùng (8/14 Repo kế thừa; 6 Repo gọi thẳng `DatabaseConfig`) |
| `Repositories/*Repository.cs` (14 cặp Interface + Class) | Truy vấn SQLite bằng Dapper cho từng phân hệ | `User`, `Rbac`, `AuditLog`, `Student`, `Teacher`, `Course`, `Class`, `Schedule`, `Enrollment`, `Exam`, `Certificate`, `Finance`, `Dashboard`, `SystemConfig` | Đang dùng (gọi bởi các Service tương ứng; riêng `DashboardRepository` gọi cả `StudentRepository`) |

### 2.3. Tầng `ECMS.Business` (Tham chiếu: `ECMS.Core`, `ECMS.Data`)

| Thư mục / File | Vai trò | Thành phần quan trọng | Trạng thái |
| :--- | :--- | :--- | :--- |
| `Session/SessionManager.cs` | Lưu `UserSession` hiện tại ở tầng Business | `CurrentUser`, `SetSession()`, `ClearSession()` | Đang dùng (`RbacService`, `UserService`, `TeacherAttendanceCheckView`), nhưng bị **song song** với `AppSession` ở tầng UI và `ClearSession()` chưa được gọi khi đăng xuất |
| `Services/AuthService.cs` | Xác thực đăng nhập, kiểm tra mật khẩu BCrypt, khóa tài khoản sai nhiều lần | `IAuthService`, `AuthService` | Đang dùng — **gọi thẳng `DatabaseConfig` + Dapper** |
| `Services/AttendanceService.cs` | Lưu điểm danh hàng loạt, đếm buổi vắng, cảnh báo vắng ≥ 3 buổi | `IAttendanceService`, `AttendanceService` | `AttendanceService` dùng ở `ClassAttendanceDialog`; `IAttendanceService` chưa dùng — **gọi thẳng `DatabaseConfig` + Dapper** |
| `Services/StudentService.cs` | Nghiệp vụ học viên, nhập Excel (ClosedXML) | `IStudentService`, `StudentService` | Đang dùng — kết hợp `IStudentRepository` và **gọi thẳng `DatabaseConfig` + Dapper** |
| `Services/*Service.cs` (12 cặp Interface + Class còn lại) | Nghiệp vụ cho User, Rbac, Teacher, Course, Class, Schedule, Enrollment, Exam, Certificate, Finance, Dashboard, SystemConfig | `UserService`, `RbacService`, `TeacherService`, `CourseService`, `ClassService`, `ScheduleService`, `EnrollmentService`, `ExamService`, `CertificateService`, `FinanceService`, `DashboardService`, `SystemConfigService` | Đang dùng (đi qua Repository đúng chuẩn) |

### 2.4. Tầng `ECMS.UI` (Tham chiếu: `ECMS.Business`, `ECMS.Core`, `ECMS.Data`)

| Thư mục / File | Vai trò | Thành phần quan trọng | Trạng thái |
| :--- | :--- | :--- | :--- |
| `Program.cs` | Entry point của ứng dụng | `Main()` → `DatabaseInitializer.Initialize()` → `Application.Run(new LoginForm())` | Đang dùng |
| `AppSession.cs` | Lưu thông tin phiên đăng nhập & quyền ở tầng UI | `AppSession` (static properties + `IsReadOnlyModule`, `HasFullAccountAccess`) | Đang dùng song song với `SessionManager` |
| `Forms/LoginForm.cs` | Màn hình đăng nhập, hỗ trợ username alias, kiểm tra `MustChangePassword` | `LoginForm` | Đang dùng |
| `Forms/MainForm.cs` | Khung ứng dụng chính: Header, Sidebar theo RBAC, vùng `pnlContent` nạp 12 UserControl | `MainForm` (`LoadView`, `ApplyRoleBasedAccessControlAsync`, `ApplyReadOnlyRestrictions`) | Đang dùng (có hàm `ShowNotifications()` chưa gọi & tham số `materials` bị bỏ qua) |
| `Forms/*Dialog.cs` (28 Dialog) | Hộp thoại thêm/sửa/chi tiết/in ấn/sao lưu/wizard | Toàn bộ 28 dialog đều được gọi từ `MainForm`, `LoginForm` hoặc các `UserControl` | Đang dùng (`ClassAttendanceDialog`, `CreateClassDialog` có gọi thẳng SQLite/Dapper) |
| `UserControls/*View.cs` (12 View) | 12 màn hình chức năng chính nhúng trong `MainForm` | `DashboardOverviewView`, `StudentManagementView`, `TeacherManagementView`, `CourseManagementView`, `ClassManagementView`, `ScheduleManagementView`, `TeacherAttendanceCheckView`, `TeacherGradeManagementView`, `CertificateManagementView`, `TuitionPaymentView`, `AccountManagementView`, `SystemConfigView` | Đang dùng (`TeacherAttendanceCheckView` gọi thẳng SQLite/Dapper; `SystemConfigView` đọc `DatabaseConfig.DatabasePath`) |
| `Controls/*.cs` (13 file) | Bộ Custom Controls & bảng màu `FigmaTheme` | Đang dùng: `FigmaTheme`, `AppButton`, `AppCard`, `AppComboBox`, `AppDataGrid`, `AppDialog`, `AppTextBox`, `MiniBarChart` | **Chưa được dùng**: `AppBadge`, `AppBanner`, `AppDatePicker`, `AppStatCard`, `SidebarNavItem` |
| `Services/ExcelExportService.cs` | Xuất báo cáo Excel bằng ClosedXML | `ExcelExportService` | Đang dùng |
| `Services/CertificateService.cs` | Dịch vụ chứng chỉ **giả lập trong bộ nhớ** (dữ liệu cứng) | `ECMS.UI.Services.CertificateService`, `IssuedCertificateModel` | **Trùng tên & trùng vai trò** với `ECMS.Business.Services.CertificateService` (đang được dùng làm fallback/song song) |
