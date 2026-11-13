# BẢN VẼ THIẾT KẾ GIAO DIỆN KÉO THẢ CHI TIẾT (UI DESIGNER BLUEPRINT)
## DỰ ÁN: HỆ THỐNG QUẢN LÝ TRUNG TÂM ANH NGỮ (ECMS)
### Công cụ sử dụng: JetBrains Rider WinForms Designer + Bộ Component `ECMS UI Kit`

---

> [!IMPORTANT]
> **Mục đích tài liệu:** Đây là **bản vẽ thông số kỹ thuật đến từng pixel** giúp bạn thực hiện kéo thả toàn bộ giao diện dự án ECMS trên JetBrains Rider Designer nhanh như xếp hình trong PowerPoint, đảm bảo toàn bộ 10+ màn hình thẳng hàng tăm tắp, đồng nhất 100% phong cách **Modern Enterprise Frosted Glassmorphism** và chuẩn bị sẵn tên biến `(Name)` để nối code Backend ngay lập tức.

---

# 📐 1. QUY CHUẨN VÀNG KHI KÉO THẢ (MASTER GRID & DESIGN TOKENS)

### 1.1. Kích thước chuẩn & Hệ lưới (Grid System)
- **Màn hình Trang chính (`UserControl` - các file có đuôi `...View`):**
  - Kích thước chuẩn của UserControl: **`Size = (1070, 730)`**, **`BackColor = 245, 247, 250`** (`AppBackground`).
  - Lề trái & Lề phải an toàn: **`20px`** $\rightarrow$ Vùng làm việc hữu dụng rộng **`1030px`** (`X` từ `20` đến `1050`).
  - **Công thức vàng cho hàng 4 Thẻ KPI (`StatKpiCard`):**
    - Thẻ 1: `Location = (20, 75)` | `Size = (245, 120)`
    - Thẻ 2: `Location = (281, 75)` | `Size = (245, 120)`
    - Thẻ 3: `Location = (542, 75)` | `Size = (245, 120)`
    - Thẻ 4: `Location = (803, 75)` | `Size = (247, 120)` *(Chạm đúng biên phải `1050`)*
  - **Công thức vàng cho Thanh Công cụ (`GlassCard`):**
    - `Location = (20, 210)` | `Size = (1030, 68)` | `Anchor = Top, Left, Right` | `CornerRadius = 10` | `EnableShadow = False`.
  - **Công thức vàng cho Bảng Dữ liệu (`ModernDataGridView`):**
    - Nếu không có khung chi tiết bên dưới: `Location = (20, 290)` | `Size = (1030, 420)` | `Anchor = Top, Bottom, Left, Right`.
    - Nếu có khung chi tiết bên dưới: `Location = (20, 290)` | `Size = (1030, 320)` | `Anchor = Top, Bottom, Left, Right`.

- **Màn hình Hộp thoại (`Form` - các file có đuôi `...Dialog`):**
  - Thuộc tính Form chung: `StartPosition = CenterParent`, `FormBorderStyle = FixedDialog`, `MaximizeBox = False`, `MinimizeBox = False`, `BackColor = 245, 247, 250`.
  - Bên trong Form luôn đặt 1 **`GlassCard`** làm nền chính cách đều 4 cạnh `15px` (`Location = (15, 15)`, `CornerRadius = 14`, `EnableShadow = True`).
  - Khoảng cách dọc giữa các dòng nhập liệu trong Form: **`44px` mỗi hàng** (`ModernTextBox` / `ModernComboBox` / `ModernDatePicker` đều cao chuẩn `34px - 36px`).

### 1.2. Bảng Mã Màu Chuẩn (Copy dán thẳng vào `Properties` trên Rider)
| Tên màu | Mã RGB | Dùng cho nút / thẻ nào? |
| :--- | :--- | :--- |
| **Primary Navy** | `31, 78, 121` | Nút hành động chính (Tìm, Lưu, Sửa), Header chữ chính |
| **Emerald Green** | `16, 185, 129` | Nút Thêm mới (`+ THÊM`), Xác nhận xếp lớp, Xuất Excel, Nút thành công |
| **Indigo Blue** | `79, 70, 229` | Nút Phân quyền RBAC, Nút chức năng đặc biệt |
| **Cyan Ocean** | `14, 116, 144` | Nút Audit Logs, Xem lịch sử |
| **Amber Orange** | `217, 119, 6` | Nút Reset mật khẩu, Cảnh báo vừa |
| **Rose Red** | `225, 29, 72` | Nút Khóa/Mở khóa, Xóa, Cảnh báo nguy hiểm (Vắng $\ge 3$ buổi) |
| **Purple Violet** | `126, 34, 206` | Nút Đổi trạng thái nhanh |
| **Slate Gray** | `100, 116, 139` | Nút Làm mới, Hủy bỏ, Đóng hộp thoại |

