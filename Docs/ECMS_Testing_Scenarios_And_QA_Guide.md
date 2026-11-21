# TÀI LIỆU KỊCH BẢN KIỂM THỬ VÀ HƯỚNG DẪN NGHIỆM THU (QA TESTING GUIDE)
## HỆ THỐNG QUẢN LÝ TRUNG TÂM ANH NGỮ (ECMS)
> **Nền tảng:** C# WinForms (.NET 10.0), CSDL SQLite cục bộ (100% Offline)  
> **Phiên bản:** 1.0.0  
> **Mục tiêu:** Cung cấp bộ kịch bản kiểm thử (Test Cases), dữ liệu kiểm thử mẫu và checklist nghiệm thu chức năng phục vụ bảo vệ đồ án và kiểm thử chất lượng phần mềm.

---

## 1. DANH SÁCH TÀI KHOẢN KIỂM THỬ HỆ THỐNG (TEST ACCOUNTS)

Hệ thống được khởi tạo sẵn các tài khoản nhân sự với đầy đủ vai trò nghiệp vụ (mật khẩu mã hóa chuẩn BCrypt):

| STT | Tên đăng nhập | Mật khẩu mặc định | Mã vai trò | Tên vai trò / Vị trí | Quyền hạn & Phạm vi kiểm thử |
| :---: | :--- | :--- | :--- | :--- | :--- |
| 1 | `admin` | `Admin@123` | `ROLE_ADMIN` | Quản trị hệ thống | Toàn quyền 13 phân hệ, cấu hình CSDL, phân quyền RBAC |
| 2 | `manager` | `Manager@123` | `ROLE_MGR` | Quản lý trung tâm | Xem báo cáo tài chính, thống kê tuyển sinh, duyệt mở lớp |
| 3 | `counselor` | `Counselor@123` | `ROLE_EC` | Tư vấn tuyển sinh | Khách hàng tiềm năng, tiếp nhận lead, tư vấn, tạo học viên |
| 4 | `accountant` | `Accountant@123` | `ROLE_ACC` | Kế toán / Thu ngân | Thu học phí, quản lý công nợ, in phiếu thu A5, hóa đơn |
| 5 | `academic` | `Academic@123` | `ROLE_AA` | Giáo vụ đào tạo | Mở lớp, xếp lịch chống trùng, phân công GV, xét chứng chỉ |
| 6 | `teacher` | `Teacher@123` | `ROLE_TEA` | Giáo viên | Điểm danh lớp học, nhập điểm thi, ghi nhận xét tiến độ |
| 7 | `student` | `Student@123` | `ROLE_STU` | Học viên | *Tài khoản bị chặn trên ứng dụng quản trị nội bộ* |
| 8 | `parent` | `Parent@123` | `ROLE_PAR` | Phụ huynh | *Tài khoản bị chặn trên ứng dụng quản trị nội bộ* |

---

## 2. KỊCH BẢN KIỂM THỬ CHI TIẾT (TEST CASES)

### Phân hệ 1: Xác thực & Điều hướng hệ thống (`LoginForm` & `MainForm`)

