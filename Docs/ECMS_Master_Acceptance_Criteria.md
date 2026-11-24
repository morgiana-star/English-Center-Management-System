# BỘ TIÊU CHÍ NGHIỆM THU TOÀN DIỆN HỆ THỐNG ECMS (MASTER ACCEPTANCE CRITERIA)
> **Mục đích:** Danh sách tiêu chí bắt buộc phải đạt ở mọi màn hình, mọi nút bấm và mọi luồng nghiệp vụ liên kết khi chạy ứng dụng **ECMS** trên máy.  
> **Cách dùng:** Chạy app từ `ECMS.UI`, đi kiểm tra lần lượt từng mục từ **Phần 1 $\rightarrow$ Phần 8**. Đánh dấu `[x]` nếu đạt, giữ `[ ]` và ghi chú lỗi/chỗ cần sửa ở cột/mục **Ghi chú kiểm tra** để tổng hợp chỉnh sửa.

---

## PHẦN 1: TIÊU CHUẨN CHUNG TOÀN HỆ THỐNG (GLOBAL STANDARDS)

- [ ] **G-01 | Khởi tạo CSDL sạch & ổn định:** Khi mở app lần đầu (hoặc có sẵn `%APPDATA%\ECMS\ecms_data.db`), ứng dụng khởi động mượt mà, không văng lỗi SQLite (`no such column`, `FOREIGN KEY constraint failed`, `CHECK constraint failed`).
- [ ] **G-02 | 100% Dữ liệu thật (No Mock Data):** Tất cả số liệu, danh sách, biểu đồ, chi tiết học viên, hóa đơn, tài khoản, cấu hình ở các phân hệ đã hoàn thiện đều đọc/ghi trực tiếp với SQLite; tắt app mở lại vẫn giữ nguyên trạng thái đã thay đổi.
- [ ] **G-03 | Không văng Unhandled Exception:** Khi thao tác sai, nhập thiếu, hoặc hủy hộp thoại, hệ thống chỉ hiện thông báo thân thiện (`AppDialog` / `MessageBox`), tuyệt đối không hiện cửa sổ crash mặc định của .NET (`Continue / Quit`).
- [ ] **G-04 | Giao diện & Responsive:** Khi phóng to/thu nhỏ cửa sổ `MainForm` hoặc các Dialog, nút bấm không bị chồng chéo lên tiêu đề, không bị che khuất chữ, bảng `DataGridView` có thanh cuộn đầy đủ khi nhiều dữ liệu.
- [ ] **G-05 | Build sạch:** Giải pháp `ECMS.sln` build đạt `0 Error(s)` và `0 Warning(s)`.

---

## PHẦN 2: LUỒNG ĐĂNG NHẬP, SESSION & ĐIỀU HƯỚNG (`LoginForm` & `MainForm`)

### 2.1. Màn hình Đăng nhập (`LoginForm`)
- [ ] **L-01 | Kiểm tra rỗng:** Bỏ trống Tên đăng nhập hoặc Mật khẩu rồi bấm **Đăng nhập** $\rightarrow$ hiện cảnh báo lỗi rõ ràng, không cho đi tiếp.
- [ ] **L-02 | Hiện/Ẩn mật khẩu:** Tick/bỏ tick **Hiển thị mật khẩu** $\rightarrow$ ký tự mật khẩu ẩn/hiện đúng tức thì.
- [ ] **L-03 | Sai mật khẩu & Chống Brute-force:** Nhập sai mật khẩu $\rightarrow$ báo sai thông tin; nhập sai quá số lần quy định $\rightarrow$ khóa tạm thời/cảnh báo đúng cơ chế `AuthService`.
- [ ] **L-04 | Chặn tài khoản ngoài nội bộ:** Đăng nhập bằng `student` (`Student@123`) hoặc `parent` (`Parent@123`) $\rightarrow$ hệ thống từ chối đăng nhập vì đây là app quản trị nội bộ.
- [ ] **L-05 | Đăng nhập đúng bằng dữ liệu SQLite:** Đăng nhập `admin` / `Admin@123` (hoặc tài khoản đã đổi mật khẩu ở Tab Tài khoản cá nhân) $\rightarrow$ vào đúng `MainForm`, góc trên phải hiện đúng `Họ tên · Vai trò`.