---

# 🗺️ 2. KẾ HOẠCH TRIỂN KHAI KÉO THẢ FULL TOÀN BỘ UI

Để làm hết toàn bộ giao diện mà không bị ngợp, bạn hãy kéo thả lần lượt theo **4 Giai đoạn**:

| Giai đoạn | Nhóm màn hình | Danh sách file cụ thể | Độ ưu tiên |
| :---: | :--- | :--- | :---: |
| **Bước 1** | **Khung ứng dụng chung** | 1. `LoginForm` *(Cửa sổ đăng nhập)* | **Rất cao** |
| **Bước 2** | **Phân hệ Admin (`ROLE_ADMIN`)** | 2. `AdminDashboardView`<br>3. `UserEditDialog`, `ResetPasswordDialog`, `ChangePasswordDialog`<br>4. `BruteForceMonitorDialog`, `RbacMatrixDialog`, `AuditLogViewerDialog` | **Cao** *(Bạn 1)* |
| **Bước 3** | **Phân hệ Tuyển sinh (`ROLE_EC`)** | 5. `AdmissionsDashboardView`<br>6. `LeadEditDialog`<br>7. `StudentEnrollmentDialog`<br>8. `AbsenceAlertDialog` *(Hoặc Tab trong AdmissionsDashboardView)* | **Cao** *(Bạn 1)* |
| **Bước 4** | **Khung mẫu cho Bạn 2 & Bạn 3** | 9. `FinanceDashboardView` & `PaymentReceiptDialog`<br>10. `DashboardView` *(Giám đốc)*<br>11. `AcademicDashboardView`, `ClassScheduleDialog` & `TeacherPortalView` | **Trung bình** *(Dựng khung chuẩn cho team)* |

> [!TIP]
> **Mẹo cực nhanh trong JetBrains Rider:**  
> Khi bạn tạo màn hình mới (chuột phải thư mục $\rightarrow$ `Add` $\rightarrow$ `Windows Form` hoặc `User Control`), hãy đặt tên mới tạm (ví dụ `AdmissionsViewDesign.cs`) hoặc tạo trong thư mục mới `ViewsDesigner/` để kéo thả thoải mái mà không làm hỏng code cũ đang chạy, đến lúc xong chỉ việc copy phần logic sự kiện sang!

---

# 📋 3. BẢN VẼ CHI TIẾT TỪNG MÀN HÌNH (BLUEPRINT TỪNG PIXEL)

---

## MÀN HÌNH 1: `LoginForm` (Cửa sổ Đăng nhập)
* **Loại:** `Form` | **Kích thước (`ClientSize`):** `900 x 540` | **StartPosition:** `CenterScreen`

### Sơ đồ bố cục:
```text
+-----------------------------------------------------------------------+
|  [Panel Trái: 420 x 540]           |  [GlassCard Phải: 440 x 480]     |
|  Màu nền: Deep Navy (16, 24, 38)   |  Location: (440, 30)             |
|                                    |                                  |
|     ✦  ECMS                        |  ĐĂNG NHẬP HỆ THỐNG              |
|     ENGLISH CENTER MANAGEMENT      |  Vui lòng nhập tài khoản...      |
|                                    |                                  |
|     "Hệ thống quản trị trung tâm   |  Tên đăng nhập:                  |
|      Anh ngữ chuyên nghiệp"        |  [ ModernTextBox txtUsername ]   |
|                                    |                                  |
|                                    |  Mật khẩu:                       |
|                                    |  [ ModernTextBox txtPassword ]   |
|                                    |                                  |
|                                    |  [  CustomButton btnLogin     ]  |
|                                    |  [  Label lblStatusMessage    ]  |
+------------------------------------+----------------------------------+
```

