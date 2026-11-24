using System;
using Microsoft.Data.Sqlite;
using Dapper;

namespace ECMS.Data.Database;

public static class DatabaseInitializer
{
    public static void Initialize()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();

        // 1. DDL for all 26 tables
        string ddlScript = @"
        -- 1. Users & Roles
        CREATE TABLE IF NOT EXISTS Users (
            UserId INTEGER PRIMARY KEY AUTOINCREMENT,
            Username TEXT NOT NULL UNIQUE,
            PasswordHash TEXT NOT NULL,
            PasswordSalt TEXT NOT NULL,
            EmployeeId INTEGER,
            TeacherId INTEGER,
            StudentId INTEGER,
            ParentId INTEGER,
            IsActive INTEGER NOT NULL DEFAULT 1 CHECK(IsActive IN (0, 1)),
            FailedLoginAttempts INTEGER NOT NULL DEFAULT 0,
            LockoutEnd TEXT,
            MustChangePassword INTEGER NOT NULL DEFAULT 0,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT
        );

        CREATE TABLE IF NOT EXISTS Roles (
            RoleId INTEGER PRIMARY KEY AUTOINCREMENT,
            RoleCode TEXT NOT NULL UNIQUE,
            RoleName TEXT NOT NULL,
            Description TEXT
        );

        CREATE TABLE IF NOT EXISTS UserRoles (
            UserId INTEGER NOT NULL,
            RoleId INTEGER NOT NULL,
            AssignedDate TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            PRIMARY KEY (UserId, RoleId),
            FOREIGN KEY (UserId) REFERENCES Users(UserId) ON DELETE CASCADE,
            FOREIGN KEY (RoleId) REFERENCES Roles(RoleId) ON DELETE CASCADE
        );

        CREATE TABLE IF NOT EXISTS Permissions (
            PermissionId INTEGER PRIMARY KEY AUTOINCREMENT,
            PermissionCode TEXT NOT NULL UNIQUE,
            PermissionName TEXT NOT NULL,
            ModuleName TEXT NOT NULL,
            Description TEXT
        );

        CREATE TABLE IF NOT EXISTS RolePermissions (
            RoleId INTEGER NOT NULL,
            PermissionId INTEGER NOT NULL,
            PRIMARY KEY (RoleId, PermissionId),
            FOREIGN KEY (RoleId) REFERENCES Roles(RoleId) ON DELETE CASCADE,
            FOREIGN KEY (PermissionId) REFERENCES Permissions(PermissionId) ON DELETE CASCADE
        );

        -- 2. Employees & Teachers
        CREATE TABLE IF NOT EXISTS Employees (
            EmployeeId INTEGER PRIMARY KEY AUTOINCREMENT,
            EmployeeCode TEXT NOT NULL UNIQUE,
            FullName TEXT NOT NULL,
            Department TEXT NOT NULL,
            Phone TEXT NOT NULL,
            Email TEXT,
            IsActive INTEGER NOT NULL DEFAULT 1 CHECK(IsActive IN (0, 1)),
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT
        );

        CREATE TABLE IF NOT EXISTS Teachers (
            TeacherId INTEGER PRIMARY KEY AUTOINCREMENT,
            TeacherCode TEXT NOT NULL UNIQUE,
            FullName TEXT NOT NULL,
            Specialization TEXT NOT NULL,
            Phone TEXT NOT NULL,
            Email TEXT,
            HourlyRate REAL NOT NULL DEFAULT 0 CHECK(HourlyRate >= 0),
            IsNativeSpeaker INTEGER NOT NULL DEFAULT 0 CHECK(IsNativeSpeaker IN (0, 1)),
            IsActive INTEGER NOT NULL DEFAULT 1 CHECK(IsActive IN (0, 1)),
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT
        );

        -- 3. Leads & ConsultationLogs
        CREATE TABLE IF NOT EXISTS Leads (
            LeadId INTEGER PRIMARY KEY AUTOINCREMENT,
            FullName TEXT NOT NULL,
            Phone TEXT NOT NULL,
            Email TEXT,
            Source TEXT DEFAULT 'Trực tiếp',
            Status TEXT NOT NULL DEFAULT 'New' CHECK(Status IN ('New', 'Contacted', 'TestScheduled', 'Converted', 'Lost')),
            AssignedEmployeeId INTEGER,
            Notes TEXT,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (AssignedEmployeeId) REFERENCES Employees(EmployeeId)
        );

        CREATE TABLE IF NOT EXISTS ConsultationLogs (
            LogId INTEGER PRIMARY KEY AUTOINCREMENT,
            LeadId INTEGER NOT NULL,
            CounselorId INTEGER NOT NULL,
            ConsultationDate TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            EntranceTestScore REAL,
            ProposedLevel TEXT,
            Content TEXT,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (LeadId) REFERENCES Leads(LeadId) ON DELETE CASCADE,
            FOREIGN KEY (CounselorId) REFERENCES Employees(EmployeeId)
        );

        -- 4. Students & Parents
        CREATE TABLE IF NOT EXISTS Students (
            StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
            StudentCode TEXT NOT NULL UNIQUE,
            FullName TEXT NOT NULL,
            DateOfBirth TEXT NOT NULL,
            Gender TEXT NOT NULL DEFAULT 'Nam' CHECK(Gender IN ('Nam', 'Nữ', 'Khác')),
            Phone TEXT,
            Email TEXT,
            Address TEXT,
            AvatarPath TEXT,
            Status TEXT NOT NULL DEFAULT 'Active' CHECK(Status IN ('Active', 'Reserved', 'Completed', 'Dropped')),
            LeadId INTEGER,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (LeadId) REFERENCES Leads(LeadId)
        );

        CREATE TABLE IF NOT EXISTS Parents (
            ParentId INTEGER PRIMARY KEY AUTOINCREMENT,
            ParentCode TEXT NOT NULL UNIQUE,
            FullName TEXT NOT NULL,
            Phone TEXT NOT NULL,
            Email TEXT,
            Occupation TEXT,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT
        );

        CREATE TABLE IF NOT EXISTS StudentParents (
            StudentId INTEGER NOT NULL,
            ParentId INTEGER NOT NULL,
            RelationshipType TEXT NOT NULL DEFAULT 'Bố' CHECK(RelationshipType IN ('Bố', 'Mẹ', 'Giám hộ', 'Khác')),
            IsPrimaryContact INTEGER NOT NULL DEFAULT 0 CHECK(IsPrimaryContact IN (0, 1)),
            PRIMARY KEY (StudentId, ParentId),
            FOREIGN KEY (StudentId) REFERENCES Students(StudentId) ON DELETE CASCADE,
            FOREIGN KEY (ParentId) REFERENCES Parents(ParentId) ON DELETE CASCADE
        );

        -- 5. Courses, Rooms, Classes
        CREATE TABLE IF NOT EXISTS Courses (
            CourseId INTEGER PRIMARY KEY AUTOINCREMENT,
            CourseCode TEXT NOT NULL UNIQUE,
            CourseName TEXT NOT NULL,
            Level TEXT NOT NULL,
            TotalHours INTEGER NOT NULL DEFAULT 45 CHECK(TotalHours > 0),
            TotalSessions INTEGER NOT NULL DEFAULT 30 CHECK(TotalSessions > 0),
            BaseTuitionFee REAL NOT NULL DEFAULT 0 CHECK(BaseTuitionFee >= 0),
            PassingScore REAL NOT NULL DEFAULT 5.0 CHECK(PassingScore BETWEEN 0 AND 10),
            IsActive INTEGER NOT NULL DEFAULT 1 CHECK(IsActive IN (0, 1)),
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT
        );

        CREATE TABLE IF NOT EXISTS ClassRooms (
            RoomId INTEGER PRIMARY KEY AUTOINCREMENT,
            RoomName TEXT NOT NULL UNIQUE,
            Floor INTEGER NOT NULL DEFAULT 1 CHECK(Floor >= 1),
            Capacity INTEGER NOT NULL DEFAULT 20 CHECK(Capacity > 0),
            HasProjector INTEGER NOT NULL DEFAULT 1 CHECK(HasProjector IN (0, 1)),
            IsActive INTEGER NOT NULL DEFAULT 1 CHECK(IsActive IN (0, 1)),
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT
        );

