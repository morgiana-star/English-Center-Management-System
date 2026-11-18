# TÀI LIỆU NGỮ CẢNH TOÀN DIỆN DỰ ÁN ECMS (DÀNH CHO GEMINI WEB HỖ TRỢ THIẾT KẾ FIGMA & FULL UI)

> **Hướng dẫn sử dụng:** Bạn hãy **Copy toàn bộ nội dung trong file này** và dán vào cuộc trò chuyện với **Gemini trên Web** để Gemini nắm 100% kiến trúc, dữ liệu, danh sách màn hình và gu thẩm mỹ của bạn, từ đó hướng dẫn bạn thiết kế Figma và kéo thả Full UI đồng bộ nhất!

---

## [BẮT ĐẦU COPY TỪ ĐÂY]

Chào Gemini, tôi là Thành viên 1 (Trưởng nhóm) đang làm đồ án môn học **Phần mềm Quản lý Trung tâm Anh ngữ (ECMS - English Center Management System)**.
Hiện tại tôi đã hoàn thành xong phần kiến trúc Backend và CSDL. Bây giờ tôi muốn **thiết kế lại toàn bộ giao diện người dùng (Full UI)** trên **Figma** trước để đồng bộ thẩm mỹ, sau đó tự kéo thả lại trong **JetBrains Rider WinForms Designer**.

Dưới đây là toàn bộ thông tin chính xác và đầy đủ nhất về dự án của tôi để bạn làm căn cứ hướng dẫn tôi thiết kế giao diện:

---

### 1. THÔNG TIN KỸ THUẬT & RÀNG BUỘC MÔI TRƯỜNG
- **Công nghệ:** C# .NET 10 LTS, **Windows Forms (WinForms)**, SQLite 3 (chạy **100% Offline** tại `%APPDATA%\ECMS\ecms_data.db`).
- **IDE thiết kế & code:** **JetBrains Rider** (WinForms Visual Designer).
- **Kiến trúc:** Layered Architecture 4 tầng (`ECMS.Core` -> `ECMS.Data` -> `ECMS.Business` -> `ECMS.UI`).
- **Quy tắc UI tương thích WinForms:**
  - Thiết kế trên Figma sao cho khả thi khi kéo thả lại bằng WinForms Designer (tránh hiệu ứng web quá phức tạp như blur động CSS hay gradient chồng nhiều lớp khó render trên GDI+).
  - **Số lượng màn hình yêu cầu của Giảng viên:** Tối thiểu **15 màn hình riêng biệt** (tính cả Form, UserControl và Popup Dialog). Danh sách chốt dưới đây gồm **19 màn hình** bám sát 100% đề bài của thầy.

---

### 2. PHONG CÁCH THẨM MỸ & DESIGN SYSTEM (BẮT BUỘC TUÂN THỦ)
Tôi thích phong cách **Minimalist Enterprise (Tối giản, sang trọng, phẳng và sạch sẽ kiểu Atlassian Jira / Linear)** — **TUYỆT ĐỐI KHÔNG màu mè cầu vồng** (trên 1 màn hình chỉ dùng tối đa 1 màu nhấn chính, các nút phụ dùng nền xám nhạt/trắng viền mảnh), **KHÔNG dùng ký tự Emoji**.