### 2.2. Khung chính & Sidebar (`MainForm`)
- [ ] **M-01 | Trạng thái nút đang chọn (`Active State`):** Click lần lượt *Tổng quan $\rightarrow$ Học viên $\rightarrow$ Tài khoản & Phân quyền $\rightarrow$ Cấu hình* $\rightarrow$ chỉ duy nhất nút phân hệ đang mở được tô đậm nổi bật, nút cũ tự động trở về chữ thường màu xám.
- [ ] **M-02 | Phân quyền Sidebar theo vai trò (RBAC):** Đăng nhập từng tài khoản (`admin`, `manager`, `counselor`, `accountant`, `academic`, `teacher`) $\rightarrow$ Sidebar chỉ hiện các phân hệ được cấp quyền cho vai trò đó trong bảng cấu hình phân quyền.
- [ ] **M-03 | Click tên người dùng trên Header:** Bấm vào tên tài khoản góc trên phải $\rightarrow$ điều hướng đúng tới thông tin tài khoản/hồ sơ cá nhân (hoặc hiện menu tương ứng) không lỗi.
- [ ] **M-04 | Đăng xuất (`LogoutConfirmDialog`):** Bấm **Đăng xuất** $\rightarrow$ hiện hộp thoại xác nhận; xác nhận xong xóa sạch `AppSession`, đóng `MainForm` và quay lại `LoginForm`.

---

## PHẦN 3: PHÂN HỆ A · TỔNG QUAN (`DashboardOverviewView`)

- [ ] **D-01 | 6 thẻ KPI thật từ SQLite:** *Tổng học viên, Đang học, Lớp hoạt động, Giáo viên, Doanh thu tháng hiện tại, Công nợ tồn* hiển thị đúng số liệu thật trong DB (khi thêm học viên mới hoặc thu tiền mới, quay lại Tổng quan số liệu phải tự tăng/giảm tương ứng).
- [ ] **D-02 | Biểu đồ Doanh thu & Tăng trưởng học viên:** Cả 2 biểu đồ hiển thị **cùng số cột (6 tháng)**, chiều cao cột và nhãn số liệu khớp với dữ liệu trong `Payments` và `Enrollments`.
- [ ] **D-03 | Chuyên cần lớp học:** Phần trăm chuyên cần trung bình và bảng nhóm lớp (Khóa học, Số lớp, Học viên) lấy thật từ `AttendanceRecords`, `Courses`, `Classes`, `Enrollments`.
- [ ] **D-04 | Lịch học hôm nay & Sắp khai giảng:** Bảng dưới hiển thị Giờ/Ngày, Lớp, Phòng, Giáo viên, Sĩ số, Trạng thái lớp khớp với `ClassSchedules`, `Classes`, `Teachers`, `ClassRooms`.
- [ ] **D-05 | Nút "Xem chi tiết" & `QuickDetailGridDialog`:** Cả 4 nút **Xem chi tiết** nằm gọn ở **góc trên bên phải** mỗi card (không đè lên tiêu đề); bấm vào từng nút đều mở `QuickDetailGridDialog` kích thước lớn (`1120x680`), bảng đủ cột/dòng và có thanh cuộn.
- [ ] **D-06 | Tìm kiếm nhanh:** Nhập từ khóa (tên/mã học viên, lớp, khóa học) và bấm **Tìm kiếm** (hoặc nhấn `Enter`) $\rightarrow$ hiện kết quả nhiều dòng dạng `DataGridView` trong dialog, không bị thiếu dữ liệu hay cắt cột.
- [ ] **D-07 | Danh sách cần xử lý (Cảnh báo vắng):**
  - Bấm nút **Danh sách cần xử lý** $\rightarrow$ hiện danh sách học viên có số buổi vắng $\ge$ `MaxAbsencesAlert` (lấy từ Cấu hình).
  - Đổi trạng thái dòng từ `Chưa xử lý` $\leftrightarrow$ `Đã xử lý` hoặc bấm **Xóa** $\rightarrow$ đóng dialog/đổi tab quay lại vẫn giữ nguyên trạng thái đã lưu trong bảng `AbsenceAlertStates`.