        CREATE TABLE IF NOT EXISTS Classes (
            ClassId INTEGER PRIMARY KEY AUTOINCREMENT,
            ClassCode TEXT NOT NULL UNIQUE,
            ClassName TEXT NOT NULL,
            CourseId INTEGER NOT NULL,
            MainTeacherId INTEGER,
            DefaultRoomId INTEGER,
            StartDate TEXT NOT NULL,
            EndDate TEXT NOT NULL,
            MaxStudents INTEGER NOT NULL DEFAULT 15 CHECK(MaxStudents > 0),
            Status TEXT NOT NULL DEFAULT 'Planning' CHECK(Status IN ('Planning', 'OpenForEnrollment', 'InProgress', 'Completed', 'Cancelled')),
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (CourseId) REFERENCES Courses(CourseId),
            FOREIGN KEY (MainTeacherId) REFERENCES Teachers(TeacherId),
            FOREIGN KEY (DefaultRoomId) REFERENCES ClassRooms(RoomId)
        );

        CREATE TABLE IF NOT EXISTS ClassSchedules (
            ScheduleId INTEGER PRIMARY KEY AUTOINCREMENT,
            ClassId INTEGER NOT NULL,
            SessionNumber INTEGER NOT NULL CHECK(SessionNumber > 0),
            Date TEXT NOT NULL,
            StartTime TEXT NOT NULL,
            EndTime TEXT NOT NULL,
            RoomId INTEGER NOT NULL,
            TeacherId INTEGER NOT NULL,
            IsAttendanceLocked INTEGER NOT NULL DEFAULT 0 CHECK(IsAttendanceLocked IN (0, 1)),
            Topic TEXT,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (ClassId) REFERENCES Classes(ClassId) ON DELETE CASCADE,
            FOREIGN KEY (RoomId) REFERENCES ClassRooms(RoomId),
            FOREIGN KEY (TeacherId) REFERENCES Teachers(TeacherId)
        );

        -- 6. Enrollments & Attendance
        CREATE TABLE IF NOT EXISTS Enrollments (
            EnrollmentId INTEGER PRIMARY KEY AUTOINCREMENT,
            StudentId INTEGER NOT NULL,
            ClassId INTEGER NOT NULL,
            EnrollDate TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            Status TEXT NOT NULL DEFAULT 'Active' CHECK(Status IN ('PendingPayment', 'Active', 'Transferred', 'Reserved', 'Dropped', 'Completed')),
            FinalGPA REAL CHECK(FinalGPA BETWEEN 0 AND 10),
            AttendanceRate REAL CHECK(AttendanceRate BETWEEN 0 AND 100),
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
            FOREIGN KEY (ClassId) REFERENCES Classes(ClassId)
        );

        CREATE TABLE IF NOT EXISTS AttendanceRecords (
            AttendanceId INTEGER PRIMARY KEY AUTOINCREMENT,
            ScheduleId INTEGER NOT NULL,
            StudentId INTEGER NOT NULL,
            Status TEXT NOT NULL DEFAULT 'Present' CHECK(Status IN ('Present', 'Absent', 'Excused', 'Late')),
            Note TEXT,
            RecordedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            UNIQUE(ScheduleId, StudentId),
            FOREIGN KEY (ScheduleId) REFERENCES ClassSchedules(ScheduleId) ON DELETE CASCADE,
            FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
        );

        -- 7. Exams & Scores
        CREATE TABLE IF NOT EXISTS Exams (
            ExamId INTEGER PRIMARY KEY AUTOINCREMENT,
            ClassId INTEGER NOT NULL,
            ExamName TEXT NOT NULL,
            Type TEXT NOT NULL DEFAULT 'Midterm',
            ExamDate TEXT NOT NULL,
            WeightPercentage REAL NOT NULL DEFAULT 30.0 CHECK(WeightPercentage BETWEEN 0 AND 100),
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (ClassId) REFERENCES Classes(ClassId) ON DELETE CASCADE
        );

        CREATE TABLE IF NOT EXISTS ExamScores (
            ScoreId INTEGER PRIMARY KEY AUTOINCREMENT,
            ExamId INTEGER NOT NULL,
            StudentId INTEGER NOT NULL,
            ScoreValue REAL NOT NULL CHECK(ScoreValue BETWEEN 0 AND 10),
            TeacherComments TEXT,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            UNIQUE(ExamId, StudentId),
            FOREIGN KEY (ExamId) REFERENCES Exams(ExamId) ON DELETE CASCADE,
            FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
        );

        -- 8. Finance (Invoices & Payments)
        CREATE TABLE IF NOT EXISTS Invoices (
            InvoiceId INTEGER PRIMARY KEY AUTOINCREMENT,
            InvoiceCode TEXT NOT NULL UNIQUE,
            EnrollmentId INTEGER NOT NULL UNIQUE,
            OriginalAmount REAL NOT NULL CHECK(OriginalAmount >= 0),
            DiscountAmount REAL NOT NULL DEFAULT 0 CHECK(DiscountAmount >= 0),
            FinalAmount REAL NOT NULL CHECK(FinalAmount >= 0),
            BalanceDue REAL NOT NULL CHECK(BalanceDue >= 0),
            DueDate TEXT NOT NULL,
            Status TEXT NOT NULL DEFAULT 'Unpaid' CHECK(Status IN ('Unpaid', 'PartiallyPaid', 'Paid', 'Cancelled')),
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (EnrollmentId) REFERENCES Enrollments(EnrollmentId) ON DELETE CASCADE
        );

        CREATE TABLE IF NOT EXISTS Payments (
            PaymentId INTEGER PRIMARY KEY AUTOINCREMENT,
            PaymentCode TEXT NOT NULL UNIQUE,
            InvoiceId INTEGER NOT NULL,
            PaidAmount REAL NOT NULL CHECK(PaidAmount > 0),
            PaymentDate TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            PaymentMethod TEXT NOT NULL DEFAULT 'Tiền mặt' CHECK(PaymentMethod IN ('Tiền mặt', 'Chuyển khoản', 'POS')),
            CashierId INTEGER NOT NULL,
            Status TEXT NOT NULL DEFAULT 'Valid' CHECK(Status IN ('Valid', 'Cancelled')),
            Note TEXT,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (InvoiceId) REFERENCES Invoices(InvoiceId),
            FOREIGN KEY (CashierId) REFERENCES Users(UserId)
        );

        CREATE TABLE IF NOT EXISTS FeeDiscounts (
            DiscountId INTEGER PRIMARY KEY AUTOINCREMENT,
            DiscountCode TEXT,
            DiscountName TEXT NOT NULL,
            Percentage REAL NOT NULL DEFAULT 0,
            FixedAmount REAL NOT NULL DEFAULT 0,
            Description TEXT,
            RequiresApproval INTEGER NOT NULL DEFAULT 0,
            IsActive INTEGER NOT NULL DEFAULT 1,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT
        );

        -- 9. Certificates & Study Materials
        CREATE TABLE IF NOT EXISTS Certificates (
            CertificateId INTEGER PRIMARY KEY AUTOINCREMENT,
            CertificateNo TEXT NOT NULL UNIQUE,
            EnrollmentId INTEGER NOT NULL UNIQUE,
            StudentId INTEGER NOT NULL,
            IssueDate TEXT NOT NULL DEFAULT CURRENT_DATE,
            GraduationGrade TEXT NOT NULL DEFAULT 'Khá',
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (EnrollmentId) REFERENCES Enrollments(EnrollmentId),
            FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
        );

        CREATE TABLE IF NOT EXISTS StudyMaterials (
            MaterialId INTEGER PRIMARY KEY AUTOINCREMENT,
            CourseId INTEGER NOT NULL,
            Title TEXT NOT NULL,
            FilePath TEXT,
            Description TEXT,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT,
            FOREIGN KEY (CourseId) REFERENCES Courses(CourseId) ON DELETE CASCADE
        );

        -- 10. AuditLogs, SystemConfigs, Notifications
        CREATE TABLE IF NOT EXISTS AuditLogs (
            LogId INTEGER PRIMARY KEY AUTOINCREMENT,
            UserId INTEGER,
            ActionName TEXT NOT NULL,
            TableName TEXT NOT NULL,
            RecordId TEXT,
            OldValues TEXT,
            NewValues TEXT,
            Timestamp TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            FOREIGN KEY (UserId) REFERENCES Users(UserId)
        );

        CREATE TABLE IF NOT EXISTS SystemConfigs (
            ConfigKey TEXT PRIMARY KEY,
            ConfigValue TEXT,
            Description TEXT,
            UpdatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP
        );