| Mã TC | Tên ca kiểm thử | Điều kiện tiên quyết | Các bước thực hiện | Kết quả mong đợi | Trạng thái |
| :---: | :--- | :--- | :--- | :--- | :---: |
| **AUTH-01** | Kiểm tra validation form đăng nhập | Ứng dụng ở màn hình đăng nhập | 1. Để trống tên đăng nhập và mật khẩu.<br>2. Bấm nút **Đăng nhập**. | Hiển thị thông báo yêu cầu nhập đầy đủ thông tin, không gửi request xác thực. | Đạt (Pass) |
| **AUTH-02** | Hiện / Ẩn mật khẩu | Đã nhập mật khẩu vào ô Password | 1. Tích vào checkbox **Hiển thị mật khẩu**.<br>2. Bỏ tích checkbox. | Khi tích: hiện rõ ký tự mật khẩu.<br>Khi bỏ tích: ẩn thành ký tự chấm tròn bảo mật. | Đạt (Pass) |
| **AUTH-03** | Đăng nhập sai thông tin | Đã mở LoginForm | 1. Nhập `admin` và mật khẩu sai.<br>2. Bấm **Đăng nhập**. | Báo lỗi thông tin đăng nhập không hợp lệ, giữ lại username. | Đạt (Pass) |
| **AUTH-04** | Chặn vai trò ngoài nội bộ | Tài khoản `student` hoặc `parent` | 1. Nhập `student` / `Student@123`.<br>2. Bấm **Đăng nhập**. | Hệ thống từ chối truy cập do phân hệ nội bộ chỉ dành cho nhân sự trung tâm. | Đạt (Pass) |
| **AUTH-05** | Đăng nhập thành công Admin | Tài khoản `admin` | 1. Nhập `admin` / `Admin@123`.<br>2. Bấm **Đăng nhập**. | Chuyển vào `MainForm`, hiển thị đầy đủ 13 phân hệ trên Sidebar menu. | Đạt (Pass) |
| **AUTH-06** | Trạng thái nút Sidebar (Active State) | Đang ở MainForm | 1. Bấm chọn **Học viên**.<br>2. Bấm chọn **Cấu hình**.<br>3. Bấm chọn **Tổng quan**. | Chỉ duy nhất phân hệ đang xem được tô đậm nổi bật; các nút phân hệ trước đó tự động trở về trạng thái bình thường. | Đạt (Pass) |
| **AUTH-07** | Phân quyền Sidebar theo Role | Tài khoản `teacher` | 1. Đăng xuất tài khoản hiện tại.<br>2. Đăng nhập `teacher` / `Teacher@123`. | Sidebar chỉ hiển thị các phân hệ giáo viên được cấp quyền; các phân hệ quản trị (Tài khoản, Cấu hình) bị ẩn hoàn toàn. | Đạt (Pass) |

---

### Phân hệ 2: Bảng điều khiển tổng quan (`DashboardOverviewView`)

| Mã TC | Tên ca kiểm thử | Các bước thực hiện | Kết quả mong đợi | Trạng thái |
| :---: | :--- | :--- | :--- | :---: |
| **DASH-01** | Truy xuất số liệu thật 6 thẻ KPI | Mở phân hệ **Tổng quan** với tài khoản Admin | 6 thẻ KPI (Tổng học viên, Đang học, Lớp hoạt động, Giáo viên, Doanh thu tháng, Công nợ) hiển thị số liệu tính toán trực tiếp từ CSDL SQLite. | Đạt (Pass) |
| **DASH-02** | Đồng bộ số cột 2 biểu đồ tháng | Quan sát 2 biểu đồ **Doanh thu** và **Tăng trưởng học viên** | Cả 2 biểu đồ đều hiển thị đúng 6 tháng gần nhất với số lượng cột bằng nhau, có nhãn giá trị rõ ràng. | Đạt (Pass) |
| **DASH-03** | Lịch học hôm nay & Sắp khai giảng | Quan sát lưới lịch học ở nửa dưới màn hình | Dữ liệu nạp từ bảng `ClassSchedules` và `Classes`, hiển thị đúng ca học, phòng học, giáo viên và trạng thái lớp. | Đạt (Pass) |
| **DASH-04** | Tìm kiếm nhanh đa đối tượng | 1. Nhập từ khóa (tên học viên, mã lớp hoặc khóa học) vào ô tìm kiếm.<br>2. Nhấn phím Enter hoặc bấm **Tìm kiếm**. | Bật cửa sổ `QuickDetailGridDialog` dạng lưới hiển thị danh sách tất cả các kết quả phù hợp từ SQLite. | Đạt (Pass) |
| **DASH-05** | Xử lý cảnh báo học viên vắng | 1. Bấm nút **Danh sách cần xử lý**.<br>2. Đổi trạng thái xử lý hoặc bấm xóa cảnh báo. | Hiển thị học viên vắng $\ge$ ngưỡng cấu hình; trạng thái xử lý được lưu bền vững vào bảng `AbsenceAlertStates`. | Đạt (Pass) |
| **DASH-06** | Xuất báo cáo tổng quan CSV | 1. Bấm nút **Xuất báo cáo**.<br>2. Chọn vị trí lưu tệp `.csv`. | Xuất file thành công chuẩn mã hóa UTF-8 BOM (tiếng Việt không lỗi font) và tự động mở bằng ứng dụng mặc định. | Đạt (Pass) |