- [ ] **D-08 | Xuất báo cáo:** Bấm **Xuất báo cáo** $\rightarrow$ chọn nơi lưu `.csv` $\rightarrow$ file xuất ra mở được bằng Excel/Notepad, tiếng Việt có dấu hiển thị chuẩn (UTF-8 BOM), số liệu khớp với trên màn hình.

---

## PHẦN 4: PHÂN HỆ B · ĐÀO TẠO

### 4.1. Học viên (`StudentManagementView` & các Dialog liên kết)
- [ ] **S-01 | 4 thẻ thống kê & Giao diện lọc:** *Tổng số hồ sơ, Đang học, Hoàn thành, Đã lưu trữ* khớp SQLite; không còn 2 ô lọc trạng thái/lớp thừa; cột thao tác là nút **Xem chi tiết**.
- [ ] **S-02 | Tìm kiếm realtime:** Gõ mã HV (`HV-...`), họ tên hoặc SĐT vào ô tìm kiếm $\rightarrow$ bảng lọc ngay lập tức theo dữ liệu khớp.
- [ ] **S-03 | Xem chi tiết 360° (`StudentDetailDialog`):**
  - **Tab Tổng quan:** Hiện đúng thông tin cá nhân, phụ huynh, lớp hiện tại, tiến độ buổi học, chuyên cần (`0.0%` nếu mới tạo chưa điểm danh buổi nào), công nợ, điểm đầu vào/thường xuyên/giữa khóa/cuối khóa từ SQLite.
  - **Tab Quá trình học tập:** Liệt kê tất cả lớp/khóa học học viên đã ghi danh kèm điểm số, chuyên cần, trạng thái học phí thật.
- [ ] **S-04 | Sửa hồ sơ (`AddStudentDialog`):** Từ `StudentDetailDialog` bấm **Sửa hồ sơ** $\rightarrow$ sửa họ tên/SĐT/địa chỉ/phụ huynh $\rightarrow$ Lưu $\rightarrow$ dữ liệu cập nhật xuống SQLite và hiển thị mới ngay.
- [ ] **S-05 | Lưu trữ & Khôi phục:** Trong chi tiết bấm **Lưu trữ** $\rightarrow$ học viên biến mất khỏi danh sách chính, thẻ *Đã lưu trữ* tăng 1; bấm **Xem hồ sơ lưu trữ** $\rightarrow$ thấy học viên đó $\rightarrow$ bấm **Khôi phục** $\rightarrow$ quay lại danh sách chính.
- [ ] **S-06 | Xuất danh sách CSV:** Bấm **Xuất danh sách** $\rightarrow$ lưu file `.csv` mở ngoài đọc chuẩn tiếng Việt.
- [ ] **S-07 | Luồng `+ Đăng ký học` (`StudentEnrollmentWizardDialog` + `CollectTuitionDialog` + `ReceiptPrintPreviewDialog`):**
  - **Bước 1:** Nhập thông tin học viên + người liên hệ (validate SĐT, họ tên bắt buộc).
  - **Bước 2:** Chọn **Khóa học** (lấy từ DB) $\rightarrow$ danh sách **Lớp** tự lọc theo khóa học đó; lọc theo **Ca học** (*Tất cả / Sáng / Chiều / Tối*) hoạt động đúng; cột sĩ số sắp xếp được.
  - **Bước 3 (Thu học phí):** Học viên hiển thị bằng **Label** (`Tên · Mã HV`), không còn dropdown chọn; chọn đóng đủ 100% hoặc đóng đợt 1 (còn nợ); chọn phương thức thanh toán (*Tiền mặt / Chuyển khoản / POS*).
  - **Phiếu thu (`ReceiptPrintPreviewDialog`):** Tên/địa chỉ trung tâm lấy từ Cấu hình; **Số tiền bằng chữ đọc đúng tiếng Việt cho mọi mệnh giá**; hiển thị đúng mã phiếu, lý do thu, số dư còn lại.
  - **Kết quả cuối:** Học viên mới xuất hiện ngay trong danh sách Học viên, đồng thời xuất hiện hóa đơn/phiếu thu tương ứng bên phân hệ Tài chính.