- **Bảng màu chuẩn (Atlassian Palette):**
  - **Nền ứng dụng (`AppBackground`):** `#F4F5F7` (`RGB: 244, 245, 247`)
  - **Nền thẻ / Bề mặt chính (`Surface / Card`):** `#FFFFFF` (`RGB: 255, 255, 255`) kèm viền mảnh `1px` màu `#DFE1E6` (`RGB: 223, 225, 230`)
  - **Sidebar điều hướng trái (`MainForm`):** Deep Navy `#101826` (`RGB: 16, 24, 38`)
  - **Màu nút chính (`Primary Button` - chỉ dùng 1 nút quan trọng nhất mỗi màn hình):** `#0052CC` (`RGB: 0, 82, 204`) | Hover: `#0065FF` | Active: `#0747A6`
  - **Màu nút phụ (`Secondary Button` - Sửa, Tìm, Hủy, Công cụ):** Nền `#F4F5F7`, viền `1px` `#DFE1E6`, chữ `#172B4D`
  - **Màu nút nguy hiểm dịu (`Danger Subtle` - Khóa, Xóa):** Nền `#FFEBE6`, chữ `#BF2600`
  - **Màu chữ chính (`Text Primary`):** `#172B4D` (`RGB: 23, 43, 77`)
  - **Màu chữ phụ (`Text Secondary`):** `#42526E` (`RGB: 66, 82, 110`)
  - **Màu chữ Placeholder / Chú thích (`Text Muted`):** `#6B778C` (`RGB: 107, 119, 140`)
  - **Màu trạng thái Badge (dịu mắt):**
    - Thành công / Hoạt động / Paid: Nền `#E3FCEF`, Chữ `#006644`
    - Cảnh báo / Chờ xử lý: Nền `#FFFAE6`, Chữ `#FF8B00`
    - Nguy hiểm / Khóa / Vắng $\ge 3$: Nền `#FFEBE6`, Chữ `#BF2600`
    - Thông tin / Mới: Nền `#DEEBFF`, Chữ `#0747A6`
- **Font chữ:** `Segoe UI` (hoặc `Inter` bản TrueType tĩnh — lưu ý: WinForms GDI+ chỉ hỗ trợ TrueType static font, KHÔNG hỗ trợ Variable Font `Inter 24pt`).
- **Kích thước khung chuẩn (Figma Artboard Sizes):**
  - `MainForm` (Shell chính): **`1360 x 840 px`** (Sidebar trái rộng `240px`, Header trên cao `56px`, vùng chứa nội dung ở giữa rộng **`1072 x 738 px`**).
  - Tất cả các màn hình trang con (`UserControl` nạp vào `MainForm`): **`1070 x 730 px`** (Lề trái/phải `20px` $\rightarrow$ chiều rộng nội dung bên trong **`1030px`**).

---

### 3. BỘ 11 CUSTOM COMPONENTS ĐÃ CODE SẴN TRONG WINFORMS (`ECMS.UI/Controls/`)
Khi thiết kế Figma và hướng dẫn tôi đưa qua WinForms, hãy tận dụng các Component lắp ghép có sẵn sau đây trong dự án:
1. `GlassCard`: Khung chứa trắng bo góc 10-16px, viền `#DFE1E6`.
2. `StatKpiCard`: Thẻ thống kê nền trắng (gồm vạch nhấn 4px bên trái, `CardTitle` màu `#6B778C`, `CardValue` đậm màu `#172B4D`, `SubtitleText` bên dưới).
3. `ModernSectionHeader`: Thanh tiêu đề phân mục gồm vạch đứng 5px `#0052CC` + `HeaderText` + `SubtitleText`.
4. `CustomButton`: Nút bo góc 6-8px có sẵn 4 biến thể `Variant` (`Primary`, `Secondary`, `DangerSubtle`, `Outline`).
5. `ModernTextBox`: Ô nhập liệu bo góc, Placeholder màu `#6B778C`, viền phát sáng `#0052CC` khi focus, hỗ trợ `UseSystemPasswordChar`.
6. `ModernComboBox`: Hộp chọn thả xuống bo góc cao 36px đồng bộ với `ModernTextBox`.
7. `ModernDatePicker`: Hộp chọn ngày định dạng `dd/MM/yyyy` bo góc cao 36px.
8. `ModernToggleSwitch`: Công tắc gạt bật/tắt mượt mà.
9. `ModernDataGridView`: Bảng dữ liệu phẳng, tiêu đề cột nền `#0052CC` chữ trắng, hàng xen kẽ Zebra striping.
10. `RoundedPanel`: Khung phụ bo góc.
11. `StatusBadge`: Nhãn trạng thái dạng viên thuốc.

*(Thư viện Icon đang cài sẵn trong project: `FontAwesome.Sharp 6.6.0` và `ClosedXML 0.105.1` xuất Excel).*

---