        CREATE TABLE IF NOT EXISTS Notifications (
            NotificationId INTEGER PRIMARY KEY AUTOINCREMENT,
            Title TEXT NOT NULL,
            Content TEXT NOT NULL,
            TargetAudience TEXT NOT NULL DEFAULT 'All',
            PublishDate TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            ExpiryDate TEXT,
            CreatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
            UpdatedAt TEXT
        );
        ";

        using (var cmd = conn.CreateCommand())
        {
            cmd.CommandText = ddlScript;
            cmd.ExecuteNonQuery();
        }

        // Ensure columns StudentId, ParentId, MustChangePassword exist in Users if table existed prior
        try { conn.Execute("ALTER TABLE Users ADD COLUMN StudentId INTEGER;"); } catch { }
        try { conn.Execute("ALTER TABLE Users ADD COLUMN ParentId INTEGER;"); } catch { }
        try { conn.Execute("ALTER TABLE Users ADD COLUMN MustChangePassword INTEGER NOT NULL DEFAULT 0;"); } catch { }
        try { conn.Execute("ALTER TABLE FeeDiscounts ADD COLUMN DiscountCode TEXT;"); } catch { }
        try { conn.Execute("ALTER TABLE Teachers ADD COLUMN Certificate TEXT;"); } catch { }
        try { conn.Execute("ALTER TABLE Teachers ADD COLUMN Notes TEXT;"); } catch { }
        try { conn.Execute("ALTER TABLE Teachers ADD COLUMN PreferredShifts TEXT;"); } catch { }
        try { conn.Execute("ALTER TABLE Teachers ADD COLUMN AvailableDays TEXT;"); } catch { }
        try { conn.Execute("ALTER TABLE Exams ADD COLUMN StartTime TEXT DEFAULT '18:00';"); } catch { }
        try { conn.Execute("ALTER TABLE Exams ADD COLUMN EndTime TEXT DEFAULT '19:30';"); } catch { }
        try { conn.Execute("ALTER TABLE Exams ADD COLUMN RoomId INTEGER;"); } catch { }
        try { conn.Execute("ALTER TABLE ClassRooms ADD COLUMN Equipment TEXT;"); } catch { }
        try { conn.Execute("ALTER TABLE ClassRooms ADD COLUMN RoomStatus TEXT DEFAULT 'Đang sử dụng';"); } catch { }
        try { conn.Execute("ALTER TABLE StudyMaterials ADD COLUMN Version TEXT DEFAULT '1.0';"); } catch { }
        try { conn.Execute("ALTER TABLE StudyMaterials ADD COLUMN FileType TEXT DEFAULT 'PDF';"); } catch { }
        try { conn.Execute("ALTER TABLE StudyMaterials ADD COLUMN FileSize TEXT DEFAULT '';"); } catch { }
        try
        {
            conn.Execute("UPDATE FeeDiscounts SET DiscountCode = 'HVCU10' WHERE DiscountId = 1 AND (DiscountCode IS NULL OR DiscountCode = '');");
            conn.Execute("UPDATE FeeDiscounts SET DiscountCode = 'NHOM15' WHERE DiscountId = 2 AND (DiscountCode IS NULL OR DiscountCode = '');");
            conn.Execute("UPDATE FeeDiscounts SET DiscountCode = 'EARLY500' WHERE DiscountId = 3 AND (DiscountCode IS NULL OR DiscountCode = '');");
        }
        catch { }