---

### Phân hệ 3: Quản lý học viên & Thu học phí liên kết (`StudentManagementView`)

| Mã TC | Tên ca kiểm thử | Các bước thực hiện | Kết quả mong đợi | Trạng thái |
| :---: | :--- | :--- | :--- | :---: |
| **STU-01** | Thống kê 4 thẻ hồ sơ học viên | Truy cập phân hệ **Học viên** | 4 thẻ (Tổng số hồ sơ, Đang học, Hoàn thành, Đã lưu trữ) khớp chính xác số liệu trong bảng `Students`. | Đạt (Pass) |
| **STU-02** | Tìm kiếm học viên thời gian thực | Gõ ký tự tìm kiếm theo mã, họ tên hoặc số điện thoại | Danh sách lọc tức thời theo ký tự nhập; nếu để trống danh sách hiển thị lại toàn bộ. | Đạt (Pass) |
| **STU-03** | Xem chi tiết hồ sơ 360 độ | Bấm nút **Xem chi tiết** tại 1 dòng học viên | Mở hộp thoại `StudentDetailDialog` với 2 Tab (Tổng quan & Quá trình học tập) lấy 100% dữ liệu thật từ SQLite. | Đạt (Pass) |
| **STU-04** | Lưu trữ và Khôi phục hồ sơ | 1. Trong dialog chi tiết, bấm **Lưu trữ**.<br>2. Ra ngoài bấm **Xem hồ sơ lưu trữ** -> bấm **Khôi phục**. | Học viên chuyển sang trạng thái lưu trữ (`Reserved/Dropped`); nút khôi phục đưa học viên quay lại danh sách hoạt động. | Đạt (Pass) |
| **STU-05** | Quy trình thêm học viên & xếp lớp | 1. Bấm **Thêm học viên**.<br>2. Bước 1: Nhập thông tin cá nhân.<br>3. Bước 2: Chọn Khóa học -> chọn Lớp theo ca học. | Bước 2 lọc lớp theo khóa học và ca học (Sáng/Chiều/Tối); sinh mã học viên tự động chuẩn `HV-yyyy-xxxx`. | Đạt (Pass) |
| **STU-06** | Thu học phí & Xem trước phiếu thu | 1. Bước 3: Nhập số tiền đóng đợt 1 -> Lưu.<br>2. Kiểm tra cửa sổ xem trước in phiếu thu. | Nhãn học viên cố định dạng `Tên · Mã`; số tiền bằng chữ được đọc chuẩn tiếng Việt; phiếu thu hiển thị đúng thông tin trung tâm. | Đạt (Pass) |

---

### Phân hệ 4: Tài khoản & Phân quyền (`AccountManagementView`)

| Mã TC | Tên ca kiểm thử | Các bước thực hiện | Kết quả mong đợi | Trạng thái |
| :---: | :--- | :--- | :--- | :---: |
| **USER-01** | Danh sách tài khoản nội bộ | Mở Tab **Tài khoản người dùng** | Chỉ hiển thị các vai trò nhân sự nội bộ; không có vai trò Học viên và Phụ huynh. | Đạt (Pass) |
| **USER-02** | Thêm mới / Cập nhật tài khoản | Bấm **Thêm tài khoản** hoặc sửa tài khoản có sẵn | Form nhập tinh gọn, không còn mục liên kết hồ sơ dư thừa; mật khẩu mã hóa BCrypt an toàn. | Đạt (Pass) |
| **USER-03** | Ma trận phân quyền Sidebar | 1. Chuyển sang Tab **Vai trò & Phân quyền**.<br>2. Thay đổi quyền truy cập của một vai trò -> bấm **Lưu**. | Tên 13 phân hệ hiển thị rõ ràng bằng tiếng Việt; quyền hạn mới được áp dụng ngay lập tức lên Sidebar MainForm. | Đạt (Pass) |
| **USER-04** | Cập nhật hồ sơ & Đổi mật khẩu | 1. Chuyển sang Tab **Tài khoản cá nhân**.<br>2. Cập nhật họ tên/SĐT -> Lưu.<br>3. Đổi mật khẩu mới -> Thoát app và đăng nhập lại. | Thông tin cá nhân cập nhật vào CSDL; mật khẩu mới có hiệu lực ngay cả sau khi khởi động lại ứng dụng. | Đạt (Pass) |