### 4. ĐỀ BÀI CỦA GIẢNG VIÊN & PHẠM VI TINH GỌN (ĐÃ BỎ PHỤ HUYNH)
Hệ thống bám sát đúng **3 khối nghiệp vụ cốt lõi** từ đề bài Giảng viên giao cho nhóm 3 thành viên (đã loại bỏ vai trò Phụ huynh `ROLE_PAR`, Wallpaper động, Kiosk tiếp tân để tập trung hoàn hảo vào nghiệp vụ):

1. **Khối 1 — Quản lý Khóa học, Lớp học & Xếp lịch chống trùng:** Quản lý danh mục khóa học (TOEIC 500, IELTS 6.5...), mở lớp học cụ thể (Phòng, Giáo viên, Lịch học), thuật toán kiểm tra tránh trùng phòng học và trùng giờ giáo viên.
2. **Khối 2 — Đăng ký, Ưu đãi & Thu học phí:** Tiếp nhận học viên, chọn lớp học, áp dụng chính sách ưu đãi (giảm 10% học viên cũ, giảm khi đăng ký nhóm), tự sinh hóa đơn học phí, thu tiền 1 lần hoặc chia nhiều đợt, in biên lai A5.
3. **Khối 3 — Điểm danh & Quản lý Kết quả:** Điểm danh từng buổi (Có mặt / Vắng có phép / Vắng không phép), cảnh báo nếu học viên vắng $\ge 3$ buổi để lễ tân gọi nhắc nhở, nhập điểm giữa kỳ/cuối kỳ $\rightarrow$ tự tính điểm trung bình GPA $\rightarrow$ xuất/in Chứng nhận hoàn thành khóa học A4.

---

### 5. DANH SÁCH ĐẦY ĐỦ 19 MÀN HÌNH CẦN THIẾT KẾ UI (KÈM TRƯỜNG DỮ LIỆU BẮT BUỘC)

#### Nhóm 0: Khung ứng dụng chung (2 màn hình)
1. **`LoginForm` (`900 x 540`)**: Chia 2 cột (Cột trái Branding `420px` nền `#101826`, Cột phải Card trắng đăng nhập). Trường bắt buộc: `txtUsername`, `txtPassword`, công tắc `Hiện mật khẩu`, nút `Đăng nhập ngay` (`#0052CC`), nhãn báo lỗi Brute-force (`lblError`).
2. **`MainForm` (`1360 x 840`)**: Cột trái Sidebar (`240px`) gồm Logo ECMS, danh sách nút điều hướng phân quyền động theo vai trò đăng nhập, Mini-card thông tin tài khoản ở đáy. Header trên cùng (`1072 x 56`) gồm Thanh tìm kiếm nhanh, Lời chào, Badge vai trò, nút `Đổi mật khẩu`, nút `Đăng xuất`. Vùng nội dung chính ở giữa (`1072 x 738`).

#### Nhóm 1: Phân hệ Admin - `ROLE_ADMIN` (6 màn hình - Backend đã code xong 100%)
3. **`AdminDashboardView` (`1070 x 730`)**:
   - Tiêu đề + 3 nút phụ góc trên phải (`Phân quyền RBAC`, `Nhật ký Audit`, `Giám sát khóa`).
   - 4 `StatKpiCard`: Tổng tài khoản, Trạng thái SQLite WAL, Số lượng Audit Logs, Số tài khoản bị khóa.
   - Thanh Toolbar: Tìm kiếm từ khóa, Lọc vai trò, Lọc trạng thái, nút `Tìm`, nút `+ Thêm mới` (Primary), `Sửa`, `Reset MK`, `Khóa`.
   - Bảng `dgvUsers`: ID, Username, Họ tên, Email, Vai trò chính, Trạng thái, Số lần sai MK, Thời gian khóa còn lại.
