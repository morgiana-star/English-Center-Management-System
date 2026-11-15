# SỔ TAY ĐẶC TẢ CHI TIẾT TỪNG MÀN HÌNH VÀ LUỒNG NGHIỆP VỤ ECMS
*(Dành riêng cho việc Thiết kế Bố cục Giao diện & Hiện thực hóa Chức năng)*

---

## 📌 HƯỚNG DẪN DÀNH CHO BẠN (CÁCH DÙNG TÀI LIỆU NÀY)
Tài liệu này được biên soạn để trả lời 4 câu hỏi lớn cho **từng màn hình** trong hệ thống:
1. **Mục đích của màn hình là gì?** (Ai dùng, mở lên khi nào, giải quyết bài toán gì?)
2. **Cần thể hiện những thông tin gì?** (Các khối dữ liệu, cột bảng, chỉ số KPI, lấy từ bảng SQLite nào?)
3. **Người dùng thao tác những gì & Kết quả phản hồi ra sao?** (Bấm nút gì, form nhập gì, chọn bộ lọc nào, mở popup nào?)
4. **Các ràng buộc nghiệp vụ & logic bắt buộc?** (Điều kiện chặn lỗi, quy tắc tính toán tự động).

Bạn có thể tự do sáng tạo bố cục (vị trí nút, màu sắc, phân chia cột/dòng, popup hay inline form) dựa trên danh sách các thành phần bắt buộc dưới đây!

---

# PHẦN 1: KHÔNG GIAN QUẢN TRỊ & NHÂN VIÊN (ADMIN / STAFF)

---

## 1. PHÂN HỆ A: TỔNG QUAN ĐIỀU HÀNH

### Màn hình: `DashboardOverviewView` (Tổng quan trung tâm)
* **Ai dùng & Khi nào:** Giám đốc trung tâm, Quản lý điều hành khi vừa mở ứng dụng lên để nắm bắt tình hình toàn viện trong ngày.
* **Mục tiêu:** Cung cấp bức tranh toàn cảnh 360° trong vòng 5 giây: Tình hình sĩ số, doanh thu, lớp đang chạy và các vấn đề khẩn cấp cần xử lý ngay.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Thanh Header & Bộ lọc thời gian:**
     - Tiêu đề trang: *"Tổng quan trung tâm"*
     - Subtitle: Ngày hiện tại, Tên tài khoản quản trị đang đăng nhập, Trạng thái CSDL SQLite cục bộ.
     - Bộ lọc `Tháng` (Tháng 10/2026, Tháng 09/2026...) & Bộ lọc `Khóa học`.
     - Nút hành động: `[Xuất báo cáo tổng quan]`.
  2. **Hàng 6 Thẻ Chỉ số KPI then chốt (Clickable):**
     - *Tổng học viên:* Số lượng toàn bộ hồ sơ (VD: 428).
     - *Đang học:* Số học viên đang có lớp hoạt động (VD: 348).
     - *Lớp hoạt động:* Số lớp đang trong thời gian mở (VD: 18).
     - *Giáo viên:* Số giáo viên đang giảng dạy (VD: 24).
     - *Doanh thu tháng:* Tổng tiền mặt/chuyển khoản đã thu trong tháng (VD: 186,5 tr).
     - *Học phí còn nợ:* Tổng công nợ chưa thu (VD: 42,9 tr).
  3. **Khu vực Đồ thị Phân tích (Visual Charts):**
     - *Biểu đồ Doanh thu theo tháng:* Cột biểu diễn doanh thu 6 tháng gần nhất (T5 -> T10).
     - *Biểu đồ Học viên đang học:* Cột biểu diễn tăng trưởng sĩ số 4 tháng gần nhất.
     - *Thống kê Chuyên cần:* Tỷ lệ có mặt toàn trung tâm (VD: `92,4%`) kèm bảng phân bổ sĩ số theo nhóm khóa học (IELTS, TOEIC, Giao tiếp).
  4. **Khu vực Cảnh báo & Việc cần xử lý gấp (Action Center):**
     - *Cảnh báo Học vụ:* Danh sách học viên vắng $\ge 3$ buổi (Tên, Lớp, Số buổi vắng, SĐT phụ huynh) $\rightarrow$ Nút *"Liên hệ phụ huynh"*.
     - *Cảnh báo Tài chính:* Danh sách học viên nợ học phí quá hạn / đến hạn (Tên, Lớp, Số tiền nợ, Hạn nộp) $\rightarrow$ Nút *"Thu tiền ngay"*.
