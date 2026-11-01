# DỰ ÁN: ENGLISH CENTER MANAGEMENT SYSTEM (ECMS)
> Hệ thống Quản lý Trung tâm Anh ngữ toàn diện trên nền tảng Desktop C# (.NET 8 WinForms, SQLite 100% Offline).

---

## 1. THÔNG TIN KHỞI CHẠY HỆ THỐNG

### Cách khởi động dự án trên JetBrains Rider:
1. Mở solution `E:\ECMS\ECMS\ECMS.sln`.
2. Trên thanh công cụ trên cùng của Rider, đảm bảo Run Configuration đang chọn là **`ECMS.UI`**.
3. Bấm nút **Play / Run ($\blacktriangleright$)** hoặc phím tắt `Shift + F10` (hoặc `Ctrl + F5`).
4. Khi ứng dụng khởi chạy lần đầu:
   - `DatabaseInitializer` sẽ tự động tạo thư mục và tệp CSDL SQLite tại: `%APPDATA%\ECMS\ecms_data.db`.
   - Tự động sinh đầy đủ **26 bảng dữ liệu chuẩn 3NF**, khóa ngoại và thiết lập cờ `PRAGMA foreign_keys = ON; PRAGMA journal_mode = WAL;`.
   - Nạp sẵn tài khoản Admin mặc định và danh mục 6 vai trò chuẩn.

### Tài khoản đăng nhập mặc định:
- **Tên đăng nhập (Username)**: `admin`
- **Mật khẩu (Password)**: `Admin@123`
- **Vai trò**: `ROLE_ADMIN` (Quản trị hệ thống)

---

## 2. CẤU TRÚC PHÂN TẦNG SOLUTION (LAYERED ARCHITECTURE)

Dự án được tổ chức theo 4 tầng tách biệt rõ ràng:

```
ECMS/
├── Docs/                               # Bộ tài liệu đặc tả nghiệp vụ
│   ├── ECMS_Requirements_Analysis_and_Project_Roadmap.xlsx (12 Sheets chi tiết)
│   └── ECMS_Requirements_Analysis_and_Project_Roadmap.docx (11 Chương tài liệu SRS)
│
├── ECMS.Core/                          # Tầng thực thể & mô hình dùng chung
│   ├── Enums/                          # Các kiểu liệt kê: StudentStatus, AttendanceStatus, InvoiceStatus...
│   ├── Entities/                       # 26 thực thể CSDL (User, Student, Class, Schedule, Invoice...)
│   └── DTOs/                           # Data Transfer Objects: UserSession, ViewModels...
│
├── ECMS.Data/                          # Tầng truy xuất dữ liệu & CSDL SQLite
│   ├── Database/                       # DatabaseConfig, DatabaseInitializer (DDL 26 bảng & Seed Data)
│   └── Repositories/                   # IRepository<T>, BaseRepository (Dapper queries)
│
├── ECMS.Business/                      # Tầng xử lý logic nghiệp vụ & quy tắc kiểm tra
│   ├── Services/                       # AuthService, ScheduleService, AttendanceService, FinanceService, StudentService...
│   └── Session/                        # SessionManager (Lưu vết phiên làm việc người dùng hiện tại)
│
└── ECMS.UI/                            # Tầng giao diện người dùng WinForms (.NET 8)
    ├── Controls/                       # Custom Controls Glassmorphism (RoundedPanel, GlassCard...)
    ├── Forms/                          # MainForm, LoginForm
    └── UserControls/                   # DashboardView, StudentListView, ScheduleCalendarView...
```

---

## 3. PHÂN CÔNG CÔNG VIỆC CHO NHÓM 3 NGƯỜI

| Thành viên | Phân hệ phụ trách chính | Các bảng CSDL chính | Màn hình chính |
| :--- | :--- | :--- | :--- |
| **Thành viên 1**<br>*(Tech Lead & Tài chính)* | • Kiến trúc, SQLite, Repository Base<br>• Tài khoản, Phân quyền RBAC, Nhân viên<br>• Tuyển sinh: Leads & Tư vấn<br>• Tài chính: Hóa đơn, Phiếu thu, In biên lai A5, Công nợ<br>• Sao lưu / Khôi phục DB & Audit Logs | `Users`, `Roles`, `UserRoles`, `Permissions`, `Employees`, `Leads`, `ConsultationLogs`, `Invoices`, `Payments`, `FeeDiscounts`, `AuditLogs`, `SystemConfigs` | `LoginForm`<br>`EmployeeListView`<br>`LeadManagementView`<br>`InvoiceListView`<br>`PaymentReceiptDialog`<br>`BackupRestoreView` |
| **Thành viên 2**<br>*(Đào tạo & Học thuật)* | • Khóa học & Phòng học<br>• Lớp học, Phân công GV, Đăng ký lớp (Enrollment)<br>• Lịch học & Thuật toán chống trùng lịch GV/Phòng<br>• Sổ điểm danh & Cảnh báo vắng $\ge 3$ buổi<br>• Bài kiểm tra, Bảng điểm & Tính GPA theo trọng số<br>• Xét tốt nghiệp & In chứng chỉ A4 | `Courses`, `Classes`, `ClassRooms`, `ClassSchedules`, `Enrollments`, `AttendanceRecords`, `Exams`, `ExamScores`, `Certificates`, `StudyMaterials` | `CourseListView`<br>`ClassListView`<br>`ScheduleCalendarView`<br>`AttendanceSheetView`<br>`AbsenceAlertView`<br>`GradebookView`<br>`CertificateView` |
| **Thành viên 3**<br>*(UI/UX Master & Hồ sơ)* | • Bộ Custom Controls Glassmorphism<br>• MainForm Layout, Sidebar Navigation, Header Bar<br>• Hồ sơ Học viên, Phụ huynh & Liên kết StudentParents<br>• Kiosk tra cứu nhanh tại quầy tiếp tân<br>• Dashboard điều hành (Biểu đồ doanh thu & KPIs)<br>• R&D video nền Lively Wallpaper (Giai đoạn 9) | `Students`, `Parents`, `StudentParents`, `Notifications` | `MainForm`<br>`StudentListView`<br>`StudentDetailDialog`<br>`ParentListView`<br>`QuickLookupKiosk`<br>`DashboardView`<br>`SettingsView` (Wallpaper) |

---

## 4. TÀI LIỆU NGHIỆP VỤ ĐÍNH KÈM
Toàn bộ chi tiết về 23 phân hệ, ma trận phân quyền, thiết kế 26 bảng và 20 luồng End-to-End đã có sẵn tại thư mục `Docs/`:
- [`ECMS_Requirements_Analysis_and_Project_Roadmap.xlsx`](Docs/ECMS_Requirements_Analysis_and_Project_Roadmap.xlsx)
- [`ECMS_Requirements_Analysis_and_Project_Roadmap.docx`](Docs/ECMS_Requirements_Analysis_and_Project_Roadmap.docx)