- [ ] **S-08 | Luồng `📥 Nhập Excel` (`ImportStudentsDialog`):**
  - Bấm **Tải tệp mẫu (.xlsx)** $\rightarrow$ lưu và mở được file Excel mẫu có định dạng chuẩn.
  - Bấm **Chọn tệp dữ liệu** (`.xlsx` hoặc `.csv`) $\rightarrow$ tự kiểm tra lỗi định dạng SĐT, thiếu họ tên, trùng SĐT trong file hoặc trùng trong DB; tô màu xanh/đỏ rõ ràng.
  - Bấm **Tiến hành nhập** $\rightarrow$ chỉ nạp các dòng hợp lệ vào SQLite Transaction, tự sinh mã `HV-yyyy-xxxx`, liên kết phụ huynh và reload danh sách.

### 4.2. Giáo viên (`TeacherManagementView`, `AddTeacherDialog`)
- [ ] **T-01 | Đồng bộ SQLite:** Danh sách giáo viên hiển thị dữ liệu thật từ bảng `Teachers` (khớp với tên giáo viên đang hiện trên Dashboard và Lịch học, không còn danh sách mẫu cứng).
- [ ] **T-02 | Tìm kiếm, Lọc & Thêm/Sửa GV:** Tìm kiếm theo mã/tên/SĐT, lọc trạng thái/chuyên môn, thêm mới hoặc sửa thông tin GV lưu xuống DB.

### 4.3. Khóa học (`CourseManagementView`, `CourseEditDialog`, `CourseDetailDialog`)
- [ ] **C-01 | Danh sách & CRUD Khóa học:** Hiển thị khóa học từ `Courses`, thêm/sửa khóa học, học phí chuẩn (`BaseTuitionFee`), số buổi (`TotalSessions`).
- [ ] **C-02 | Liên kết sang Lớp học & Đăng ký học:** Khóa học đang hoạt động (`IsActive = 1`) xuất hiện ở dropdown Khóa học khi mở lớp mới hoặc khi đăng ký học viên mới.

### 4.4. Lớp học (`ClassManagementView`, `CreateClassDialog`, `ClassDetailDialog`, `SelectStudentsForClassDialog`, `ClassTransferCompleteDialog`)
- [ ] **CL-01 | Mở lớp & Trạng thái hợp lệ:** Tạo lớp mới lưu đúng `Classes.Status` (`Planning`, `OpenForEnrollment`, `InProgress`, `Completed`, `Cancelled`).
- [ ] **CL-02 | Thêm học viên vào lớp & Chuyển lớp:** Không cho vượt quá `MaxStudents`; chuyển lớp cập nhật đúng `Enrollments`.

### 4.5. Lịch học & Phòng học (`ScheduleManagementView`, `CreateScheduleDialog`, `EditRoomDialog`, `RoomManagementDialog`)
- [ ] **SC-01 | Quản lý phòng học:** Thêm/sửa phòng học trong `ClassRooms` (tên phòng, sức chứa, trạng thái).
- [ ] **SC-02 | Xếp lịch chống trùng:** Khi tạo buổi học ở `ClassSchedules`, hệ thống kiểm tra và cảnh báo nếu bị **trùng phòng học** hoặc **trùng giáo viên** trong cùng ngày và khung giờ.
- [ ] **SC-03 | Đồng bộ chéo:** Buổi học vừa xếp xuất hiện trên bảng Lịch học hôm nay ở Dashboard và màn hình Điểm danh.

### 4.6. Điểm danh (`TeacherAttendanceCheckView`, `TeacherAttendanceSummaryView`, `ClassAttendanceDialog`)
- [ ] **AT-01 | Điểm danh buổi học:** Chọn lớp & buổi học, đánh dấu `Present` / `Late` / `Absent` / `Excused`, lưu vào `AttendanceRecords`.
- [ ] **AT-02 | Đồng bộ chuyên cần & Cảnh báo:** Sau khi điểm danh, `%` chuyên cần ở `StudentDetailDialog` và Dashboard tự cập nhật; học viên có số buổi `Absent` $\ge$ `MaxAbsencesAlert` tự động xuất hiện trong **Danh sách cần xử lý** ở Dashboard.