* **Luồng tương tác & Kết quả trả về:**
  - Bấm vào bất kỳ thẻ KPI nào $\rightarrow$ Chuyển thẳng tới phân hệ tương ứng (Học viên, Lớp học, Giáo viên, Thu học phí).
  - Đổi tháng trên bộ lọc $\rightarrow$ Cập nhật tức thì số liệu KPI doanh thu và highlight trên biểu đồ.
  - Bấm nút *"Thu tiền ngay"* trên cảnh báo tài chính $\rightarrow$ Bật popup `CollectTuitionDialog` điền sẵn tên học viên và số nợ để kế toán lập phiếu thu.
  - Bấm nút *"Xuất báo cáo"* $\rightarrow$ Mở `SaveFileDialog` lưu file Excel/PDF ra máy trạm.

---

## 2. PHÂN HỆ B: ĐÀO TẠO & HỌC VỤ

### 2.1. Màn hình: `StudentManagementView` (Quản lý Học viên)
* **Ai dùng & Khi nào:** Nhân viên Tư vấn, Giáo vụ Đào tạo khi cần tra cứu hồ sơ, thêm học viên mới, xem lịch sử đóng tiền hoặc chuyển trạng thái học viên.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Thanh công cụ tìm kiếm & Lọc:**
     - Ô tìm kiếm: Nhập Mã học viên (`HV-0204`), Họ tên, SĐT học viên hoặc phụ huynh.
     - Bộ lọc `Lớp học` (Tất cả, IELTS-F01, TOEIC-T01...) & `Trạng thái` (Tất cả, Đang học, Bảo lưu, Hoàn thành, Đã thôi học).
     - Nút `[+ Thêm học viên]`.
  2. **Bảng danh sách Học viên:**
     - Các cột: Mã học viên, Họ và tên, Ngày sinh, SĐT, Lớp đang học, Tỷ lệ chuyên cần (%), Số dư công nợ, Trạng thái (Badge màu).
     - Nút thao tác trên từng dòng: *"Xem hồ sơ"*, *"Sửa"*, *"Lưu trữ"*.
  3. **Khối Thống kê nhanh hoặc Form Thêm/Chi tiết:**
     - Có thể thiết kế dạng chia 2 bên (Bên trái: Lưới danh sách; Bên phải: Thẻ tóm tắt thông tin học viên đang chọn + nút nộp học phí nhanh).
* **Các Dialog đi kèm:**
  - `AddStudentDialog`: Form nhập Họ tên, Ngày sinh, Giới tính, SĐT, Email, Tên phụ huynh, SĐT phụ huynh, Địa chỉ, Ghi chú ban đầu.
  - `StudentDetailDialog`: Mở hồ sơ toàn diện 360° của học viên: Xem lịch sử lớp đã học, bảng điểm các kỳ thi, lịch sử phiếu thu học phí (`PT-xxxx`), nút in hồ sơ hoặc chuyển lớp.
  - `ArchiveStudentDialog`: Xác nhận chuyển hồ sơ vào kho lưu trữ khi học viên tốt nghiệp hoặc nghỉ học.

---

### 2.2. Màn hình: `CourseManagementView` (Quản lý Khóa học)
* **Ai dùng & Khi nào:** Quản lý đào tạo khi xây dựng chương trình giảng dạy, thiết lập học phí gốc niêm yết và chuẩn đầu ra.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bảng danh sách Khóa học chuẩn:**
     - Các cột: Mã khóa (`KH-IELTS-F`), Tên khóa (`IELTS Foundation`), Trình độ đầu vào, Tổng số buổi (`24 buổi`), Số giờ đào tạo (`48h`), Học phí niêm yết (`5.400.000đ`), Điểm chuẩn đầu ra (`6.5`), Trạng thái (`Đang mở`).
  2. **Form Thêm / Chỉnh sửa Khóa học:**
     - Mã khóa, Tên khóa, Mô tả chương trình học, Giáo trình sử dụng, Học phí gốc, Số buổi học, Điểm sàn đạt chứng chỉ.
* **Quy tắc nghiệp vụ:**
  - Khóa học là "khuôn mẫu gốc" để nhân bản ra các lớp học cụ thể (`Class`). Khi lớp học được tạo từ khóa nào sẽ tự động thừa hưởng số buổi học và học phí gốc của khóa đó.
* **Các Dialog đi kèm:**
  - `CourseEditDialog`: Thêm mới hoặc cập nhật thông tin khóa học.
  - `CourseDetailDialog`: Xem chi tiết cấu trúc các bài học và danh sách các lớp đang chạy thuộc khóa này.

---