### Danh sách Component & Tọa độ chính xác:
| Component kéo thả | `(Name)` | `Location (X, Y)` | `Size (W, H)` | Thiết lập Properties quan trọng |
| :--- | :--- | :---: | :---: | :--- |
| `Panel` | `pnlLeftBrand` | `(0, 0)` | `(420, 540)` | `Dock = Left`, `BackColor = 16, 24, 38` (Deep Navy) |
| `Label` (trong `pnlLeftBrand`) | `lblBrandTitle` | `(40, 180)` | `AutoSize = True` | `Text = "ECMS PORTAL"`, `Font = Segoe UI 24pt Bold`, `ForeColor = White` |
| `Label` (trong `pnlLeftBrand`) | `lblBrandSub` | `(40, 230)` | `(340, 60)` | `Text = "Hệ thống Quản lý Trung tâm Anh ngữ..."`, `ForeColor = 203, 213, 225` |
| `GlassCard` | `cardLogin` | `(440, 30)` | `(430, 480)` | `CornerRadius = 16`, `EnableShadow = True` |
| `ModernSectionHeader` *(trong card)* | `hdrLogin` | `(24, 30)` | `(380, 48)` | `HeaderText = "ĐĂNG NHẬP HỆ THỐNG"`, `SubtitleText = "Sử dụng tài khoản nội bộ được cấp"` |
| `Label` *(trong card)* | `lblUser` | `(24, 105)` | `AutoSize = True` | `Text = "Tên đăng nhập:"`, `Font = Segoe UI 9.5pt Bold` |
| `ModernTextBox` *(trong card)* | `txtUsername` | `(24, 130)` | `(380, 38)` | `Placeholder = "Nhập username (VD: admin, counselor)..."` |
| `Label` *(trong card)* | `lblPass` | `(24, 185)` | `AutoSize = True` | `Text = "Mật khẩu:"`, `Font = Segoe UI 9.5pt Bold` |
| `ModernTextBox` *(trong card)* | `txtPassword` | `(24, 210)` | `(380, 38)` | `Placeholder = "Nhập mật khẩu..."`, `UseSystemPasswordChar = True` |
| `CustomButton` *(trong card)* | `btnLogin` | `(24, 275)` | `(380, 44)` | `Text = "ĐĂNG NHẬP NGAY"`, `NormalColor = 31, 78, 121`, `CornerRadius = 8` |
| `Label` *(trong card)* | `lblErrorMsg` | `(24, 335)` | `(380, 45)` | `Text = ""`, `ForeColor = 185, 28, 28` (Đỏ cảnh báo khóa brute-force) |

---

## MÀN HÌNH 2: `AdminDashboardView` (Quản trị Hệ thống - `ROLE_ADMIN`)
* **Loại:** `UserControl` | **Kích thước (`Size`):** `1070 x 730`

### Sơ đồ bố cục:
```text
+-----------------------------------------------------------------------+
|  [ModernSectionHeader: BÀN LÀM VIỆC KỸ THUẬT & HẠ TẦNG (ADMIN)]       |
+-----------------------------------------------------------------------+
|  [StatKpiCard 1]  [StatKpiCard 2]  [StatKpiCard 3]  [StatKpiCard 4]   |
|  Tài khoản        CSDL SQLite      Audit Logs       Bảo mật khóa      |
+-----------------------------------------------------------------------+
|  [GlassCard Toolbar: txtSearch | cboRole | cboStatus | 7 Nút Action]  |
+-----------------------------------------------------------------------+
|  [ModernDataGridView dgvUsers: Danh sách Tài khoản hệ thống]          |
|  (ID | Username | Họ tên | Email | Vai trò | Trạng thái | Khóa tạm)   |
+-----------------------------------------------------------------------+
```