4. **`UserEditDialog` (Popup `560 x 580`)**: Thêm/Sửa User (`Username`, `FullName`, `Email`, `Password` khi tạo mới, chọn Vai trò `RoleId`, Toggle `Kích hoạt`).
5. **`ResetPasswordDialog` & `ChangePasswordDialog` (Popup `500 x 380`)**: Đổi mật khẩu hoặc Admin cấp lại mật khẩu (`OldPassword`, `NewPassword`, `ConfirmPassword`).
6. **`BruteForceMonitorDialog` (Popup `880 x 600`)**: 2 KPI (Đang bị khóa / Đã nhập sai MK), Bảng danh sách user vi phạm kèm thời gian đếm ngược mở khóa, nút `Mở khóa đã chọn` & `Mở khóa tất cả`.
7. **`RbacMatrixDialog` (Popup `1020 x 680`)**: Cột trái chọn 1 trong các Vai trò (`Roles`), Cột phải bảng ma trận 36 quyền gom theo 10 Module kèm checkbox Bật/Tắt quyền (có chốt chặn không cho tắt quyền Admin), nút `Lưu phân quyền` & `Khôi phục mặc định`.
8. **`AuditLogViewerDialog` (Popup `1200 x 760`)**: 4 KPI thống kê, Bộ lọc (Khoảng ngày Từ-Đến, Loại hành động, Bảng dữ liệu, Từ khóa), Bảng Logs Append-Only, Khung dưới so sánh `OldValues` vs `NewValues`, nút `Xuất Excel`.

#### Nhóm 2: Phân hệ Tư vấn Tuyển sinh & Lễ tân - `ROLE_EC` (4 màn hình - Backend Lead & Enrollment & Ưu đãi 10% đã code xong)
9. **`AdmissionsDashboardView` (`1070 x 730`)**:
   - 4 KPI: Tổng khách tiềm năng (Leads), Mới tiếp nhận, Đã chốt nhập học, Cảnh báo vắng $\ge 3$ buổi.
   - Toolbar: Tìm kiếm SĐT/Tên, Lọc Trạng thái Lead (`New`, `Contacted`, `TestScheduled`, `Converted`, `Lost`), Lọc Kênh nguồn, nút `+ Thêm khách`, `Sửa`, `Đổi trạng thái`, `Đăng ký xếp lớp` (Primary), `Cảnh báo vắng >= 3`.
   - Bảng `dgvLeads` + Khung xem nhanh Ghi chú nguyện vọng ở đáy màn hình.
10. **`LeadEditDialog` (Popup `580 x 560`)**: Họ tên, SĐT, Email, Kênh tiếp nhận (`Source`), Trạng thái chăm sóc, Ghi chú nguyện vọng (Multiline).
11. **`StudentEnrollmentDialog` (Popup `700 x 785`)**:
    - Phần 1 (Học viên): Họ tên, Ngày sinh, Giới tính, SĐT (rời ô tự động nhận diện **Học viên cũ**), Email, Địa chỉ.
    - Phần 2 (Chọn Lớp): Dropdown chọn Lớp học mở (hiển thị giáo viên, phòng, sĩ số `x/y`, cảnh báo nếu lớp đã đầy).
    - Phần 3 (Ưu đãi & Hóa đơn): Dropdown chọn chính sách ưu đãi (`Giảm 10% học viên cũ`, `Giảm 15% đăng ký nhóm`, `Ưu đãi đóng sớm`), Khung tính tiền (Học phí gốc - Giảm giá = **Thành tiền**). Nút `Xác nhận xếp lớp & Xuất hóa đơn` (tự sinh mã `HV-yyyy-xxxx` và hóa đơn `INV-...`).
12. **`AbsenceAlertDialog` (Popup `960 x 620`)**: Danh sách học viên vắng $\ge 3$ buổi (Mã HV, Tên HV, SĐT liên hệ, Tên lớp, Số buổi vắng), nút `Đã gọi điện nhắc nhở` + ô ghi chú phản hồi.

#### Nhóm 3: Phân hệ Kế toán & Giám đốc - `ROLE_ACC` & `ROLE_MGR` (3 màn hình)
13. **`FinanceDashboardView` (`1070 x 730`)**:
    - 4 KPI: Tổng tiền phải thu, Đã thu trong ngày, Hóa đơn chưa hoàn tất, Tổng công nợ tồn.
    - Lọc trạng thái Hóa đơn (`Unpaid`, `PartiallyPaid`, `Paid`), Tìm kiếm tên/mã HV, nút `Thu học phí & In biên lai` (Primary).
    - Bảng `dgvInvoices`: Mã HĐ (`INV-...`), Mã HV, Họ tên, Lớp học, Học phí gốc, Giảm giá, Phải thu, Đã đóng, Còn nợ (`BalanceDue`), Trạng thái.