### 2.3. Màn hình: `ClassManagementView` (Quản lý Lớp học)
* **Ai dùng & Khi nào:** Giáo vụ Đào tạo dùng hàng ngày để mở lớp mới, phân công giáo viên chủ nhiệm, xếp phòng học và theo dõi sĩ số.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bộ lọc & Tìm kiếm:** Lọc theo Khóa học gốc, Lọc theo Trạng thái (`Sắp mở`, `Đang học`, `Đã kết thúc`), Lọc theo Giáo viên.
  2. **Bảng danh sách Lớp học:**
     - Mã lớp (`IELTS-F01`), Tên lớp, Khóa học gốc, Giáo viên phụ trách, Phòng học mặc định (`P201`), Ngày khai giảng – Ngày kết thúc, Sĩ số hiện tại / Sĩ số tối đa (`18 / 20`), Tiến độ buổi học (`8 / 24 buổi`), Trạng thái.
  3. **Nút hành động:** `[+ Mở lớp mới]`, `[Xem danh sách học viên trong lớp]`, `[Chuyển lớp cho học viên]`.
* **Quy tắc nghiệp vụ:**
  - Không cho phép xếp sĩ số vượt quá `MaxStudents` (thường là 18–20 học viên).
  - Không thể xóa lớp học nếu lớp đã phát sinh dữ liệu điểm danh hoặc bài thi.
* **Các Dialog đi kèm:**
  - `CreateClassDialog`: Form tạo lớp học mới (chọn khóa, giáo viên, phòng, lịch học thứ mấy trong tuần).
  - `ClassDetailDialog`: Xem toàn bộ danh sách học viên trong lớp, bảng điểm trung bình của cả lớp, tiến độ từng buổi học.
  - `ClassTransferCompleteDialog`: Hộp thoại hoàn tất thủ tục chuyển một học viên từ lớp này sang lớp khác.

---

### 2.4. Màn hình: `ScheduleManagementView` (Thời khóa biểu & Phòng học)
* **Ai dùng & Khi nào:** Giáo vụ xếp lịch hàng tuần, Lễ tân và Giáo viên tra cứu ca học và phòng học trống.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Ma trận Thời khóa biểu (Grid / Calendar View):**
     - Các cột: Thứ Hai, Thứ Ba, Thứ Tư, Thứ Năm, Thứ Sáu, Thứ Bảy, Chủ Nhật.
     - Các hàng: Ca học (Ca 1: 08:00–10:00, Ca 2: 14:00–16:00, Ca 3: 18:00–20:00).
     - Trong từng ô: Hiển thị Thẻ ca học gồm: Tên lớp (`IELTS-F01`), Tên giáo viên (`Thầy Anh`), Phòng học (`P201`).
  2. **Thanh công cụ:** Chọn tuần xem lịch, Lọc theo Phòng học, Lọc theo Giáo viên, Nút `[+ Xếp lịch học]`, Nút `[Quản lý phòng học]`.
* **Quy tắc nghiệp vụ then chốt (CHỐNG XUNG ĐỘT):**
  - **Trùng phòng:** Một phòng học không thể có 2 lớp học cùng một ca trong một ngày $\rightarrow$ Báo đỏ lập tức.
  - **Trùng giáo viên:** Một giáo viên không thể đứng lớp ở 2 phòng khác nhau cùng một khung giờ $\rightarrow$ Báo lỗi xung đột.
* **Các Dialog đi kèm:**
  - `CreateScheduleDialog`: Form chọn lớp, chọn phòng, chọn ca và ngày học.
  - `RoomManagementDialog`: Quản lý danh mục phòng học (Tên phòng, Sức chứa chỗ ngồi, Thiết bị máy chiếu/loa, Trạng thái Khả dụng/Đang bảo trì).
  - `ScheduleSavedDialog`: Thông báo lưu lịch học thành công vào CSDL SQLite.

---

### 2.5. Màn hình: `StudyMaterialView` (Tài liệu học tập cục bộ)
* **Ai dùng & Khi nào:** Giáo vụ và Giáo viên quản lý các tệp giáo trình PDF, file audio luyện nghe MP3, slide bài giảng trên máy trạm.
* **Đặc thù Ngoại tuyến (Offline Local Path):**
  - Không upload lên mây; chỉ lưu **đường dẫn tệp tuyệt đối** trên ổ đĩa máy tính (VD: `C:\ECMS\TaiLieu\IELTS\Workbook_v1.pdf`).
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bảng danh sách tệp cục bộ:**
     - Tên tài liệu, Phiên bản (`1.0`, `1.2`), Khóa học được gán, Dung lượng tệp (`12,8 MB`), Trạng thái (`✓ Tệp khả dụng` hoặc `✕ Không tìm thấy tệp`), Thao tác (*Mở tệp*, *Chọn lại tệp*).
  2. **Form Thêm / Sửa tài liệu:**
     - Tên tài liệu, Phiên bản, Chọn khóa học gán, Loại tệp (PDF, MP3, DOCX), Ô đường dẫn + Nút `[Chọn tệp từ máy trạm...]` (`OpenFileDialog`) + Nút `[Kiểm tra đường dẫn]`.
  3. **Thẻ Tài liệu theo lớp:** Hiển thị các tài liệu đang được gán cho lớp học cụ thể để giáo viên mở giảng dạy.