### Danh sách Component & Tọa độ chính xác:
| Component kéo thả | `(Name)` | `Location (X, Y)` | `Size (W, H)` | Thiết lập Properties quan trọng |
| :--- | :--- | :---: | :---: | :--- |
| `ModernSectionHeader` | `hdrAdmin` | `(20, 15)` | `(900, 48)` | `HeaderText = "QUẢN TRỊ HỆ THỐNG (ADMINISTRATOR PORTAL)"`, `SubtitleText = "Quản trị tài khoản, phân quyền RBAC, bảo mật Brute-force & Audit Logs"` |
| `StatKpiCard` | `kpiTotalUsers` | `(20, 75)` | `(245, 120)` | `CardTitle = "TÀI KHOẢN NGƯỜI DÙNG"`, `IconSymbol = "👥"`, `AccentBackColor = 224, 242, 254` |
| `StatKpiCard` | `kpiDbStatus` | `(281, 75)` | `(245, 120)` | `CardTitle = "CSDL SQLITE (WAL)"`, `CardValue = "Online"`, `IconSymbol = "🗄️"`, `AccentBackColor = 220, 252, 231` |
| `StatKpiCard` | `kpiAuditLogs` | `(542, 75)` | `(245, 120)` | `CardTitle = "NHẬT KÝ AUDIT LOGS"`, `IconSymbol = "📜"`, `AccentBackColor = 254, 243, 199)` |
| `StatKpiCard` | `kpiLockedUsers` | `(803, 75)` | `(247, 120)` | `CardTitle = "BẢO MẬT BRUTE-FORCE"`, `IconSymbol = "🔒"`, `AccentBackColor = 254, 226, 226` |
| `GlassCard` | `cardToolbar` | `(20, 210)` | `(1030, 68)` | `Anchor = Top, Left, Right`, `CornerRadius = 10`, `EnableShadow = False` |
| `ModernTextBox` *(trong toolbar)* | `txtSearch` | `(10, 15)` | `(175, 36)` | `Placeholder = "Tìm username, họ tên..."` |
| `ModernComboBox` *(trong toolbar)* | `cboRoleFilter` | `(190, 15)` | `(115, 36)` | Lọc vai trò |
| `ModernComboBox` *(trong toolbar)* | `cboStatusFilter` | `(310, 15)` | `(120, 36)` | Lọc trạng thái |
| `CustomButton` *(trong toolbar)* | `btnSearch` | `(435, 15)` | `(50, 36)` | `Text = "TÌM"`, `NormalColor = 31, 78, 121` |
| `CustomButton` *(trong toolbar)* | `btnAddUser` | `(490, 15)` | `(75, 36)` | `Text = "+ THÊM"`, `NormalColor = 16, 185, 129` |
| `CustomButton` *(trong toolbar)* | `btnEditUser` | `(570, 15)` | `(60, 36)` | `Text = "SỬA"`, `NormalColor = 31, 78, 121` |
| `CustomButton` *(trong toolbar)* | `btnToggleActive` | `(635, 15)` | `(80, 36)` | `Text = "KHÓA/MỞ"`, `NormalColor = 225, 29, 72` |
| `CustomButton` *(trong toolbar)* | `btnResetPwd` | `(720, 15)` | `(78, 36)` | `Text = "RESET MK"`, `NormalColor = 217, 119, 6` |
| `CustomButton` *(trong toolbar)* | `btnUnlock` | `(803, 15)` | `(75, 36)` | `Text = "MỞ KHÓA"`, `NormalColor = 13, 148, 136` |
| `CustomButton` *(trong toolbar)* | `btnRbac` | `(883, 15)` | `(62, 36)` | `Text = "RBAC"`, `NormalColor = 79, 70, 229` |
| `CustomButton` *(trong toolbar)* | `btnAuditLog` | `(950, 15)` | `(70, 36)` | `Text = "LOGS"`, `NormalColor = 14, 116, 144` |
| `ModernDataGridView` | `dgvUsers` | `(20, 290)` | `(1030, 420)` | `Anchor = Top, Bottom, Left, Right` |

---

## MÀN HÌNH 3: `AdmissionsDashboardView` (Tuyển sinh & Lễ tân - `ROLE_EC`)
* **Loại:** `UserControl` | **Kích thước (`Size`):** `1070 x 730`

### Sơ đồ bố cục:
```text
+-----------------------------------------------------------------------+
|  [ModernSectionHeader: CỔNG TƯ VẤN TUYỂN SINH (COUNSELOR PORTAL)]     |
+-----------------------------------------------------------------------+
|  [StatKpiCard 1]  [StatKpiCard 2]  [StatKpiCard 3]  [StatKpiCard 4]   |
|  Tổng Leads       Mới tiếp nhận    Đang tư vấn      Cảnh báo vắng >=3 |
+-----------------------------------------------------------------------+
|  [GlassCard Toolbar: txtSearch | cboStatus | +THÊM | SỬA | ĐĂNG KÝ LỚP|
+-----------------------------------------------------------------------+
|  [ModernDataGridView dgvLeads: Danh sách Khách tiềm năng]             |
+-----------------------------------------------------------------------+
|  [GlassCard Preview: Hiển thị chi tiết ghi chú nguyện vọng khách hàng]|
+-----------------------------------------------------------------------+
```