14. **`PaymentReceiptDialog` (Popup `620 x 560`)**: Thông tin Hóa đơn & Số tiền còn nợ, Toggle `Đóng toàn bộ 100%` hoặc ô nhập số tiền thu từng đợt, Phương thức (`Tiền mặt`, `Chuyển khoản`, `POS`), Ghi chú, Nút `Xác nhận thu & Xem trước/In Biên lai A5` (sinh mã `PT-yyyyMMdd-xxxx`).
15. **`DashboardView` (`1070 x 730` - Giám đốc điều hành)**: 4 KPIs (Doanh thu thực thu tháng, Tổng HV đang học, Số lớp đang mở, Tổng công nợ), Bảng tổng hợp giao dịch thu gần nhất & Tỷ lệ lấp đầy các lớp học.

#### Nhóm 4: Phân hệ Giáo vụ & Giảng viên - `ROLE_AA` & `ROLE_TEA` (4 màn hình)
16. **`AcademicDashboardView` (`1070 x 730`)**:
    - 4 KPI: Tổng Khóa học, Lớp đang mở, Tổng Phòng học, Giảng viên.
    - Chuyển đổi chế độ hoặc Tab: Quản lý Khóa học (`Courses`: Tên, Học phí gốc `BaseTuitionFee`, Số buổi), Quản lý Phòng học (`ClassRooms`), Quản lý Lớp học (`Classes`: Mã lớp, Tên lớp, Khóa, Phòng, GV, Sĩ số `x/y`, Ngày khai giảng). Nút `+ Thêm khóa học`, `+ Mở lớp mới`, `Xếp thời khóa biểu`.
17. **`ClassScheduleDialog` (Popup `720 x 540`)**: Chọn Lớp, Phòng học, Giáo viên, Ngày học, Giờ bắt đầu - Giờ kết thúc. Bấm Lưu chạy thuật toán kiểm tra trùng phòng và trùng giờ giáo viên (`Conflict Check`).
18. **`TeacherPortalView` (`1070 x 730`)**: Chọn Lớp phụ trách & Ngày buổi học. Hỗ trợ 2 chế độ:
    - Chế độ 1 (Sổ điểm danh): Danh sách HV trong lớp kèm chọn trạng thái (`Có mặt`, `Vắng có phép`, `Vắng không phép`, `Đi muộn`) + Nút `Lưu điểm danh`.
    - Chế độ 2 (Bảng điểm): Nhập điểm Giữa kỳ, Cuối kỳ (thang 10) $\rightarrow$ Tự tính điểm TB (GPA) $\rightarrow$ Nút `Lưu điểm` & Nút `In Chứng nhận A4` cho học viên đủ điều kiện (`GPA >= 5.0` và `Chuyên cần >= 80%`).
19. **`CertificatePrintDialog` (Popup `850 x 620`)**: Bản xem trước Giấy chứng nhận hoàn thành khóa học khổ A4 nằm ngang (Tên trung tâm, Tên học viên, Khóa học, Điểm GPA, Xếp loại, Mã chứng chỉ `CC-yyyy-xxxx`, Ngày cấp, Chữ ký) + Nút `In / Xuất PDF`.

---

### 6. YÊU CẦU DÀNH CHO GEMINI WEB
Hãy đóng vai **Chuyên gia UI/UX (Figma) & WinForms Designer**:
1. Giúp tôi thiết lập **Figma Design System / Component Library** chuẩn Minimalist Enterprise theo đúng bảng màu (`#0052CC`, `#172B4D`, `#6B778C`, `#F4F5F7`, `#DFE1E6`) và kích thước (`1360x840`, `1070x730`) ở trên để tôi kéo thả ra các bản mockup cực đẹp trên Figma.
2. Hướng dẫn tôi thiết kế **lần lượt từng màn hình** trong 19 màn hình trên (bắt đầu từ khung `MainForm` và các màn hình chính) với bố cục hợp lý, thoáng mắt, không rối, không màu mè, và **đảm bảo 100% khả thi khi tôi mang sang kéo thả bằng JetBrains Rider WinForms Designer**.

## [KẾT THÚC COPY TẠI ĐÂY]