* **Quy tắc nghiệp vụ:**
  - Hệ thống tự kiểm tra `File.Exists(LocalPath)`: Nếu người dùng lỡ di chuyển file sang thư mục khác, hệ thống hiện cảnh báo viền đỏ và nút *"Chọn lại tệp bị thiếu"* để cập nhật lại đường dẫn mới.

---

### 2.6. Màn hình: `CertificateManagementView` (Xét duyệt & Cấp Chứng chỉ)
* **Ai dùng & Khi nào:** Quản lý đào tạo và Giám đốc sử dụng khi lớp học kết thúc để xét duyệt học viên nào đủ tiêu chuẩn tốt nghiệp và in chứng chỉ.
* **Quy tắc BẮT BUỘC "XÉT DUYỆT 3 CHIỀU":**
  Một học viên CHỈ ĐẠT và sáng nút **[Cấp chứng chỉ]** khi thỏa mãn đồng thời:
  1. **Điểm số:** Điểm tổng kết cuối khóa $\ge 6,5$ / 10.
  2. **Chuyên cần:** Tỷ lệ tham dự lớp $\ge 80\%$ tổng số buổi học.
  3. **Tài chính:** Công nợ $= 0đ$ (Đã hoàn tất 100% học phí).
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bộ lọc:** Chọn lớp học đã kết thúc (`cboClassFilter`), Lọc trạng thái (`Tất cả`, `Đủ điều kiện`, `Không đạt`).
  2. **Bảng danh sách xét duyệt:**
     - Họ tên học viên, Điểm trung bình, Tỷ lệ chuyên cần, Công nợ, Kết luận (`✓ Đạt` hoặc `✕ Chưa đạt`), Lý do không đạt (do Điểm $<6.5$, do Vắng $>20\%$ hay do Còn nợ tiền), Số chứng chỉ (nếu đã cấp).
  3. **Nút thao tác:** `[Xét duyệt cấp chứng chỉ]`, `[Xem trước & In phôi chứng chỉ]`, `[Sổ cấp chứng chỉ]`.
* **Các Dialog đi kèm:**
  - `ApproveCertificateDialog`: Hộp thoại phê duyệt chính thức, chọn người ký (Giám đốc) và ngày cấp.
  - `CertificatePrintPreviewDialog`: Xem trước mẫu in chứng chỉ chuẩn phôi ngang của trung tâm trước khi gửi lệnh ra máy in.
  - `CertificateRegistryDialog`: Sổ tra cứu số hiệu chứng chỉ (`CC-2026-xxxx`) đã lưu trữ trong SQLite.

---

## 3. PHÂN HỆ C: TUYỂN SINH & TÀI CHÍNH

### 3.1. Màn hình: `AdmissionsView` (Tuyển sinh & Khách tiềm năng)
* **Ai dùng & Khi nào:** Nhân viên Tư vấn tuyển sinh quản lý danh sách người quan tâm khóa học từ lúc tiếp cận đến khi nhập học chính thức.
* **Phễu chuyển đổi 4 giai đoạn:**
  $$\text{Mới tiếp nhận} \longrightarrow \text{Đang tư vấn} \longrightarrow \text{Hẹn test đầu vào} \longrightarrow \text{Đã nhập học (Ghi danh)}$$
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Thanh công cụ & Phễu trạng thái:**
     - Bộ lọc Nguồn khách (`Facebook`, `Trực tiếp`, `Giới thiệu`), Bộ lọc Trạng thái phễu.
     - Nút `[+ Tiếp nhận khách mới]`.
  2. **Bảng danh sách Lead (Khách tiềm năng):**
     - Mã lead (`LEAD-xxxx`), Họ và tên, SĐT, Nhu cầu học (IELTS/Giao tiếp), Ngày hẹn liên hệ tiếp, Điểm test đầu vào, Trạng thái, Nhân viên phụ trách.
     - Thao tác trên từng dòng: *"Ghi nhật ký tư vấn"*, *"Nhập học vào lớp"*.