### 4.7. Kiểm tra & Điểm số (`TeacherGradeEntryView`, `TeacherGradeManagementView`, `CreateAssessmentDialog`, `GradeEntryDialog`)
- [ ] **GR-01 | Tạo kỳ thi & Nhập điểm:** Tạo bài kiểm tra (`Regular`, `Midterm`, `Final`, `Placement`) trong `Exams` và nhập điểm (`0..10`) vào `ExamScores`.
- [ ] **GR-02 | Đồng bộ bảng điểm:** Điểm đã nhập hiển thị chính xác trong Tab Tổng quan & Tab Quá trình học tập của `StudentDetailDialog` và dùng để xét điều kiện Chứng chỉ.

### 4.8. Tài liệu học tập (`StudyMaterialView`)
- [ ] **SM-01 | Danh sách & Thao tác tài liệu:** Nạp đúng danh mục tài liệu gắn với khóa học/lớp học, thêm/xem/mở tệp tài liệu không báo lỗi đường dẫn.

### 4.9. Chứng chỉ (`CertificateManagementView`, `ApproveCertificateDialog`, `CertificateRegistryDialog`, `CertificatePrintPreviewDialog`)
- [ ] **CT-01 | Tham chiếu quy tắc từ Cấu hình:** Dòng tiêu chuẩn phía dưới hiển thị đúng `PassingScore` và `MinAttendanceRate` lấy từ `SystemConfigs`; khi thay đổi ở Cấu hình thì danh sách đủ điều kiện/chưa đủ điều kiện ở đây tự cập nhật lại.
- [ ] **CT-02 | Cấp chứng chỉ & Sổ chứng chỉ:** Tick học viên đủ điều kiện $\rightarrow$ bấm **Cấp chứng chỉ** $\rightarrow$ sinh số hiệu, lưu vào Sổ chứng chỉ (`CertificateRegistryDialog`) và xem trước bản in (`CertificatePrintPreviewDialog`).

---

## PHẦN 5: PHÂN HỆ C · TÀI CHÍNH (`TuitionPaymentView` & Dialogs)

- [ ] **F-01 | Đồng bộ dữ liệu Học phí từ Wizard:** Học viên mới thêm và đóng tiền đợt 1 từ phân hệ Học viên phải hiện ngay trong danh sách hồ sơ học phí & lịch sử phiếu thu ở đây (khớp số đã đóng, số còn nợ).
- [ ] **F-02 | Thu học phí nhiều đợt (`TuitionDetailDialog`, `CollectTuitionDialog`, `PaymentConfirmDialog`, `PaymentSuccessDialog`):**
  - Chọn học viên còn nợ $\rightarrow$ thu tiếp đợt 2 $\rightarrow$ `Invoices.BalanceDue` giảm đúng số tiền thu, `Invoices.Status` chuyển từ `Unpaid` $\rightarrow$ `PartiallyPaid` $\rightarrow$ `Paid` khi trả hết.
  - Ghi nhận bản ghi mới vào `Payments` với `Status = 'Valid'` và phương thức tiếng Việt chuẩn (`Tiền mặt`, `Chuyển khoản`, `POS`).
- [ ] **F-03 | In biên lai & Đồng bộ Dashboard:** Xem trước biên lai (`ReceiptPrintPreviewDialog`) hiển thị đúng số tiền bằng chữ tiếng Việt và số dư còn lại; doanh thu và công nợ trên Dashboard thay đổi đúng theo khoản vừa thu.

---

## PHẦN 6: PHÂN HỆ D1 · TÀI KHOẢN & PHÂN QUYỀN (`AccountManagementView`, `EditAccountDialog`, `ResetPasswordDialog`)

- [ ] **A-01 | Tab 1 — Tài khoản người dùng:**
  - Danh sách và bộ lọc vai trò **không chứa** `Học viên` và `Phụ huynh`; không có nút Xuất danh sách.
  - Ô tìm kiếm lọc đúng theo tên đăng nhập / họ tên / email.
  - Dialog Thêm/Sửa tài khoản (`EditAccountDialog`) không còn mục *Hồ sơ liên kết*; lưu mới/sửa/khóa/mở khóa/reset mật khẩu xuống bảng `Users` thành công.