### Danh sách Component & Tọa độ chính xác:
| Component kéo thả | `(Name)` | `Location (X, Y)` | `Size (W, H)` | Thiết lập Properties quan trọng |
| :--- | :--- | :---: | :---: | :--- |
| `ModernSectionHeader` | `hdrAdmissions` | `(20, 15)` | `(950, 48)` | `HeaderText = "CỔNG TƯ VẤN TUYỂN SINH & LỄ TÂN"`, `SubtitleText = "Tiếp nhận khách tiềm năng, đăng ký xếp lớp và theo dõi cảnh báo chuyên cần"` |
| `StatKpiCard` | `kpiTotalLeads` | `(20, 75)` | `(245, 120)` | `CardTitle = "TỔNG KHÁCH TIỀM NĂNG"`, `IconSymbol = "📋"`, `AccentBackColor = 224, 242, 254` |
| `StatKpiCard` | `kpiNewLeads` | `(281, 75)` | `(245, 120)` | `CardTitle = "MỚI TIẾP NHẬN"`, `IconSymbol = "✨"`, `AccentBackColor = 243, 232, 255` |
| `StatKpiCard` | `kpiConverted` | `(542, 75)` | `(245, 120)` | `CardTitle = "ĐÃ CHỐT NHẬP HỌC"`, `IconSymbol = "🎓"`, `AccentBackColor = 220, 252, 231` |
| `StatKpiCard` | `kpiAbsenceAlerts` | `(803, 75)` | `(247, 120)` | `CardTitle = "CẢNH BÁO VẮNG >= 3"`, `IconSymbol = "🚨"`, `AccentBackColor = 254, 226, 226`, `AccentForeColor = 185, 28, 28` *(Click mở DS cảnh báo)* |
| `GlassCard` | `cardToolbar` | `(20, 210)` | `(1030, 68)` | `Anchor = Top, Left, Right`, `CornerRadius = 10` |
| `ModernTextBox` *(trong toolbar)* | `txtSearch` | `(10, 15)` | `(190, 36)` | `Placeholder = "Tìm tên, SĐT, email..."` |
| `ModernComboBox` *(trong toolbar)* | `cboStatusFilter` | `(205, 15)` | `(140, 36)` | Lọc trạng thái Lead |
| `ModernComboBox` *(trong toolbar)* | `cboSourceFilter` | `(350, 15)` | `(125, 36)` | Lọc nguồn kênh |
| `CustomButton` *(trong toolbar)* | `btnSearch` | `(480, 15)` | `(50, 36)` | `Text = "TÌM"`, `NormalColor = 31, 78, 121` |
| `CustomButton` *(trong toolbar)* | `btnAddLead` | `(535, 15)` | `(80, 36)` | `Text = "+ THÊM"`, `NormalColor = 16, 185, 129` |
| `CustomButton` *(trong toolbar)* | `btnEditLead` | `(620, 15)` | `(60, 36)` | `Text = "SỬA"`, `NormalColor = 31, 78, 121` |
| `CustomButton` *(trong toolbar)* | `btnChangeStatus` | `(685, 15)` | `(105, 36)` | `Text = "ĐỔI STATUS"`, `NormalColor = 126, 34, 206` |
| `CustomButton` *(trong toolbar)* | `btnEnroll` | `(795, 15)` | `(130, 36)` | `Text = "ĐĂNG KÝ LỚP"`, `NormalColor = 16, 185, 129` |
| `CustomButton` *(trong toolbar)* | `btnAlerts` | `(930, 15)` | `(90, 36)` | `Text = "VẮNG >= 3"`, `NormalColor = 225, 29, 72` *(Cho Ngày 9)* |
| `ModernDataGridView` | `dgvLeads` | `(20, 290)` | `(1030, 320)` | `Anchor = Top, Bottom, Left, Right` |
| `GlassCard` | `cardPreview` | `(20, 620)` | `(1030, 95)` | `Anchor = Bottom, Left, Right`, `CornerRadius = 10` |
| `TextBox` *(trong preview)* | `txtPreviewNotes` | `(14, 30)` | `(1000, 52)` | `Multiline = True`, `ReadOnly = True`, `Anchor = Top, Bottom, Left, Right` |

---

## MÀN HÌNH 4: `StudentEnrollmentDialog` (Đăng ký Lớp, Ưu đãi 10% & Xuất Hóa đơn)
* **Loại:** `Form` (Popup Dialog) | **Kích thước (`ClientSize`):** `700 x 785`