---

### Phân hệ 5: Cấu hình hệ thống & Quy tắc đào tạo (`SystemConfigView`)

| Mã TC | Tên ca kiểm thử | Các bước thực hiện | Kết quả mong đợi | Trạng thái |
| :---: | :--- | :--- | :--- | :---: |
| **CFG-01** | Kiểm tra trạng thái CSDL SQLite | 1. Mở Tab **Thông tin trung tâm & CSDL**.<br>2. Bấm nút **Kiểm tra** cạnh đường dẫn file DB. | Bật thông báo chi tiết: đường dẫn tệp, dung lượng, trạng thái WAL mode, Foreign Keys và kết quả `PRAGMA integrity_check: ok`. | Đạt (Pass) |
| **CFG-02** | Cập nhật thông tin trung tâm | 1. Chỉnh sửa tên trung tâm, số hotline, địa chỉ.<br>2. Bấm nút **Lưu cấu hình**. | Lưu thành công xuống bảng `SystemConfigs` mà không bị chặn bởi trường người đại diện đã được tinh gọn. | Đạt (Pass) |
| **CFG-03** | Đồng bộ quy tắc xét duyệt chứng chỉ | 1. Tại Tab **Quy tắc điểm & Chuyên cần**, chỉnh điểm đạt chuẩn hoặc tỷ lệ chuyên cần.<br>2. Bấm **Lưu** rồi mở phân hệ **Chứng chỉ**. | Phân hệ Chứng chỉ tự động nhận ngưỡng mới từ CSDL để cập nhật dòng tiêu chuẩn và tự động đánh giá lại điều kiện cấp bằng. | Đạt (Pass) |
| **CFG-04** | Sao lưu & Khôi phục CSDL | 1. Tại Tab **Sao lưu & Khôi phục**, bấm **Tạo bản sao lưu ngay**.<br>2. Kiểm tra danh sách bản sao lưu và thử nút **Phục hồi**. | Tạo tệp snapshot backup trên ổ đĩa; phục hồi dữ liệu an toàn có thông báo xác nhận và tự động reload lại toàn bộ hệ thống. | Đạt (Pass) |

---

## 3. CHECKLIST NGHIỆM THU ĐỒ ÁN (DEFENSE CHECKLIST)

- [x] **Kiến trúc phân tầng:** Tách bạch 4 tầng `Core` $\rightarrow$ `Data` $\rightarrow$ `Business` $\rightarrow$ `UI`.
- [x] **Không sử dụng Mock Data:** 100% dữ liệu hiển thị trên các màn hình Tổng quan, Học viên, Tài khoản và Cấu hình đều truy xuất từ CSDL SQLite.
- [x] **Toàn vẹn dữ liệu (Constraints):** Tuân thủ tuyệt đối các ràng buộc khóa chính, khóa ngoại (`PRAGMA foreign_keys = ON`) và `CHECK constraint` trên các bảng SQLite.
- [x] **Bảo mật mật khẩu:** Sử dụng thuật toán BCrypt Hash với Salt ngẫu nhiên, không lưu bản rõ (Plaintext) trong cơ sở dữ liệu.
- [x] **Tương thích công cụ:** Hỗ trợ mở thiết kế trực quan trên JetBrains Rider Design Mode.
- [x] **Xử lý ngoại lệ thân thiện:** Có hộp thoại thông báo `AppDialog` rõ ràng, không để crash ứng dụng khi xảy ra lỗi ngoài ý muốn.