* **Các Dialog đi kèm:**
  - `AddLeadDialog`: Nhập thông tin khách mới tiếp nhận.
  - `ConsultationDialog`: Nhật ký cuộc gọi tư vấn (ngày giờ gọi, ghi chú nội dung phụ huynh trao đổi, lịch hẹn thi test đầu vào).
  - `EnrollmentDialog`: Hộp thoại chính thức chuyển đổi Lead thành Học viên (`HV-xxxx`), chọn lớp học tham gia và tự động phát sinh hóa đơn học phí.
  - `EnrollmentSuccessDialog`: Thông báo ghi danh thành công, chuyển tiếp sang lập phiếu thu học phí.

---

### 3.2. Màn hình: `TuitionPaymentView` (Học phí & Quản lý Thu tiền)
* **Ai dùng & Khi nào:** Kế toán trung tâm dùng để theo dõi học viên nào còn nợ, lập phiếu thu khi học viên đóng tiền và in biên lai giao phụ huynh.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Hàng 4 Thẻ KPI Tài chính:**
     - Tổng công nợ toàn trung tâm (VD: `44,4 tr`).
     - Số học viên còn nợ (VD: `27 học viên`).
     - Các khoản nợ đến hạn trong 7 ngày tới (VD: `12 khoản`).
     - Tổng thực thu trong tháng (VD: `185 tr`).
  2. **Các Tab chuyển đổi:**
     - Tab 1: `• Danh sách công nợ` (Học viên đang nợ tiền).
     - Tab 2: `Lịch sử thu tiền` (Các giao dịch đã thu trong ngày/tháng).
     - Tab 3: `Hạn thanh toán` (Các khoản quá hạn hoặc sắp đến hạn).
  3. **Bảng danh sách công nợ học phí:**
     - Họ tên học viên, Lớp học, Học phí niêm yết, Đã nộp, Còn nợ, Hạn đóng tiền, Nút bấm *"Thu tiền"*.
  4. **Bảng Lịch sử thu tiền của học viên được chọn:**
     - Ngày thu, Mã giao dịch, Số phiếu thu (`PT-261002-006`), Số tiền đóng, Hình thức (Tiền mặt / Chuyển khoản), Kế toán lập phiếu.
* **Các Dialog đi kèm:**
  - `CollectTuitionDialog`: Form nhập số tiền nộp đợt này (có nút *"Nộp hết số dư nợ"*), chọn phương thức (Tiền mặt / CK).
  - `PaymentConfirmDialog`: Xác nhận lại số tiền và người nộp trước khi trừ nợ trong CSDL.
  - `PaymentSuccessDialog`: Thông báo thu tiền thành công + hỏi có muốn in phiếu thu ngay không.
  - `ReceiptPrintPreviewDialog`: Xem trước mẫu in phiếu thu tiền mặt khổ A5/A4 chuẩn kế toán trước khi in ra máy in cục bộ.

---

## 4. PHÂN HỆ D: NHÂN SỰ & HỆ THỐNG

### 4.1. Màn hình: `StaffManagementView` (Quản lý Nhân viên)
* **Ai dùng & Khi nào:** Ban Giám đốc và Trưởng phòng Nhân sự quản lý thông tin nhân viên hành chính (Tư vấn, Kế toán, Đào tạo, IT).
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bảng danh sách Nhân viên:** Mã NV (`NV-002`), Họ và tên, Bộ phận (`Tư vấn tuyển sinh`), SĐT, Email, Ngày vào làm, Trạng thái làm việc.
  2. **Form Thêm / Sửa nhân viên (hoặc Thẻ chi tiết):**
     - Nhập thông tin nhân thân, chọn Bộ phận, Trạng thái (Đang làm việc / Đã nghỉ việc).
     - Nút *"Mở tài khoản liên kết"* để cấu hình quyền đăng nhập phần mềm cho nhân viên đó.

---

### 4.2. Màn hình: `InternalNotificationView` (Thông báo nội bộ máy trạm)
* **Ai dùng & Khi nào:** Nhân viên ca trực, Giáo vụ gửi bảng tin thông báo cho nhau hoặc gửi lời nhắc hạn học phí, lịch họp cho toàn trung tâm.
* **Đặc thù Ngoại tuyến:** Không gửi SMS/Email ra ngoài internet; thông báo xuất hiện ngay trên thanh tiêu đề ứng dụng ECMS khi người dùng đăng nhập vào ca trực.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bảng danh sách thông báo:** Ngày tạo, Tiêu đề, Người nhận theo vai trò, Trạng thái (`Bản nháp`, `Đã phát hành`).
  2. **Thẻ Xem trước thông báo:** Tiêu đề to, Người gửi, Ngày giờ phát hành, Nội dung chi tiết, Số người đã đọc trên máy.
  3. **Form Soạn / Sửa thông báo:**
     - Tiêu đề thông báo.
     - Checkbox chọn đối tượng nhận: `[ ] Học viên`, `[ ] Phụ huynh`, `[ ] Giáo viên`, `[ ] Tư vấn`, `[ ] Kế toán`, `[ ] Đào tạo`.
     - Phạm vi lớp áp dụng (Tất cả hoặc lớp cụ thể).
     - Nội dung văn bản thông báo.
     - Nút `[Lưu nháp]` và nút `[Phát hành nội bộ]`.