### Danh sách Component & Tọa độ chính xác:
| Component kéo thả | `(Name)` | `Location (X, Y)` | `Size (W, H)` | Ghi chú bố cục |
| :--- | :--- | :---: | :---: | :--- |
| `GlassCard` *(nền chính)* | `cardMain` | `(14, 14)` | `(672, 757)` | Chứa toàn bộ controls bên trong |
| `ModernSectionHeader` | `hdrForm` | `(18, 12)` | `(630, 48)` | `HeaderText = "ĐĂNG KÝ XẾP LỚP & XUẤT HÓA ĐƠN"` |
| `ModernTextBox` | `txtFullName` | `(145, 95)` | `(490, 34)` | Nhập họ tên học viên |
| `ModernDatePicker` | `dtpDob` | `(145, 138)` | `(165, 34)` | Chọn ngày sinh `dd/MM/yyyy` |
| `ModernComboBox` | `cboGender` | `(415, 138)` | `(220, 34)` | Nam / Nữ / Khác |
| `ModernTextBox` | `txtPhone` | `(145, 182)` | `(165, 34)` | Nhập SĐT (Rời ô tự check Học viên cũ 10%) |
| `ModernTextBox` | `txtEmail` | `(415, 182)` | `(220, 34)` | Email liên hệ |
| `ModernTextBox` | `txtAddress` | `(145, 240)` | `(490, 34)` | Địa chỉ |
| `ModernComboBox` | `cboClasses` | `(145, 315)` | `(490, 34)` | Chọn Lớp học mở (Có hiện sĩ số x/y) |
| `RoundedPanel` | `pnlClassInfo` | `(145, 358)` | `(490, 88)` | Chứa 2 Label: `lblClassDetails` & `lblCapacityStatus` |
| `ModernComboBox` | `cboDiscounts` | `(145, 485)` | `(490, 34)` | Chọn Ưu đãi (Giảm 10% HV cũ / 15% Nhóm) |
| `RoundedPanel` | `pnlFeeSummary` | `(145, 528)` | `(490, 95)` | Chứa `lblOriginalFee`, `lblDiscountAmount`, `lblFinalFee` |
| `CustomButton` | `btnConfirm` | `(145, 642)` | `(280, 42)` | `Text = "XÁC NHẬN & XUẤT HÓA ĐƠN"`, `NormalColor = 16, 185, 129` |
| `CustomButton` | `btnCancel` | `(440, 642)` | `(110, 42)` | `Text = "HỦY BỎ"`, `NormalColor = 100, 116, 139` |

---

## MÀN HÌNH 5: CÁC DIALOG NHỎ CỦA PHÂN HỆ ADMIN & COUNSELOR (THAM KHẢO KÍCH THƯỚC CHUẨN)

| Tên Dialog | Kích thước Form (`ClientSize`) | Các Component chính bên trong |
| :--- | :---: | :--- |
| **`LeadEditDialog`** *(Thêm/Sửa Lead)* | `580 x 560` | 1 `GlassCard` + 3 `ModernTextBox` (Tên, SĐT, Email) + 2 `ModernComboBox` (Nguồn, Trạng thái) + 1 `TextBox` Multiline (Ghi chú) + 2 `CustomButton` (Lưu, Hủy). |
| **`UserEditDialog`** *(Thêm/Sửa User)* | `560 x 580` | 1 `GlassCard` + 4 `ModernTextBox` (Username, Họ tên, Email, Password) + 1 `ModernComboBox` (Vai trò) + 1 `ModernToggleSwitch` (Kích hoạt) + 2 `CustomButton`. |
| **`ResetPasswordDialog`** / **`ChangePasswordDialog`** | `500 x 380` | 1 `GlassCard` + 2-3 `ModernTextBox` (`UseSystemPasswordChar = True`) + 2 `CustomButton` (Xác nhận, Hủy). |
| **`BruteForceMonitorDialog`** *(Mở khóa khẩn cấp)* | `880 x 600` | 1 `GlassCard` + 2 `StatKpiCard` (Đang bị khóa / Đã sai mật khẩu) + 1 `ModernDataGridView` + 2 `CustomButton` (Mở khóa chọn, Mở khóa tất cả). |
| **`AuditLogViewerDialog`** *(Tra cứu Audit)* | `1200 x 760` | 4 `StatKpiCard` + 1 `GlassCard` Filter (`ModernToggleSwitch` lọc ngày, 2 `ModernDatePicker`, 2 `ModernComboBox`, `ModernTextBox`, 3 `CustomButton`) + 1 `ModernDataGridView` + 1 `GlassCard` so sánh Old/New Values. |
| **`AbsenceAlertDialog`** *(Cảnh báo vắng >= 3 buổi - Ngày 9)* | `960 x 620` | `ModernSectionHeader` (Màu đỏ Rose) + 2 `StatKpiCard` (Số HV nguy hiểm, Số ca chưa nhắc) + `ModernDataGridView` + `CustomButton` ("ĐÃ GỌI NHẮC NHỞ"). |

