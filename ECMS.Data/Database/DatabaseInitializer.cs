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

        // Ensure columns StudentId, ParentId exist in Users if table existed prior
        try { conn.Execute("ALTER TABLE Users ADD COLUMN StudentId INTEGER;"); } catch { }
        try { conn.Execute("ALTER TABLE Users ADD COLUMN ParentId INTEGER;"); } catch { }

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

        // 2. Seed Sample Profiles (Employees, Teachers, Students, Parents)
        // Employee 1: Manager
        conn.Execute(@"
            INSERT OR IGNORE INTO Employees (EmployeeId, EmployeeCode, FullName, Department, Phone, Email) 
            VALUES (1, 'NV-0001', 'Hoàng Văn Quản (Giám đốc)', 'Ban Giám đốc', '0901234567', 'manager@ecms.edu.vn');");

        // Employee 2: Counselor (EC)
        conn.Execute(@"
            INSERT OR IGNORE INTO Employees (EmployeeId, EmployeeCode, FullName, Department, Phone, Email) 
            VALUES (2, 'NV-0002', 'Lê Thị Thảo (Tư vấn viên)', 'Phòng Tuyển sinh', '0902345678', 'counselor@ecms.edu.vn');");

        // Employee 3: Accountant (ACC)
        conn.Execute(@"
            INSERT OR IGNORE INTO Employees (EmployeeId, EmployeeCode, FullName, Department, Phone, Email) 
            VALUES (3, 'NV-0003', 'Phạm Minh Tài (Kế toán)', 'Phòng Kế toán', '0903456789', 'accountant@ecms.edu.vn');");

        // Employee 4: Academic Affairs (AA)
        conn.Execute(@"
            INSERT OR IGNORE INTO Employees (EmployeeId, EmployeeCode, FullName, Department, Phone, Email) 
            VALUES (4, 'NV-0004', 'Đặng Thị Mai (Giáo vụ)', 'Phòng Đào tạo', '0904567890', 'academic@ecms.edu.vn');");

        // Teacher 1
        conn.Execute(@"
            INSERT OR IGNORE INTO Teachers (TeacherId, TeacherCode, FullName, Specialization, Phone, Email, HourlyRate, IsNativeSpeaker) 
            VALUES (1, 'GV-0015', 'Thầy John Smith (GV Bản ngữ)', 'IELTS & Giao tiếp', '0905678901', 'john.smith@ecms.edu.vn', 350000, 1);");

        // Student 1
        conn.Execute(@"
            INSERT OR IGNORE INTO Students (StudentId, StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status) 
            VALUES (1, 'HV-2026-0001', 'Nguyễn Văn An (Học viên)', '2005-06-15', 'Nam', '0912345678', 'an.nguyen@gmail.com', '123 Lê Lợi, Q.1', 'Active');");

        // Parent 1
        conn.Execute(@"
            INSERT OR IGNORE INTO Parents (ParentId, ParentCode, FullName, Phone, Email, Occupation) 
            VALUES (1, 'PH-2026-0012', 'Trần Thị Mai (Phụ huynh)', '0918765432', 'mai.tran@gmail.com', 'Kinh doanh');");

        // StudentParent Link
        conn.Execute(@"
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
            string hash = BCrypt.Net.BCrypt.HashPassword(u.Password);
            
            // Insert or Update User
            conn.Execute(@"
                INSERT INTO Users (Username, PasswordHash, PasswordSalt, EmployeeId, TeacherId, StudentId, ParentId, IsActive)
                VALUES (@Username, @Hash, 'salt', @EmpId, @TeaId, @StuId, @ParId, 1)
                ON CONFLICT(Username) DO UPDATE SET 
                    PasswordHash = excluded.PasswordHash,
                    EmployeeId = excluded.EmployeeId,
                    TeacherId = excluded.TeacherId,
                    StudentId = excluded.StudentId,
                    ParentId = excluded.ParentId,
                    IsActive = 1;",
                new { u.Username, Hash = hash, u.EmpId, u.TeaId, u.StuId, u.ParId });

            // Assign Role
            int userId = conn.ExecuteScalar<int>("SELECT UserId FROM Users WHERE Username = @Username;", new { u.Username });
            int roleId = conn.ExecuteScalar<int>("SELECT RoleId FROM Roles WHERE RoleCode = @Role;", new { u.Role });

            conn.Execute(@"
                INSERT OR IGNORE INTO UserRoles (UserId, RoleId) 
                VALUES (@UserId, @RoleId);", new { UserId = userId, RoleId = roleId });
        }

        // 4. Seed Academic Data (Courses, ClassRooms, Classes, Schedules, Enrollments, Attendance, Exams, Scores)
        conn.Execute(@"
            INSERT OR IGNORE INTO Courses (CourseId, CourseCode, CourseName, Level, TotalHours, TotalSessions, BaseTuitionFee, PassingScore, IsActive)
            VALUES (1, 'ENG-IELTS-5.5', 'IELTS Foundation 5.5+', 'Intermediate', 60, 24, 5500000, 5.0, 1);");

        conn.Execute(@"
            INSERT OR IGNORE INTO ClassRooms (RoomId, RoomName, Floor, Capacity, HasProjector, IsActive)
            VALUES (1, 'Phòng P.201 (Multimedia)', 2, 25, 1, 1);");

        conn.Execute(@"
            INSERT OR IGNORE INTO Classes (ClassId, ClassCode, ClassName, CourseId, MainTeacherId, DefaultRoomId, StartDate, EndDate, MaxStudents, Status)
            VALUES (1, 'IELTS-2026-K12', 'Lớp IELTS Foundation K12 (T2-T4-T6)', 1, 1, 1, '2026-10-01', '2026-12-30', 20, 'InProgress');");

        conn.Execute(@"
            INSERT OR IGNORE INTO ClassSchedules (ScheduleId, ClassId, SessionNumber, Date, StartTime, EndTime, RoomId, TeacherId, IsAttendanceLocked, Topic)
            VALUES 
            (1, 1, 1, '2026-10-05', '18:00', '20:00', 1, 1, 1, 'Unit 1: Listening - Note Completion & Phonetics'),
            (2, 1, 2, '2026-10-07', '18:00', '20:00', 1, 1, 1, 'Unit 2: Reading - Skimming & Scanning Masterclass'),
            (3, 1, 3, '2026-11-02', '18:00', '20:00', 1, 1, 0, 'Unit 3: Writing Task 1 - Line Graph & Bar Chart');");

        conn.Execute(@"
            INSERT OR IGNORE INTO Enrollments (EnrollmentId, StudentId, ClassId, EnrollDate, Status, FinalGPA, AttendanceRate)
            VALUES (1, 1, 1, '2026-09-28', 'Active', 8.5, 100.0);");

        conn.Execute(@"
            INSERT OR IGNORE INTO AttendanceRecords (ScheduleId, StudentId, Status, Note)
            VALUES 
            (1, 1, 'Present', 'Đi học đúng giờ, tích cực luyện phát âm'),
            (2, 1, 'Present', 'Nắm vững kỹ thuật Skimming');");

        conn.Execute(@"
            INSERT OR IGNORE INTO Exams (ExamId, ClassId, ExamName, Type, ExamDate, WeightPercentage)
            VALUES 
            (1, 1, 'Kiểm tra Giữa kỳ (Midterm Test)', 'Midterm', '2026-10-25', 40.0),
            (2, 1, 'Kiểm tra Cuối kỳ (Final Test)', 'Final', '2026-12-28', 60.0);");

        conn.Execute(@"
            INSERT OR IGNORE INTO ExamScores (ExamId, StudentId, ScoreValue, TeacherComments)
            VALUES (1, 1, 8.5, 'Listening 8.5, Reading 8.5, Speaking 8.0, Writing 7.5. Thái độ học tập rất xuất sắc.');");

        // 5. Seed Finance Data (Invoices & Payments)
        conn.Execute(@"
            INSERT OR IGNORE INTO Invoices (InvoiceId, InvoiceCode, EnrollmentId, OriginalAmount, DiscountAmount, FinalAmount, BalanceDue, DueDate, Status)
            VALUES (1, 'INV-20261001-001', 1, 5500000, 0, 5500000, 0, '2026-10-10', 'Paid');");

        int cashierId = conn.ExecuteScalar<int>("SELECT UserId FROM Users WHERE Username = 'accountant';");
        if (cashierId == 0) cashierId = 1;

        conn.Execute(@"
            INSERT OR IGNORE INTO Payments (PaymentId, PaymentCode, InvoiceId, PaidAmount, PaymentDate, PaymentMethod, CashierId, Status, Note)
            VALUES (1, 'PT-20261001-0001', 1, 5500000, '2026-10-02 09:30:00', 'Chuyển khoản', @CashierId, 'Valid', 'Đã thanh toán đủ 100% học phí khóa IELTS Foundation K12');",
            new { CashierId = cashierId });

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