---

### 4.3. Màn hình: `ReportManagementView` (Báo cáo & Thống kê quản trị)
* **Ai dùng & Khi nào:** Giám đốc trung tâm và Trưởng phòng tổng hợp số liệu doanh thu, tỷ lệ chuyên cần, phổ điểm kỳ thi theo khoảng ngày (Từ ngày – Đến ngày).
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bộ lọc thời gian & Khóa:** `Từ ngày` – `Đến ngày`, `Khóa học`, `Lớp học` + Nút `[Áp dụng]`.
  2. **Hàng 6 Thẻ Chỉ số báo cáo:** Học viên active, Tỷ lệ chuyên cần (%), Điểm TB cuối khóa, Tỷ lệ tốt nghiệp (%), Tổng thực thu, Tổng nợ tồn đọng.
  3. **Các Tab Báo cáo chuyên sâu:**
     - Tab Báo cáo Tài chính: Biểu đồ doanh thu 4 tuần trong tháng, danh sách các khoản thu lớn.
     - Tab Báo cáo Đào tạo: Phổ điểm các lớp, tỷ lệ chuyên cần theo từng giáo viên.
  4. **Nút `[Xem trước & Xuất báo cáo]`:** Mở `ReportPreviewExportDialog` để xuất file Excel/PDF lưu trữ cục bộ.

---

### 4.4. Màn hình: `AccountManagementView` (Tài khoản & Phân quyền)
* **Ai dùng & Khi nào:** Quản trị viên hệ thống (Admin) tạo tài khoản, đổi mật khẩu và phân quyền chức năng cho các vị trí.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Tab 1: Danh sách tài khoản người dùng:**
     - Tên đăng nhập, Họ và tên chủ tài khoản, Vai trò (Admin, Quản lý, Kế toán, Tư vấn, Giáo viên, Học viên), Trạng thái (Hoạt động / Bị khóa), Ngày tạo.
  2. **Tab 2: Phân quyền & Giới hạn vai trò (Role Permissions):**
     - Bảng ma trận checkbox phân quyền: Ai được xem Báo cáo tài chính, Ai được sửa điểm, Ai được cấu hình hệ thống.
     - *Nguyên tắc an toàn:* Giáo viên KHÔNG ĐƯỢC xem học phí; Kế toán KHÔNG ĐƯỢC sửa điểm học viên.

---