- [ ] **A-02 | Tab 2 — Vai trò & Phân quyền:**
  - Hiển thị ma trận **13 phân hệ tiếng Việt** (trùng tên Sidebar) x **6 vai trò nội bộ** (đã bỏ Học viên/Phụ huynh).
  - Bỏ tick hoặc tick thêm quyền cho 1 vai trò $\rightarrow$ bấm **Lưu** $\rightarrow$ Sidebar `MainForm` (khi đăng nhập bằng vai trò đó) ẩn/hiện đúng theo cấu hình mới.
- [ ] **A-03 | Tab 3 — Tài khoản cá nhân:**
  - Panel trái đã ẩn dòng *Quyền* và *Chi nhánh*; bên thông tin hiển thị nhãn `Vai trò`.
  - Cập nhật Họ tên / SĐT / Email cá nhân $\rightarrow$ Lưu thành công vào SQLite (kể cả tài khoản `admin`).
  - Đổi mật khẩu ở tab con Đổi mật khẩu $\rightarrow$ thoát app hoàn toàn, mở lại app và đăng nhập bằng **mật khẩu mới** thành công.

---

## PHẦN 7: PHÂN HỆ D2 · CẤU HÌNH HỆ THỐNG (`SystemConfigView`, `CreateBackupDialog`, `RestoreDatabaseDialog`)

- [ ] **CF-01 | Tab 1 — Thông tin trung tâm & CSDL:**
  - Đã ẩn *Người đại diện / Ký duyệt*, *Chức vụ người ký*, *Thư mục lưu trữ tài liệu học tập*; nhóm dưới có tiêu đề **Cơ sở dữ liệu**.
  - Lưu thông tin trung tâm thành công mà không bị bắt buộc nhập tên người đại diện; tên và địa chỉ trung tâm đồng bộ lên Phiếu thu (`ReceiptPrintPreviewDialog`).
  - Bấm nút **Kiểm tra** $\rightarrow$ hiện popup thông báo đường dẫn, dung lượng, Journal Mode, Foreign Keys, số bảng và `PRAGMA integrity_check: ok`.
- [ ] **CF-02 | Tab 2 — Quy tắc điểm & Chuyên cần:**
  - Đã ẩn 3 checkbox nâng cao; giữ lại Thang điểm, Điểm đạt chuẩn, Trọng số (Thường xuyên + Giữa khóa + Cuối khóa), Tỷ lệ chuyên cần tối thiểu, Ngưỡng cảnh báo vắng.
  - Nhập tổng 3 trọng số $\ne 100\%$ $\rightarrow$ chặn lưu và báo lỗi rõ ràng.
  - Tổng $= 100\%$ $\rightarrow$ lưu thành công và đồng bộ sang **Chứng chỉ** (`PassingScore`, `MinAttendanceRate`) và **Dashboard** (`MaxAbsencesAlert`).
- [ ] **CF-03 | Tab 3 — Sao lưu & Khôi phục:**
  - Bấm **Tạo bản sao lưu ngay** $\rightarrow$ tạo file backup thực tế trên ổ đĩa và hiện lên lưới danh sách.
  - Bấm **Mở thư mục** $\rightarrow$ mở đúng thư mục chứa file backup trên Windows Explorer.
  - Bấm **Phục hồi** (trên lưới hoặc chọn file ngoài) $\rightarrow$ xác nhận $\rightarrow$ phục hồi thành công không văng lỗi, nạp lại dữ liệu toàn màn hình.
  - Bấm **Xóa** $\rightarrow$ xóa file backup khỏi đĩa và khỏi lưới.

---

## PHẦN 8: NHẬT KÝ KIỂM TRA & CÁC ĐIỂM CẦN CHỈNH SỬA (DÀNH CHO NGƯỜI KIỂM TRA GHI CHÚ)

> *Sau khi chạy app và rà soát theo các mục trên, bạn ghi lại những điểm lỗi / chưa khớp hoặc muốn chỉnh sửa theo mẫu dưới đây để gửi lại:*

| STT | Phân hệ / Màn hình | Mã tiêu chí liên quan | Mô tả lỗi / Điểm cần chỉnh sửa | Mức độ (Cao / TB / Thấp) |
| :-: | :--- | :---: | :--- | :---: |
| 1 | *(Ví dụ: Giáo viên)* | `T-01` | *(Chưa nối SQLite sau khi gộp code...)* | Cao |
| 2 | | | | |
| 3 | | | | |
| 4 | | | | |