---

## MÀN HÌNH 6: KHUNG CHUẨN CHO BẠN 2 (`ROLE_ACC` & `ROLE_MGR`)

### 6A. `FinanceDashboardView` (Kế toán / Thu ngân - `1070 x 730`)
| Khu vực | Component & `(Name)` | `Location (X, Y)` | `Size (W, H)` | Ghi chú |
| :--- | :--- | :---: | :---: | :--- |
| **Header** | `ModernSectionHeader hdrFinance` | `(20, 15)` | `(900, 48)` | `"CỔNG KẾ TOÁN & THU NGÂN (FINANCE PORTAL)"` |
| **4 KPIs** | `kpiTotalReceivable`, `kpiCollectedToday`, `kpiUnpaidCount`, `kpiDebtAmount` | Hàng ngang `Y = 75` | `245 x 120` mỗi thẻ | Lần lượt `X = 20, 281, 542, 803` |
| **Toolbar** | `GlassCard cardToolbar` | `(20, 210)` | `(1030, 68)` | Chứa: `txtSearch` `(10, 15, 250, 36)`, `cboInvoiceStatus` `(270, 15, 160, 36)`, `btnFilter` `(440, 15, 70, 36)`, `btnCollectPayment` **"💵 THU TIỀN & IN BIÊN LAI"** (`X = 760, W = 255, Color = 16, 185, 129`) |
| **Grid** | `ModernDataGridView dgvInvoices` | `(20, 290)` | `(1030, 420)` | Cột: Mã HĐ, Tên HV, Lớp, Gốc, Giảm, Phải thu, Đã đóng, Còn nợ, Trạng thái |

### 6B. `PaymentReceiptDialog` (Thu nhiều đợt & In biên lai A5 - `620 x 560`)
- Chứa 1 `GlassCard (590 x 530)` ở `(15, 15)`.
- Hiển thị thông tin Hóa đơn (`RoundedPanel`): Mã HĐ, Tên HV, Tổng học phí, Số tiền còn nợ (`BalanceDue`).
- `ModernToggleSwitch chkPayFull`: *"Đóng toàn bộ công nợ (100%)"*.
- `ModernTextBox txtAmountToPay`: Nhập số tiền thu đợt này (cho phép đóng nhiều đợt).
- `ModernComboBox cboPaymentMethod`: Tiền mặt / Chuyển khoản / Quẹt thẻ POS.
- `ModernTextBox txtNote`: Ghi chú phiếu thu.
- `CustomButton btnPayAndPrint`: `"XÁC NHẬN THU & IN BIÊN LAI A5"` (`NormalColor = 16, 185, 129`).

### 6C. `DashboardView` (Giám đốc điều hành - `1070 x 730`)
- Header: `ModernSectionHeader` (`"BÀN LÀM VIỆC GIÁM ĐỐC ĐIỀU HÀNH (DIRECTOR PORTAL)"`).
- 4 `StatKpiCard` (`Y = 75`): Doanh thu thực thu tháng | Tổng học viên đang học | Số lớp đang mở | Công nợ tồn đọng.
- 1 `ModernDataGridView` (`Location = (20, 220), Size = (1030, 490)`): Bảng tổng hợp các phiếu thu mới nhất và tình hình lấp đầy lớp học.

---

## MÀN HÌNH 7: KHUNG CHUẨN CHO BẠN 3 (`ROLE_AA` & `ROLE_TEA` - Đã bỏ Phụ huynh)

### 7A. `AcademicDashboardView` (Giáo vụ đào tạo - `1070 x 730`)
- Header: `ModernSectionHeader` (`"QUẢN LÝ ĐÀO TẠO & LỊCH HỌC (ACADEMIC PORTAL)"`).
- 4 `StatKpiCard` (`Y = 75`): Tổng Khóa học | Lớp đang mở | Tổng Phòng học | Giáo viên giảng dạy.
- `TabControl` hiện đại hoặc 2 `CustomButton` chuyển tab (`"1. KHÓA HỌC & LỚP HỌC"` | `"2. XẾP LỊCH HỌC CHỐNG TRÙNG"`).
- `GlassCard` Toolbar (`Location = (20, 210), Size = (1030, 68)`): `txtSearch`, `+ THÊM KHÓA HỌC`, `+ MỞ LỚP MỚI`, `📅 XẾP THỜI KHÓA BIỂU`.
- `ModernDataGridView dgvClasses` (`Location = (20, 290), Size = (1030, 420)`): Mã lớp, Tên lớp, Khóa học, Phòng học, Giáo viên, Sĩ số `x/y`, Ngày khai giảng.