### 4.5. Màn hình: `SystemConfigView` (Cấu hình hệ thống & Sao lưu SQLite)
* **Ai dùng & Khi nào:** Admin cấu hình thông tin thương hiệu trung tâm, cài đặt công thức chấm điểm và thực hiện sao lưu/khôi phục CSDL SQLite an toàn.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Tab Thông tin trung tâm & CSDL:**
     - Tên trung tâm (in trên phiếu thu & chứng chỉ): `Trung tâm Anh ngữ Minh Trí`.
     - Số điện thoại, Địa chỉ, Tên Giám đốc / Người ký chứng chỉ.
     - Đường dẫn tệp SQLite cục bộ (Chỉ đọc): `C:\ECMS\Data\ecms.db`.
     - Đường dẫn thư mục sao lưu: `D:\ECMS_Backup\`.
  2. **Tab Quy tắc điểm & Chuyên cần (BẮT BUỘC TỔNG = 100%):**
     - Thang điểm chuẩn: `0 - 10`.
     - Điểm sàn đạt tốt nghiệp: Mặc định `6,5`.
     - Tỷ trọng Thường xuyên (`20%`) + Giữa khóa (`30%`) + Cuối khóa (`50%`) = Đúng `100%`.
     - Chuyên cần tối thiểu để cấp chứng chỉ: Mặc định `80%`.
     - Ngưỡng cảnh báo học vụ: Vắng trên `3 buổi` (từ 4 buổi trở lên).
  3. **Tab Sao lưu & Khôi phục CSDL (Backup / Restore):**
     - Danh sách các bản sao lưu đã tạo trên máy (`.db`).
     - Nút `[Tạo bản sao lưu ngay]` $\rightarrow$ Mở `CreateBackupDialog` (Tự động đặt tên `ecms_YYYYMMDD_HHmm.db`).
     - Nút `[Khôi phục CSDL]` $\rightarrow$ Mở `RestoreDatabaseDialog` (Yêu cầu xác nhận mật khẩu Admin trước khi ghi đè CSDL).

---

# PHẦN 2: KHÔNG GIAN DÀNH CHO GIÁO VIÊN (TEACHER WORKSPACE)

*Đặc thù Không gian Giáo viên: Giao diện cực kỳ tập trung, không có bất kỳ nút hay thông tin nào liên quan đến học phí hay cấu hình trung tâm.*

---

## 5. Màn hình: `TeacherAttendanceCheckView` (Điểm danh buổi học)
* **Ai dùng & Khi nào:** Giáo viên đứng lớp mở vào đầu mỗi buổi học để điểm danh học sinh có mặt trong phòng.
* **Quy trình tác nghiệp 4 bước (Stepper):**
  $$\text{1. Chọn lớp} \longrightarrow \text{2. Chọn buổi học} \longrightarrow \text{3. Đánh dấu trạng thái} \longrightarrow \text{4. Lưu & Tổng hợp}$$
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Thanh chọn lớp & ca học:** Chọn lớp học (`IELTS-F01`), Chọn buổi (`Buổi 08 · 30/10/2026`).
  2. **Nút hỗ trợ nhanh:** `[Đánh dấu tất cả Có mặt]` (Bấm 1 click là cả lớp chuyển sang "Có mặt").
  3. **Hàng 5 Thẻ tóm tắt sĩ số buổi học:**
     - Tổng học viên (18) · Có mặt (15) · Đi muộn (1) · Vắng có/không phép (2) · Tỷ lệ dự kiến (88,9%).
  4. **Bảng lưới điểm danh từng học viên:**
     - Tên học viên.
     - 4 Nút Radio chọn độc quyền: `( ) Có mặt` | `( ) Vắng có phép` | `( ) Vắng không phép` | `( ) Đi muộn`.
     - Ô nhập ghi chú nhanh (VD: *"Phụ huynh báo ốm"*, *"Đến lúc 18:10"*).
  5. **Nút hành động:** `[Hủy thay đổi]`, `[Lưu điểm danh]` (Lưu xong chuyển tiếp sang màn hình Tổng hợp chuyên cần).

---

## 6. Màn hình: `TeacherAttendanceSummaryView` (Tổng hợp chuyên cần)
* **Ai dùng & Khi nào:** Giáo viên và Giáo vụ xem bức tranh chuyên cần của học viên trong suốt cả khóa học.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bảng tổng hợp chuyên cần cả khóa:**
     - Tên học viên, Số buổi Có mặt, Đi muộn, Vắng có phép, Vắng không phép, Tỷ lệ chuyên cần cá nhân (%).
     - Dòng công thức ghi rõ: $\text{Tỷ lệ} = \frac{\text{Có mặt} + \text{Đi muộn}}{\text{Tổng số buổi đã học}} \times 100\%$.
  2. **Thẻ Theo dõi đặc biệt (Cảnh báo vắng $> 3$ buổi):**
     - Khi một học viên vắng từ 4 buổi trở lên (VD: Lê Hoàng Nam vắng 4/8 buổi $\rightarrow$ Tỷ lệ chỉ còn 50%):
     - Hiển thị ngay khung cảnh báo màu cam: Hiện tên phụ huynh, SĐT phụ huynh, lý do vắng.
     - Nút bấm: `[Ghi nhận yêu cầu theo dõi]` để gửi thông tin cho phòng Đào tạo can thiệp hỗ trợ học bù.
  3. **Nút xuất báo cáo:** `[Xuất tổng hợp ra tệp cục bộ]`.

---

## 7. Màn hình: `TeacherGradeManagementView` (Quản lý Bài kiểm tra & Điểm số)
* **Ai dùng & Khi nào:** Giáo viên tạo danh mục các bài kiểm tra trong khóa học (Đầu vào, Thường xuyên, Giữa khóa, Cuối khóa).
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Bảng danh sách bài kiểm tra:**
     - Tên bài kiểm tra, Loại bài (`Đầu vào`, `Thường xuyên`, `Giữa khóa`, `Cuối khóa`), Ngày thi, Trọng số (`20%`, `30%`, `50%`), Trạng thái (`Đã có điểm`, `Chờ nhập điểm`).
  2. **Form Thêm / Sửa bài kiểm tra:**
     - Chọn lớp học, Tên bài thi, Loại bài, Ngày thi, Thang điểm (10), Trọng số tính điểm (%).
     - Dòng kiểm tra: `✓ Tổng trọng số = 100%`.
  3. **Nút hành động:** `[+ Tạo bài kiểm tra]`, `[Nhập điểm cho bài thi này]`.

---

## 8. Màn hình: `TeacherGradeEntryView` (Lưới nhập điểm & Chặn lỗi)
* **Ai dùng & Khi nào:** Giáo viên mở ra để nhập điểm bài thi cho từng học sinh trong lớp.
* **Cơ chế Chặn lỗi an toàn (Data Guard):**
  - Thang điểm chuẩn: $0.0 \le \text{Điểm} \le 10.0$.
  - Nếu giáo viên gõ nhầm điểm vượt quá 10 (VD: gõ `11`): Hệ thống **viền đỏ ô nhập**, hiện thông báo *"Điểm 11 vượt thang 0-10. Nhập lại để tiếp tục"* và **KHÓA CHẶT NÚT LƯU ĐIỂM**.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Thanh trạng thái nhập điểm:** Đã nhập (20/20), Điểm hợp lệ (19), Cần sửa (1), Tổng trọng số (100%).
  2. **Lưới nhập điểm học viên:**
     - Mã học viên, Họ và tên, Điểm Thường xuyên (20%), Điểm Giữa khóa (30%), Điểm Cuối khóa (50%), Điểm Trung bình tự động tính, Kết quả (`✓ Đạt` hoặc `✕ Không đạt`).
  3. **Khối chỉnh sửa điểm nhanh ở dưới chân bảng:**
     - Điểm đang nhập cho học viên đang chọn + Ô nhập nhận xét của giáo viên (VD: *"Hoàn thành tốt phần đọc và viết"*).
  4. **Nút hành động:** `[Hủy thay đổi]`, `[Lưu điểm vào CSDL]`.

---

# PHẦN 3: KHÔNG GIAN DÀNH CHO HỌC VIÊN (STUDENT PORTAL)

---

## 9. Màn hình: `StudentGradeReportView` (Sổ điểm & Tra cứu kết quả học tập)
* **Ai dùng & Khi nào:** Học viên (hoặc Phụ huynh) đăng nhập vào máy tính của trung tâm để tự tra cứu kết quả của chính mình.
* **Đặc thù:** Chế độ **Chỉ đọc (Read-only)**, tuyệt đối không có nút sửa điểm hay can thiệp dữ liệu.
* **Các thành phần BẮT BUỘC cần thể hiện:**
  1. **Hàng 4 Thẻ điểm số cá nhân:**
     - *Thường xuyên (20%):* VD `7,0`.
     - *Giữa khóa (30%):* VD `7,5`.
     - *Cuối khóa (50%):* VD `8,0`.
     - *Trung bình cuối khóa:* VD `7,7` (Xếp loại Khá · Đạt khóa học).
  2. **Bảng chi tiết các bài kiểm tra:**
     - Tên bài đánh giá (Đầu vào, TX, GK, CK), Ngày làm bài, Điểm số / 10, Trọng số tính điểm.
  3. **Biểu đồ Cột Mini Tiến bộ học tập (`MiniBarChart`):**
     - Thể hiện sự tiến bộ qua thời gian: Đầu vào (`4.5`) $\rightarrow$ Thường xuyên (`7.0`) $\rightarrow$ Giữa khóa (`7.5`) $\rightarrow$ Cuối khóa (`8.0` - Highlight xanh).
  4. **Khối Đánh giá 3 chiều đạt chuẩn tốt nghiệp:**
     - Chuyên cần: `22 / 24 buổi · 91,7%` (Đạt điều kiện $\ge 80\%$).
     - Học phí: `Đã hoàn tất học phí · Còn nợ 0đ` (Đạt điều kiện tài chính).
     - Chứng chỉ: `Đạt điều kiện → Chờ Ban Giám đốc duyệt cấp`.
  5. **Nhận xét của giáo viên chủ nhiệm:** *"Tiến bộ ổn định; cần duy trì luyện nói theo chủ đề và tăng độ chính xác khi viết."*

---

# TỔNG KẾT & BƯỚC TIẾP THEO

Với sổ tay đặc tả này, bạn đã nắm rõ **100% chức năng, dữ liệu đầu vào/đầu ra và các quy tắc nghiệp vụ** của từng màn hình. Bây giờ, bạn có thể tự do lên ý tưởng bố cục cho bất kỳ màn hình nào. Khi bạn có ý tưởng bố cục hoặc muốn điều chỉnh màn hình nào, hãy nói cho tôi biết, tôi sẽ hỗ trợ hiện thực hóa bằng code WinForms chuẩn xác ngay lập tức!