        // 2. Seed default data if database is empty or needs updates
        SeedInitialData(conn);
    }

    private static void SeedInitialData(SqliteConnection conn)
    {
        // 1. Seed All 8 Roles
        var roles = new[]
        {
            new { Code = "ROLE_ADMIN", Name = "Admin – Quản trị hệ thống", Desc = "Toàn quyền quản trị kỹ thuật, tài khoản và CSDL" },
            new { Code = "ROLE_MGR", Name = "Quản lý trung tâm", Desc = "Phê duyệt tài chính, mở lớp và theo dõi báo cáo điều hành" },
            new { Code = "ROLE_EC", Name = "Tư vấn tuyển sinh", Desc = "Quản lý khách tiềm năng, tư vấn, test đầu vào và tạo học viên" },
            new { Code = "ROLE_ACC", Name = "Kế toán / Thu ngân", Desc = "Thu học phí, in biên lai A5, theo dõi công nợ" },
            new { Code = "ROLE_AA", Name = "Giáo vụ đào tạo", Desc = "Mở lớp, xếp lịch chống trùng, phân công GV, xét chứng chỉ" },
            new { Code = "ROLE_TEA", Name = "Giáo viên", Desc = "Điểm danh lớp học, nhập điểm thi, ghi nhận xét tiến độ" },
            new { Code = "ROLE_STU", Name = "Học viên", Desc = "Tra cứu lịch học, chuyên cần, bảng điểm, học phí cá nhân" },
            new { Code = "ROLE_PAR", Name = "Phụ huynh", Desc = "Theo dõi việc học, điểm danh, kết quả và học phí của các con" }
        };

        foreach (var r in roles)
        {
            conn.Execute(@"
                INSERT INTO Roles (RoleCode, RoleName, Description) 
                VALUES (@Code, @Name, @Desc)
                ON CONFLICT(RoleCode) DO UPDATE SET RoleName = excluded.RoleName, Description = excluded.Description;", r);
        }

        // 2. Seed Core Employees & Teachers (when DB is fresh)
        conn.Execute(@"
            INSERT OR IGNORE INTO Employees (EmployeeId, EmployeeCode, FullName, Department, Phone, Email) 
            VALUES 
            (1, 'NV-0001', 'Hoàng Văn Quản', 'Ban Giám đốc', '0901234567', 'manager@ecms.edu.vn'),
            (2, 'NV-0002', 'Lê Thị Thảo', 'Phòng Tuyển sinh', '0902345678', 'counselor@ecms.edu.vn'),
            (3, 'NV-0003', 'Phạm Minh Tài', 'Phòng Kế toán', '0903456789', 'accountant@ecms.edu.vn'),
            (4, 'NV-0004', 'Đặng Thị Mai', 'Phòng Đào tạo', '0904567890', 'academic@ecms.edu.vn');");

        int teacherCount = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM Teachers;");
        if (teacherCount == 0)
        {
            conn.Execute(@"
                INSERT INTO Teachers (TeacherId, TeacherCode, FullName, Specialization, Phone, Email, HourlyRate, IsNativeSpeaker, IsActive, Certificate, PreferredShifts, AvailableDays) 
                VALUES 
                (1, 'GV-001', 'Nguyễn Hoàng Anh', 'IELTS Foundation', '0905111222', 'hoanganh@ecms.edu.vn', 350000, 0, 1, 'IELTS 8.5 · TESOL', 'Ca tối (18:00–20:00)', 'T2, T4, T6'),
                (2, 'GV-002', 'John Smith', 'IELTS Intensive', '0905333444', 'john.smith@ecms.edu.vn', 450000, 1, 1, 'CELTA · DELTA', 'Ca chiều (14:00–16:00)', 'T3, T5, T7'),
                (3, 'GV-003', 'Lê Hoàng Yến', 'TOEIC 500+', '0905555666', 'hoangyen.gv@ecms.edu.vn', 300000, 0, 1, 'TOEIC 965 · Thạc sĩ Ngôn ngữ', 'Ca sáng (08:30–10:30)', 'T3, T5, T7'),
                (4, 'GV-004', 'Trần Gia Bảo', 'Tiếng Anh giao tiếp', '0905777888', 'giabao.gv@ecms.edu.vn', 280000, 0, 1, 'IELTS 7.5 · Giao tiếp', 'Ca tối (18:00–20:00)', 'T3, T5, T7');");
        }

        // Ensure Student 1 & Parent 1 exist for default student/parent login accounts
        conn.Execute(@"
            INSERT OR IGNORE INTO Students (StudentId, StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status) 
            VALUES (1, 'HV-0001', 'Nguyễn Văn An', '2005-06-15', 'Nam', '0912345678', 'an.nguyen@gmail.com', '123 Lê Lợi, Q.1, TP.HCM', 'Active');
            INSERT OR IGNORE INTO Parents (ParentId, ParentCode, FullName, Phone, Email, Occupation) 
            VALUES (1, 'PH-0001', 'Trần Thị Mai', '0918765432', 'mai.tran@gmail.com', 'Kinh doanh');
            INSERT OR IGNORE INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact) 
            VALUES (1, 1, 'Mẹ', 1);");

        // 3. Seed Users for All 8 Roles with BCrypt Hashes
        var sampleUsers = new[]
        {
            new { Username = "admin", Password = "Admin@123", Role = "ROLE_ADMIN", EmpId = (int?)null, TeaId = (int?)null, StuId = (int?)null, ParId = (int?)null },
            new { Username = "manager", Password = "Manager@123", Role = "ROLE_MGR", EmpId = (int?)1, TeaId = (int?)null, StuId = (int?)null, ParId = (int?)null },
            new { Username = "counselor", Password = "Counselor@123", Role = "ROLE_EC", EmpId = (int?)2, TeaId = (int?)null, StuId = (int?)null, ParId = (int?)null },
            new { Username = "accountant", Password = "Accountant@123", Role = "ROLE_ACC", EmpId = (int?)3, TeaId = (int?)null, StuId = (int?)null, ParId = (int?)null },
            new { Username = "academic", Password = "Academic@123", Role = "ROLE_AA", EmpId = (int?)4, TeaId = (int?)null, StuId = (int?)null, ParId = (int?)null },
            new { Username = "teacher", Password = "Teacher@123", Role = "ROLE_TEA", EmpId = (int?)null, TeaId = (int?)1, StuId = (int?)null, ParId = (int?)null },
            new { Username = "student", Password = "Student@123", Role = "ROLE_STU", EmpId = (int?)null, TeaId = (int?)null, StuId = (int?)1, ParId = (int?)null },
            new { Username = "parent", Password = "Parent@123", Role = "ROLE_PAR", EmpId = (int?)null, TeaId = (int?)null, StuId = (int?)null, ParId = (int?)1 }
        };

        foreach (var u in sampleUsers)
        {
            // Chỉ seed tài khoản nếu chưa tồn tại (tránh ghi đè mật khẩu đã đổi hoặc trạng thái khóa khi khởi động lại)
            int existingUserId = conn.ExecuteScalar<int>("SELECT UserId FROM Users WHERE Username = @Username;", new { u.Username });
            if (existingUserId == 0)
            {
                string hash = BCrypt.Net.BCrypt.HashPassword(u.Password);
                conn.Execute(@"
                    INSERT INTO Users (Username, PasswordHash, PasswordSalt, EmployeeId, TeacherId, StudentId, ParentId, IsActive)
                    VALUES (@Username, @Hash, 'salt', @EmpId, @TeaId, @StuId, @ParId, 1);",
                    new { u.Username, Hash = hash, u.EmpId, u.TeaId, u.StuId, u.ParId });

                existingUserId = conn.ExecuteScalar<int>("SELECT UserId FROM Users WHERE Username = @Username;", new { u.Username });
            }

            // Assign Role if missing
            int roleId = conn.ExecuteScalar<int>("SELECT RoleId FROM Roles WHERE RoleCode = @Role;", new { u.Role });
            if (existingUserId > 0 && roleId > 0)
            {
                conn.Execute(@"
                    INSERT OR IGNORE INTO UserRoles (UserId, RoleId) 
                    VALUES (@UserId, @RoleId);", new { UserId = existingUserId, RoleId = roleId });
            }
        }

        int cashierId = conn.ExecuteScalar<int>("SELECT UserId FROM Users WHERE Username = 'accountant';");
        if (cashierId == 0) cashierId = 1;

        // 4. Seed Unified Academic & Finance Dataset (only when Courses is empty)
        int courseCount = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM Courses;");
        if (courseCount == 0)
        {
            var today = DateTime.Today;
            int diffToMon = ((int)today.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
            var thisMonday = today.AddDays(-diffToMon);
            var lastMonday = thisMonday.AddDays(-7);

            // 4.1 Courses
            conn.Execute(@"
                INSERT INTO Courses (CourseId, CourseCode, CourseName, Level, TotalHours, TotalSessions, BaseTuitionFee, PassingScore, IsActive)
                VALUES 
                (1, 'KH-001', 'IELTS Foundation 5.5+', 'Trung cấp (5.0-6.5)', 48, 24, 5500000, 5.5, 1),
                (2, 'KH-002', 'IELTS Intensive 6.5+', 'Nâng cao (7.0+)', 60, 30, 8500000, 6.5, 1),
                (3, 'KH-003', 'TOEIC 500+', 'Trung cấp (5.0-6.5)', 40, 20, 4800000, 5.0, 1),
                (4, 'KH-004', 'Tiếng Anh giao tiếp', 'Cơ bản (0-4.5)', 32, 16, 3600000, 5.0, 1);");

            // 4.2 ClassRooms
            conn.Execute(@"
                INSERT INTO ClassRooms (RoomId, RoomName, Floor, Capacity, HasProjector, IsActive, Equipment, RoomStatus)
                VALUES 
                (1, 'P101', 1, 25, 1, 1, 'Máy chiếu Sony, Bảng từ, Âm thanh', 'Đang sử dụng'),
                (2, 'P201', 2, 20, 1, 1, 'Màn hình tương tác, Bảng kính', 'Đang sử dụng'),
                (3, 'P202', 2, 22, 1, 1, 'Máy chiếu Epson, Điều hòa', 'Đang sử dụng'),
                (4, 'P203', 2, 18, 1, 1, 'Máy chiếu, Loa Bluetooth', 'Đang sử dụng');");

            // 4.3 Classes
            conn.Execute(@"
                INSERT INTO Classes (ClassId, ClassCode, ClassName, CourseId, MainTeacherId, DefaultRoomId, StartDate, EndDate, MaxStudents, Status)
                VALUES 
                (1, 'IELTS-F01', 'Lớp IELTS Foundation F01', 1, 1, 1, @Start1, @End1, 20, 'InProgress'),
                (2, 'IELTS-I01', 'Lớp IELTS Intensive I01', 2, 2, 2, @Start2, @End2, 15, 'InProgress'),
                (3, 'TOEIC-A01', 'Lớp TOEIC 500+ A01', 3, 3, 3, @Start3, @End3, 20, 'InProgress'),
                (4, 'COM-B01', 'Lớp Giao tiếp B01 (Sắp mở)', 4, 4, 4, @Start4, @End4, 18, 'OpenForEnrollment'),
                (5, 'IELTS-F00', 'Lớp IELTS Foundation F00', 1, 1, 1, @Start5, @End5, 15, 'Completed');",
                new
                {
                    Start1 = lastMonday.AddDays(-14).ToString("yyyy-MM-dd"),
                    End1 = thisMonday.AddDays(45).ToString("yyyy-MM-dd"),
                    Start2 = lastMonday.AddDays(-13).ToString("yyyy-MM-dd"),
                    End2 = thisMonday.AddDays(60).ToString("yyyy-MM-dd"),
                    Start3 = lastMonday.AddDays(-13).ToString("yyyy-MM-dd"),
                    End3 = thisMonday.AddDays(40).ToString("yyyy-MM-dd"),
                    Start4 = thisMonday.AddDays(7).ToString("yyyy-MM-dd"),
                    End4 = thisMonday.AddDays(60).ToString("yyyy-MM-dd"),
                    Start5 = lastMonday.AddDays(-90).ToString("yyyy-MM-dd"),
                    End5 = lastMonday.AddDays(-10).ToString("yyyy-MM-dd")
                });

            // 4.4 ClassSchedules (tuần trước + tuần này để Schedule & Attendance có sẵn dữ liệu test ngay)
            var schSql = "INSERT INTO ClassSchedules (ScheduleId, ClassId, SessionNumber, Date, StartTime, EndTime, RoomId, TeacherId, IsAttendanceLocked, Topic) VALUES (@Id, @ClassId, @Num, @Date, @Start, @End, @RoomId, @TeacherId, @Locked, @Topic);";
            DateTime[] c1Dates = { lastMonday, lastMonday.AddDays(2), lastMonday.AddDays(4), thisMonday, thisMonday.AddDays(2), thisMonday.AddDays(4) };
            for (int i = 0; i < c1Dates.Length; i++)
                conn.Execute(schSql, new { Id = i + 1, ClassId = 1, Num = i + 1, Date = c1Dates[i].ToString("yyyy-MM-dd"), Start = "18:00", End = "20:00", RoomId = 1, TeacherId = 1, Locked = i < 3 ? 1 : 0, Topic = $"Buổi {i + 1} - IELTS Foundation" });

            DateTime[] c2Dates = { lastMonday.AddDays(1), lastMonday.AddDays(3), lastMonday.AddDays(5), thisMonday.AddDays(1), thisMonday.AddDays(3), thisMonday.AddDays(5) };
            for (int i = 0; i < c2Dates.Length; i++)
                conn.Execute(schSql, new { Id = 10 + i + 1, ClassId = 2, Num = i + 1, Date = c2Dates[i].ToString("yyyy-MM-dd"), Start = "14:00", End = "16:00", RoomId = 2, TeacherId = 2, Locked = i < 2 ? 1 : 0, Topic = $"Buổi {i + 1} - IELTS Intensive" });

            for (int i = 0; i < c2Dates.Length; i++)
                conn.Execute(schSql, new { Id = 20 + i + 1, ClassId = 3, Num = i + 1, Date = c2Dates[i].ToString("yyyy-MM-dd"), Start = "08:30", End = "10:30", RoomId = 3, TeacherId = 3, Locked = i < 2 ? 1 : 0, Topic = $"Buổi {i + 1} - TOEIC 500+" });

            conn.Execute(schSql, new { Id = 31, ClassId = 4, Num = 1, Date = thisMonday.AddDays(7).ToString("yyyy-MM-dd"), Start = "18:00", End = "20:00", RoomId = 4, TeacherId = 4, Locked = 0, Topic = "Khai giảng Giao tiếp B01" });

            // 4.5 Students & Parents (HV-0002..HV-0013)
            var students = new[]
            {
                new { Id = 2, Code = "HV-0002", Name = "Nguyễn Minh Anh", Dob = "2004-05-20", Gender = "Nữ", Phone = "0908123456", Email = "minhanh@gmail.com", Addr = "12 Hoàng Diệu, Phú Nhuận", Status = "Active", PName = "Nguyễn Thu Hương", PPhone = "0911556889", Rel = "Mẹ" },
                new { Id = 3, Code = "HV-0003", Name = "Lê Hoàng Nam", Dob = "2005-01-22", Gender = "Nam", Phone = "0904221678", Email = "hoangnam@gmail.com", Addr = "78 CMT8, Q.3", Status = "Active", PName = "Lê Thị Thảo", PPhone = "0903556778", Rel = "Mẹ" },
                new { Id = 4, Code = "HV-0004", Name = "Phạm Khánh Linh", Dob = "2004-11-10", Gender = "Nữ", Phone = "0912450678", Email = "khanhlinh@gmail.com", Addr = "89 Nguyễn Đình Chiểu, Q.3", Status = "Active", PName = "Phạm Đức Thắng", PPhone = "0913889900", Rel = "Bố" },
                new { Id = 5, Code = "HV-0005", Name = "Trần Gia Bảo", Dob = "2003-08-14", Gender = "Nam", Phone = "0915227330", Email = "giabao@gmail.com", Addr = "45 Lê Duẩn, Q.1", Status = "Active", PName = "Trần Văn Hùng", PPhone = "0918223344", Rel = "Bố" },
                new { Id = 6, Code = "HV-0006", Name = "Võ Hoàng Yến", Dob = "2005-07-19", Gender = "Nữ", Phone = "0978112334", Email = "hoangyen@gmail.com", Addr = "234 Võ Văn Tần, Q.3", Status = "Active", PName = "Nguyễn Mỹ Lan", PPhone = "0977445566", Rel = "Mẹ" },
                new { Id = 7, Code = "HV-0007", Name = "Nguyễn Tiến Đạt", Dob = "2002-12-01", Gender = "Nam", Phone = "0982334556", Email = "tiendat@gmail.com", Addr = "67 Trần Hưng Đạo, Q.5", Status = "Active", PName = "Nguyễn Tiến Thịnh", PPhone = "0983667788", Rel = "Bố" },
                new { Id = 8, Code = "HV-0008", Name = "Bùi Mai Phương", Dob = "2004-09-30", Gender = "Nữ", Phone = "0903778990", Email = "maiphuong@gmail.com", Addr = "19 Pasteur, Q.1", Status = "Active", PName = "Vũ Bích Hạnh", PPhone = "0908990011", Rel = "Mẹ" },
                new { Id = 9, Code = "HV-0009", Name = "Đỗ Thanh Tâm", Dob = "2003-03-05", Gender = "Nữ", Phone = "0935661220", Email = "thanhtam@gmail.com", Addr = "15 Phan Đăng Lưu, Bình Thạnh", Status = "Active", PName = "Đỗ Văn Kiên", PPhone = "0938112233", Rel = "Bố" },
                new { Id = 10, Code = "HV-0010", Name = "Trần Thảo Nhi", Dob = "2005-04-12", Gender = "Nữ", Phone = "0909887766", Email = "thaonhi@gmail.com", Addr = "102 Hai Bà Trưng, Q.1", Status = "Active", PName = "Trần Minh Tuấn", PPhone = "0909112233", Rel = "Bố" },
                new { Id = 11, Code = "HV-0011", Name = "Đặng Minh Trí", Dob = "2003-06-18", Gender = "Nam", Phone = "0917223344", Email = "minhtri@gmail.com", Addr = "55 Nguyễn Trãi, Q.5", Status = "Completed", PName = "Đặng Văn Long", PPhone = "0917556677", Rel = "Bố" },
                new { Id = 12, Code = "HV-0012", Name = "Hoàng Đức An", Dob = "2004-02-25", Gender = "Nam", Phone = "0933445566", Email = "ducan@gmail.com", Addr = "30 Điện Biên Phủ, Q.3", Status = "Completed", PName = "Hoàng Thị Lan", PPhone = "0933778899", Rel = "Mẹ" },
                new { Id = 13, Code = "HV-0013", Name = "Vũ Ngọc Lan", Dob = "2005-09-08", Gender = "Nữ", Phone = "0944556677", Email = "ngoclan@gmail.com", Addr = "11 Võ Thị Sáu, Q.3", Status = "Reserved", PName = "Vũ Văn Hải", PPhone = "0944889900", Rel = "Bố" }
            };

            foreach (var s in students)
            {
                conn.Execute(@"
                    INSERT INTO Students (StudentId, StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status)
                    VALUES (@Id, @Code, @Name, @Dob, @Gender, @Phone, @Email, @Addr, @Status);", s);
                conn.Execute(@"
                    INSERT INTO Parents (ParentId, ParentCode, FullName, Phone, Email, Occupation)
                    VALUES (@Id, @PCode, @PName, @PPhone, '', 'Nhân viên văn phòng');",
                    new { s.Id, PCode = $"PH-{s.Id:D4}", s.PName, s.PPhone });
                conn.Execute(@"
                    INSERT INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                    VALUES (@Id, @Id, @Rel, 1);", new { s.Id, s.Rel });
            }

            // 4.6 Enrollments (HV-0009 & HV-0010 chưa xếp lớp để test Chờ xếp lớp)
            conn.Execute(@"
                INSERT INTO Enrollments (EnrollmentId, StudentId, ClassId, EnrollDate, Status, FinalGPA, AttendanceRate)
                VALUES 
                (1, 1, 1, @D1, 'Active', 8.5, 100.0),
                (2, 2, 1, @D1, 'Active', 7.8, 100.0),
                (3, 3, 1, @D1, 'Active', 7.2, 25.0),
                (4, 4, 1, @D1, 'PendingPayment', NULL, 100.0),
                (5, 5, 2, @D1, 'Active', 8.0, 100.0),
                (6, 6, 2, @D1, 'Active', 8.4, 100.0),
                (7, 7, 3, @D1, 'Active', 7.9, 100.0),
                (8, 8, 3, @D1, 'Active', 7.4, 100.0),
                (9, 11, 5, @D2, 'Completed', 8.6, 100.0),
                (10, 12, 5, @D2, 'Completed', 8.2, 95.8),
                (11, 13, 1, @D1, 'Reserved', NULL, 50.0);",
                new { D1 = lastMonday.AddDays(-14).ToString("yyyy-MM-dd"), D2 = lastMonday.AddDays(-90).ToString("yyyy-MM-dd") });

            // 4.7 AttendanceRecords (HV-0003 vắng 3 buổi để kích hoạt Cảnh báo chuyên cần)
            conn.Execute(@"
                INSERT INTO AttendanceRecords (ScheduleId, StudentId, Status, Note)
                VALUES 
                (1, 1, 'Present', ''), (2, 1, 'Present', ''), (3, 1, 'Present', ''),
                (1, 2, 'Present', ''), (2, 2, 'Present', ''), (3, 2, 'Late', 'Đến trễ 10 phút'),
                (1, 3, 'Absent', 'Nghỉ không phép'), (2, 3, 'Absent', 'Nghỉ không phép'), (3, 3, 'Absent', 'Nghỉ ốm'),
                (1, 4, 'Present', ''), (2, 4, 'Present', ''), (3, 4, 'Present', ''),
                (11, 5, 'Present', ''), (12, 5, 'Present', ''),
                (11, 6, 'Present', ''), (12, 6, 'Present', ''),
                (21, 7, 'Present', ''), (22, 7, 'Present', ''),
                (21, 8, 'Present', ''), (22, 8, 'Present', '');");

            // 4.8 Exams & ExamScores
            conn.Execute(@"
                INSERT INTO Exams (ExamId, ClassId, ExamName, Type, ExamDate, StartTime, EndTime, RoomId, WeightPercentage)
                VALUES 
                (1, 1, 'Kiểm tra Giữa kỳ IELTS F01', 'Midterm', @MidDate, '18:00', '19:30', 1, 40.0),
                (2, 1, 'Kiểm tra Cuối kỳ IELTS F01', 'Final', @FinDate, '18:00', '20:00', 1, 60.0),
                (3, 2, 'Kiểm tra Giữa kỳ IELTS I01', 'Midterm', @MidDate, '14:00', '15:30', 2, 40.0),
                (4, 3, 'Kiểm tra Giữa kỳ TOEIC A01', 'Midterm', @MidDate, '08:30', '10:00', 3, 40.0),
                (5, 5, 'Thi Cuối khóa IELTS F00', 'Final', @DoneDate, '18:00', '20:00', 1, 100.0);

                INSERT INTO ExamScores (ExamId, StudentId, ScoreValue, TeacherComments)
                VALUES 
                (1, 1, 8.5, 'Listening & Reading rất tốt'),
                (1, 2, 7.8, 'Viết mạch lạc, cần tăng tốc độ đọc'),
                (1, 3, 7.2, 'Cần đi học đầy đủ hơn'),
                (3, 5, 8.0, 'Phản xạ Speaking tốt'),
                (3, 6, 8.4, 'Tiến bộ rõ rệt'),
                (4, 7, 7.9, 'Nắm chắc ngữ pháp TOEIC'),
                (4, 8, 7.4, 'Cần luyện thêm Part 7'),
                (5, 11, 8.6, 'Xuất sắc, đủ điều kiện tốt nghiệp'),
                (5, 12, 8.2, 'Giỏi, đủ điều kiện tốt nghiệp');",
                new
                {
                    MidDate = thisMonday.AddDays(5).ToString("yyyy-MM-dd"),
                    FinDate = thisMonday.AddDays(30).ToString("yyyy-MM-dd"),
                    DoneDate = lastMonday.AddDays(-12).ToString("yyyy-MM-dd")
                });

            // 4.9 FeeDiscounts
            conn.Execute(@"
                INSERT INTO FeeDiscounts (DiscountId, DiscountCode, DiscountName, Percentage, FixedAmount, Description, RequiresApproval, IsActive)
                VALUES 
                (1, 'HVCU10', 'Học viên cũ của trung tâm', 10, 0, 'Giảm 10% học phí tri ân học viên cũ', 0, 1),
                (2, 'NHOM15', 'Đăng ký theo nhóm (>= 2 người)', 15, 0, 'Giảm 15% học phí khi đăng ký theo nhóm', 1, 1),
                (3, 'EARLY500', 'Ưu đãi đăng ký sớm (Early Bird)', 0, 500000, 'Giảm trực tiếp 500.000đ khi đăng ký sớm', 0, 1);");

            // 4.10 Invoices & Payments (khớp 100% học phí & công nợ)
            conn.Execute(@"
                INSERT INTO Invoices (InvoiceId, InvoiceCode, EnrollmentId, OriginalAmount, DiscountAmount, FinalAmount, BalanceDue, DueDate, Status)
                VALUES 
                (1, 'INV-2026-0001', 1, 5500000, 0, 5500000, 0, @DuePaid, 'Paid'),
                (2, 'INV-2026-0002', 2, 5500000, 0, 5500000, 3300000, @DueSoon, 'PartiallyPaid'),
                (3, 'INV-2026-0003', 3, 5500000, 0, 5500000, 0, @DuePaid, 'Paid'),
                (4, 'INV-2026-0004', 4, 5500000, 0, 5500000, 5500000, @DueOver, 'Unpaid'),
                (5, 'INV-2026-0005', 5, 8500000, 850000, 7650000, 4590000, @DueSoon, 'PartiallyPaid'),
                (6, 'INV-2026-0006', 6, 8500000, 0, 8500000, 0, @DuePaid, 'Paid'),
                (7, 'INV-2026-0007', 7, 4800000, 0, 4800000, 0, @DuePaid, 'Paid'),
                (8, 'INV-2026-0008', 8, 4800000, 0, 4800000, 2400000, @DueSoon, 'PartiallyPaid'),
                (9, 'INV-2026-0009', 9, 5500000, 0, 5500000, 0, @DuePaid, 'Paid'),
                (10, 'INV-2026-0010', 10, 5500000, 0, 5500000, 0, @DuePaid, 'Paid');",
                new
                {
                    DuePaid = lastMonday.AddDays(-7).ToString("yyyy-MM-dd"),
                    DueSoon = thisMonday.AddDays(5).ToString("yyyy-MM-dd"),
                    DueOver = lastMonday.AddDays(-2).ToString("yyyy-MM-dd")
                });

            conn.Execute(@"
                INSERT INTO Payments (PaymentId, PaymentCode, InvoiceId, PaidAmount, PaymentDate, PaymentMethod, CashierId, Status, Note)
                VALUES 
                (1, 'PT-2026-0001', 1, 5500000, @P1, 'Chuyển khoản', @CashierId, 'Valid', 'Thu trọn khóa IELTS Foundation F01'),
                (2, 'PT-2026-0002', 2, 2200000, @P2, 'Tiền mặt', @CashierId, 'Valid', 'Thu đợt 1 (40%) IELTS Foundation F01'),
                (3, 'PT-2026-0003', 3, 5500000, @P2, 'Chuyển khoản', @CashierId, 'Valid', 'Thu trọn khóa IELTS Foundation F01'),
                (4, 'PT-2026-0004', 5, 3060000, @P3, 'Chuyển khoản', @CashierId, 'Valid', 'Thu đợt 1 (40%) IELTS Intensive I01 (Ưu đãi HVCU10)'),
                (5, 'PT-2026-0005', 6, 8500000, @P3, 'POS', @CashierId, 'Valid', 'Thu trọn khóa IELTS Intensive I01'),
                (6, 'PT-2026-0006', 7, 4800000, @P3, 'Chuyển khoản', @CashierId, 'Valid', 'Thu trọn khóa TOEIC 500+ A01'),
                (7, 'PT-2026-0007', 8, 2400000, @P4, 'Tiền mặt', @CashierId, 'Valid', 'Thu đợt 1 (50%) TOEIC 500+ A01'),
                (8, 'PT-2026-0008', 9, 5500000, @P0, 'Chuyển khoản', @CashierId, 'Valid', 'Thu trọn khóa IELTS Foundation F00'),
                (9, 'PT-2026-0009', 10, 5500000, @P0, 'Chuyển khoản', @CashierId, 'Valid', 'Thu trọn khóa IELTS Foundation F00');",
                new
                {
                    CashierId = cashierId,
                    P0 = lastMonday.AddDays(-85).ToString("yyyy-MM-dd 09:30:00"),
                    P1 = lastMonday.AddDays(-14).ToString("yyyy-MM-dd 09:30:00"),
                    P2 = lastMonday.AddDays(-10).ToString("yyyy-MM-dd 14:15:00"),
                    P3 = lastMonday.AddDays(-5).ToString("yyyy-MM-dd 10:20:00"),
                    P4 = thisMonday.ToString("yyyy-MM-dd 15:00:00")
                });

            // 4.11 Certificates (1 đã cấp, HV-0012 đủ điều kiện chờ cấp)
            conn.Execute(@"
                INSERT INTO Certificates (CertificateId, CertificateNo, EnrollmentId, StudentId, IssueDate, GraduationGrade)
                VALUES (1, 'CC-2026-0001', 9, 11, @IssueDate, 'Xuất sắc');",
                new { IssueDate = lastMonday.AddDays(-5).ToString("yyyy-MM-dd") });

            // 4.12 StudyMaterials
            conn.Execute(@"
                INSERT INTO StudyMaterials (CourseId, Title, FilePath, Description, Version, FileType, FileSize)
                VALUES 
                (1, 'IELTS_Foundation_Workbook.pdf', 'C:\ECMS\TaiLieu\IELTS_Foundation_Workbook.pdf', 'Giáo trình bài tập IELTS Foundation 5.5+', '1.2', 'PDF', '12.4 MB'),
                (2, 'IELTS_Intensive_Speaking_Guide.pdf', 'C:\ECMS\TaiLieu\IELTS_Intensive_Speaking_Guide.pdf', 'Bộ đề & bài mẫu Speaking 6.5+', '2.0', 'PDF', '8.6 MB'),
                (3, 'TOEIC_500_Listening_Audio.mp3', 'C:\ECMS\TaiLieu\TOEIC_500_Listening_Audio.mp3', 'Audio luyện nghe TOEIC Part 1-4', '1.0', 'MP3', '15.2 MB'),
                (4, 'Communication_Starter_Handbook.docx', 'C:\ECMS\TaiLieu\Communication_Starter_Handbook.docx', 'Sổ tay mẫu câu giao tiếp cơ bản', '1.1', 'DOCX', '3.5 MB');");

            // 4.13 Leads
            conn.Execute(@"
                INSERT INTO Leads (LeadId, FullName, Phone, Email, Source, Status, AssignedEmployeeId, Notes)
                VALUES 
                (1, 'Nguyễn Thị Thu Hà', '0905123456', 'thuha@gmail.com', 'Facebook Fanpage', 'New', 2, 'Quan tâm IELTS Foundation tối 2-4-6'),
                (2, 'Trần Đình Trọng', '0912345679', 'trong@gmail.com', 'Trực tiếp', 'Contacted', 2, 'Cần thi TOEIC 500+ trong 3 tháng'),
                (3, 'Phạm Quốc Bảo', '0933112233', 'quocbao@gmail.com', 'Website', 'TestScheduled', 2, 'Hẹn test đầu vào 14:00 Thứ 7');");
        }

        // Seed SystemConfigs
        int configCount = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM SystemConfigs;");
        if (configCount == 0)
        {
            var configs = new[]
            {
                new { Key = "CenterName", Val = "Trung tâm Anh ngữ Quốc tế ECMS", Desc = "Tên hiển thị trung tâm" },
                new { Key = "CenterAddress", Val = "123 Đường Sáng Tạo, Quận 1, TP. Hồ Chí Minh", Desc = "Địa chỉ cơ sở" },
                new { Key = "CenterPhone", Val = "028 1234 5678", Desc = "Số điện thoại hotline" },
                new { Key = "MaxAbsencesAlert", Val = "3", Desc = "Số buổi vắng tối đa kích hoạt cảnh báo chuyên cần" },
                new { Key = "MinPassingGPA", Val = "5.0", Desc = "Điểm GPA tối thiểu để xét tốt nghiệp" },
                new { Key = "MinAttendanceRate", Val = "80.0", Desc = "Tỷ lệ chuyên cần tối thiểu (%) để xét tốt nghiệp" },
                new { Key = "WallpaperVideoPath", Val = "", Desc = "Đường dẫn file video cục bộ làm hình nền" },
                new { Key = "WallpaperOverlayOpacity", Val = "65", Desc = "Độ mờ lớp phủ tối Dark Overlay (0 - 90%)" },
                new { Key = "WallpaperAudioEnabled", Val = "false", Desc = "Bật/Tắt âm thanh video nền" },
                new { Key = "WallpaperLoopEnabled", Val = "true", Desc = "Lặp lại video vô tận" }
            };

            foreach (var c in configs)
            {
                conn.Execute("INSERT INTO SystemConfigs (ConfigKey, ConfigValue, Description) VALUES (@Key, @Val, @Desc);", c);
            }
        }

        // 6. Seed RBAC Permissions Catalog & Default Mappings
        SeedPermissionsAndDefaults(conn);
    }

    public static void SeedPermissionsAndDefaults(SqliteConnection conn)
    {
        var permissions = new[]
        {
            // 1. Quản trị Người dùng & Bảo mật
            new { Code = "USER_VIEW", Name = "Xem danh sách người dùng", Module = "Quản trị Tài khoản & Bảo mật", Desc = "Xem danh sách tài khoản nội bộ và phân quyền vai trò" },
            new { Code = "USER_CREATE", Name = "Tạo tài khoản mới", Module = "Quản trị Tài khoản & Bảo mật", Desc = "Khởi tạo tài khoản nhân sự và phân bổ quyền hạn" },
            new { Code = "USER_EDIT", Name = "Chỉnh sửa tài khoản", Module = "Quản trị Tài khoản & Bảo mật", Desc = "Cập nhật thông tin nhân sự và gán lại vai trò" },
            new { Code = "USER_LOCK", Name = "Khóa / Mở tài khoản", Module = "Quản trị Tài khoản & Bảo mật", Desc = "Vô hiệu hóa hoặc kích hoạt lại trạng thái hoạt động" },
            new { Code = "USER_RESET_PWD", Name = "Reset mật khẩu", Module = "Quản trị Tài khoản & Bảo mật", Desc = "Đặt lại mật khẩu cho tài khoản người dùng" },
            new { Code = "USER_UNLOCK", Name = "Mở khóa Brute-force", Module = "Quản trị Tài khoản & Bảo mật", Desc = "Mở khóa khẩn cấp tài khoản nhập sai mật khẩu quá 5 lần" },

            // 2. Phân quyền RBAC
            new { Code = "RBAC_VIEW", Name = "Xem ma trận phân quyền", Module = "Phân quyền RBAC", Desc = "Xem danh mục quyền hạn của từng vai trò hệ thống" },
            new { Code = "RBAC_MANAGE", Name = "Cấu hình phân quyền động", Module = "Phân quyền RBAC", Desc = "Bật/tắt quyền hạn theo từng vai trò trên các phân hệ" },

            // 3. Khách hàng tiềm năng (Leads)
            new { Code = "LEAD_VIEW", Name = "Xem danh sách Leads", Module = "Khách hàng Tiềm năng (Leads)", Desc = "Tra cứu thông tin khách hàng tiềm năng" },
            new { Code = "LEAD_CREATE", Name = "Tiếp nhận Lead mới", Module = "Khách hàng Tiềm năng (Leads)", Desc = "Thêm mới khách hàng từ các kênh tuyển sinh" },
            new { Code = "LEAD_EDIT", Name = "Cập nhật Lead", Module = "Khách hàng Tiềm năng (Leads)", Desc = "Cập nhật thông tin và trạng thái chăm sóc" },
            new { Code = "LEAD_CONSULT", Name = "Ghi nhật ký tư vấn", Module = "Khách hàng Tiềm năng (Leads)", Desc = "Lưu nội dung cuộc gọi và nguyện vọng học tập" },
            new { Code = "LEAD_TEST", Name = "Đặt lịch Placement Test", Module = "Khách hàng Tiềm năng (Leads)", Desc = "Lập lịch hẹn kiểm tra trình độ đầu vào" },
            new { Code = "LEAD_CONVERT", Name = "Chuyển đổi thành Học viên", Module = "Khách hàng Tiềm năng (Leads)", Desc = "Chuyển Lead thành hồ sơ học viên chính thức" },

            // 4. Hồ sơ Học viên & Phụ huynh
            new { Code = "STUDENT_VIEW", Name = "Xem hồ sơ học viên", Module = "Học viên & Phụ huynh", Desc = "Tra cứu thông tin chi tiết học viên và phụ huynh" },
            new { Code = "STUDENT_CREATE", Name = "Tạo hồ sơ học viên", Module = "Học viên & Phụ huynh", Desc = "Khởi tạo học viên mới và sinh mã chuẩn HV-yyyy-xxxx" },
            new { Code = "STUDENT_EDIT", Name = "Chỉnh sửa học viên", Module = "Học viên & Phụ huynh", Desc = "Cập nhật thông tin cá nhân và liên hệ phụ huynh" },
            new { Code = "STUDENT_STATUS", Name = "Quản lý trạng thái học tập", Module = "Học viên & Phụ huynh", Desc = "Chuyển trạng thái bảo lưu, thôi học, tốt nghiệp" },

            // 5. Khóa học & Phòng học
            new { Code = "COURSE_VIEW", Name = "Xem danh mục khóa học", Module = "Khóa học & Phòng học", Desc = "Xem chương trình đào tạo và học phí chuẩn" },
            new { Code = "COURSE_MANAGE", Name = "Quản lý khóa học", Module = "Khóa học & Phòng học", Desc = "Thêm mới và cập nhật nội dung khóa học" },
            new { Code = "ROOM_VIEW", Name = "Xem danh mục phòng học", Module = "Khóa học & Phòng học", Desc = "Tra cứu danh sách phòng và trang thiết bị" },
            new { Code = "ROOM_MANAGE", Name = "Quản lý phòng học", Module = "Khóa học & Phòng học", Desc = "Thêm mới và chỉnh sửa thông tin phòng học" },

            // 6. Lớp học & Xếp lịch
            new { Code = "CLASS_VIEW", Name = "Xem danh sách lớp học", Module = "Lớp học & Đào tạo", Desc = "Tra cứu lớp học và sĩ số hiện tại" },
            new { Code = "CLASS_MANAGE", Name = "Mở và quản lý lớp học", Module = "Lớp học & Đào tạo", Desc = "Khởi tạo lớp mới và cập nhật trạng thái lớp" },
            new { Code = "CLASS_SCHEDULE", Name = "Xếp thời khóa biểu", Module = "Lớp học & Đào tạo", Desc = "Xếp lịch học chống trùng giáo viên và phòng học" },
            new { Code = "CLASS_ENROLL", Name = "Ghi danh học viên", Module = "Lớp học & Đào tạo", Desc = "Đăng ký học viên vào lớp học" },

            // 7. Chuyên cần & Điểm thi
            new { Code = "ATTENDANCE_VIEW", Name = "Xem sổ điểm danh", Module = "Chuyên cần & Điểm số", Desc = "Tra cứu lịch sử chuyên cần của lớp học" },
            new { Code = "ATTENDANCE_TAKE", Name = "Điểm danh buổi học", Module = "Chuyên cần & Điểm số", Desc = "Ghi nhận chuyên cần và cảnh báo vắng học" },
            new { Code = "EXAM_VIEW", Name = "Xem kỳ thi & bảng điểm", Module = "Chuyên cần & Điểm số", Desc = "Tra cứu điểm số các kỳ thi của lớp" },
            new { Code = "EXAM_MANAGE", Name = "Nhập & sửa điểm thi", Module = "Chuyên cần & Điểm số", Desc = "Nhập điểm 4 kỹ năng và nhận xét tiến độ" },

            // 8. Tài chính & Thu phí
            new { Code = "INVOICE_VIEW", Name = "Xem hóa đơn học phí", Module = "Tài chính & Thu phí", Desc = "Tra cứu khoản phải thu và công nợ học viên" },
            new { Code = "PAYMENT_CREATE", Name = "Lập phiếu thu tiền", Module = "Tài chính & Thu phí", Desc = "Thu học phí và in biên lai thanh toán" },
            new { Code = "DISCOUNT_MANAGE", Name = "Quản lý giảm giá học bổng", Module = "Tài chính & Thu phí", Desc = "Áp dụng chính sách ưu đãi học phí theo thẩm quyền" },
            new { Code = "FINANCE_APPROVE", Name = "Phê duyệt tài chính cấp cao", Module = "Tài chính & Thu phí", Desc = "Phê duyệt miễn giảm đặc biệt hoặc hoàn phí" },

            // 9. Báo cáo & Thống kê
            new { Code = "REPORT_VIEW", Name = "Xem báo cáo thống kê", Module = "Báo cáo & Thống kê", Desc = "Xem biểu đồ doanh thu, tuyển sinh và đào tạo" },
            new { Code = "REPORT_EXPORT", Name = "Xuất báo cáo Excel", Module = "Báo cáo & Thống kê", Desc = "Xuất dữ liệu báo cáo chuẩn ra tệp Excel" },

            // 10. Hạ tầng Hệ thống & Kiểm toán
            new { Code = "AUDIT_VIEW", Name = "Xem nhật ký kiểm toán", Module = "Hạ tầng Hệ thống & Kiểm toán", Desc = "Tra cứu lịch sử thao tác hệ thống (Audit Logs)" },
            new { Code = "SYSTEM_BACKUP", Name = "Sao lưu CSDL SQLite", Module = "Hạ tầng Hệ thống & Kiểm toán", Desc = "Tạo tệp sao lưu .bak an toàn" },
            new { Code = "SYSTEM_RESTORE", Name = "Phục hồi CSDL SQLite", Module = "Hạ tầng Hệ thống & Kiểm toán", Desc = "Khôi phục dữ liệu từ tệp sao lưu" },
            new { Code = "SYSTEM_CONFIG", Name = "Cấu hình trung tâm", Module = "Hạ tầng Hệ thống & Kiểm toán", Desc = "Cập nhật thông tin trung tâm và hình nền Lively" }
        };

        foreach (var p in permissions)
        {
            conn.Execute(@"
                INSERT INTO Permissions (PermissionCode, PermissionName, ModuleName, Description)
                VALUES (@Code, @Name, @Module, @Desc)
                ON CONFLICT(PermissionCode) DO UPDATE SET 
                    PermissionName = excluded.PermissionName,
                    ModuleName = excluded.ModuleName,
                    Description = excluded.Description;", p);
        }

        // Seed Default RolePermissions if empty
        int rolePermCount = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM RolePermissions;");
        if (rolePermCount == 0)
        {
            // 1. ROLE_ADMIN gets ALL permissions
            conn.Execute(@"
                INSERT OR IGNORE INTO RolePermissions (RoleId, PermissionId)
                SELECT r.RoleId, p.PermissionId 
                FROM Roles r, Permissions p
                WHERE r.RoleCode = 'ROLE_ADMIN';");

            // 2. ROLE_MGR
            var mgrPerms = new[] { "REPORT_VIEW", "REPORT_EXPORT", "FINANCE_APPROVE", "USER_VIEW", "STUDENT_VIEW", "CLASS_VIEW", "COURSE_VIEW", "AUDIT_VIEW" };
            AssignRolePerms(conn, "ROLE_MGR", mgrPerms);

            // 3. ROLE_EC (Counselor)
            var ecPerms = new[] { "LEAD_VIEW", "LEAD_CREATE", "LEAD_EDIT", "LEAD_CONSULT", "LEAD_TEST", "LEAD_CONVERT", "STUDENT_VIEW", "STUDENT_CREATE", "STUDENT_EDIT", "CLASS_VIEW", "CLASS_ENROLL", "COURSE_VIEW", "ROOM_VIEW", "REPORT_VIEW" };
            AssignRolePerms(conn, "ROLE_EC", ecPerms);

            // 4. ROLE_ACC (Accountant)
            var accPerms = new[] { "INVOICE_VIEW", "PAYMENT_CREATE", "DISCOUNT_MANAGE", "STUDENT_VIEW", "CLASS_VIEW", "REPORT_VIEW", "REPORT_EXPORT" };
            AssignRolePerms(conn, "ROLE_ACC", accPerms);

            // 5. ROLE_AA (Academic Affairs)
            var aaPerms = new[] { "COURSE_VIEW", "COURSE_MANAGE", "ROOM_VIEW", "ROOM_MANAGE", "CLASS_VIEW", "CLASS_MANAGE", "CLASS_SCHEDULE", "CLASS_ENROLL", "ATTENDANCE_VIEW", "EXAM_VIEW", "EXAM_MANAGE", "STUDENT_VIEW", "REPORT_VIEW" };
            AssignRolePerms(conn, "ROLE_AA", aaPerms);

            // 6. ROLE_TEA (Teacher)
            var teaPerms = new[] { "CLASS_VIEW", "ATTENDANCE_VIEW", "ATTENDANCE_TAKE", "EXAM_VIEW", "EXAM_MANAGE", "STUDENT_VIEW" };
            AssignRolePerms(conn, "ROLE_TEA", teaPerms);

            // 7. ROLE_STU (Student)
            var stuPerms = new[] { "CLASS_VIEW", "ATTENDANCE_VIEW", "EXAM_VIEW", "INVOICE_VIEW" };
            AssignRolePerms(conn, "ROLE_STU", stuPerms);

            // 8. ROLE_PAR (Parent)
            var parPerms = new[] { "CLASS_VIEW", "ATTENDANCE_VIEW", "EXAM_VIEW", "INVOICE_VIEW", "STUDENT_VIEW" };
            AssignRolePerms(conn, "ROLE_PAR", parPerms);
        }
    }

    public static void AssignRolePerms(SqliteConnection conn, string roleCode, string[] permissionCodes)
    {
        foreach (var code in permissionCodes)
        {
            conn.Execute(@"
                INSERT OR IGNORE INTO RolePermissions (RoleId, PermissionId)
                SELECT r.RoleId, p.PermissionId 
                FROM Roles r, Permissions p
                WHERE r.RoleCode = @RoleCode AND p.PermissionCode = @Code;",
                new { RoleCode = roleCode, Code = code });
        }
    }
}