### 7B. `ClassScheduleDialog` (Xếp Lịch học & Chống trùng lịch - `720 x 540`)
- `ModernComboBox cboClass`, `ModernComboBox cboRoom`, `ModernComboBox cboTeacher`.
- `ModernDatePicker dtpDate`, `ModernTextBox txtStartTime` (`18:00`), `ModernTextBox txtEndTime` (`20:00`).
- `CustomButton btnSaveSchedule`: Chạy thuật toán `ValidateScheduleConflictAsync` (báo lỗi đỏ nếu trùng phòng hoặc trùng giờ giáo viên).

### 7C. `TeacherPortalView` (Cổng Giảng viên: Điểm danh & Bảng điểm - `1070 x 730`)
- Header: `ModernSectionHeader` (`"CỔNG GIẢNG VIÊN: ĐIỂM DANH & ĐIỂM THI (TEACHER PORTAL)"`).
- `GlassCard` Toolbar (`Location = (20, 80), Size = (1030, 68)`):
  - `ModernComboBox cboMyClasses` (Chọn lớp mình phụ trách).
  - `ModernDatePicker dtpSessionDate` (Chọn ngày điểm danh).
  - `CustomButton btnModeAttendance` (`"📋 SỔ ĐIỂM DANH"`).
  - `CustomButton btnModeGrades` (`"📝 BẢNG ĐIỂM & CHỨNG NHẬN"`).
  - `CustomButton btnSaveAll` (`"💾 LƯU DỮ LIỆU"`, `NormalColor = 16, 185, 129`).
  - `CustomButton btnPrintCert` (`"🎓 IN CHỨNG NHẬN A4"`, `NormalColor = 79, 70, 229`).
- `ModernDataGridView dgvClassroom` (`Location = (20, 165), Size = (1030, 545)`): Hiển thị danh sách học viên của lớp để tích điểm danh (`Có mặt` / `Vắng phép` / `Vắng không phép`) hoặc nhập điểm Giữa kỳ, Cuối kỳ $\rightarrow$ tự tính điểm TB.

---

# 🔄 4. QUY TRÌNH 4 BƯỚC KÉO THẢ & NỐI CODE TRONG JETBRAINS RIDER

1. **Bước 1 — Rebuild trước khi mở Designer:** Bấm `Ctrl + Shift + B` để Rider nạp đủ 11 component trong `ECMS UI Kit` lên thanh Toolbox.
2. **Bước 2 — Kéo khung chứa lớn trước, thành phần nhỏ sau:**
   - Với màn hình chính (`UserControl`): Đặt `Size = (1070, 730)`, `BackColor = 245, 247, 250`. Kéo `ModernSectionHeader`, rồi 4 `StatKpiCard`, rồi `GlassCard` Toolbar, rồi `ModernDataGridView`.
   - Với `GlassCard` Toolbar: Kéo thẻ `GlassCard` ra trước, rồi mới kéo nút `CustomButton`, `ModernTextBox` **thả vào bên trong** thẻ `GlassCard` đó!
3. **Bước 3 — Đặt `(Name)` và `Anchor` chuẩn:**
   - Gõ `(Name)` đúng theo bảng đặc tả (VD: `txtSearch`, `dgvLeads`, `btnEnroll`) ở mục Design trong cửa sổ Properties.
   - Đừng quên chỉnh `Anchor = Top, Bottom, Left, Right` cho `ModernDataGridView` để khi phóng to cửa sổ phần mềm, bảng tự giãn theo rất đẹp!
4. **Bước 4 — Nối sự kiện sang Service (Click đúp chuột):**
   - Nhấp đúp chuột vào nút `CustomButton` trên Designer $\rightarrow$ Rider tự nhảy vào hàm `btnSave_Click(...)` trong file `.cs`.
   - Gọi hàm Service đã viết ở tầng `ECMS.Business` (Ví dụ: `await _leadService.CreateLeadAsync(...)`).
