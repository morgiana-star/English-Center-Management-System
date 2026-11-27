using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Core.Enums;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class ExamService : IExamService
{
    private readonly IExamRepository _repo;

    public ExamService(IExamRepository? repo = null)
    {
        _repo = repo ?? new ExamRepository();
    }

    public async Task<IEnumerable<ExamListItemDto>> GetExamsAsync(
        int? teacherId = null, int? classId = null, string? examType = null, string? keyword = null)
    {
        return await _repo.GetExamsAsync(teacherId, classId, examType, keyword);
    }

    public async Task<int> CreateExamAsync(CreateExamDto dto)
    {
        if (dto.ClassId <= 0)
            throw new ArgumentException("Vui lòng chọn lớp học áp dụng bài thi.");

        if (string.IsNullOrWhiteSpace(dto.ExamName))
            throw new ArgumentException("Tên bài kiểm tra không được để trống.");

        if (dto.WeightPercentage < 0 || dto.WeightPercentage > 100)
            throw new ArgumentException("Trọng số bài thi phải nằm trong khoảng 0% đến 100%.");

        DateTime examDate;
        if (!DateTime.TryParse(dto.ExamDate, out examDate))
        {
            examDate = DateTime.Today;
        }

        var examType = dto.Type switch
        {
            "Thường xuyên (TX)" or "Quiz" => ExamType.Quiz,
            "Giữa khóa (GK)" or "Midterm" => ExamType.Midterm,
            "Cuối khóa (CK)" or "Final" => ExamType.Final,
            "Đầu vào" or "PlacementTest" => ExamType.PlacementTest,
            _ => ExamType.Midterm
        };

        var exam = new Exam
        {
            ClassId = dto.ClassId,
            ExamName = dto.ExamName.Trim(),
            Type = examType,
            ExamDate = examDate,
            WeightPercentage = dto.WeightPercentage
        };

        return await _repo.CreateExamAsync(exam);
    }

    public async Task<IEnumerable<ClassExamLookupDto>> GetClassesLookupAsync(int? teacherId = null)
    {
        return await _repo.GetClassesLookupAsync(teacherId);
    }

    public async Task<List<ClassGradeRowDto>> GetClassGradeBookAsync(int classId)
    {
        if (classId <= 0)
            return new List<ClassGradeRowDto>();

        return await _repo.GetClassGradeRowsAsync(classId);
    }

    public async Task<bool> SaveClassGradeBookAsync(int classId, List<ClassGradeRowDto> rows)
    {
        if (classId <= 0)
            throw new ArgumentException("Mã lớp không hợp lệ.");

        if (rows == null || rows.Count == 0)
            return false;

        // Chuẩn hóa điểm IELTS: 0.0 - 9.0 và xóa sạch ghi chú học vụ
        foreach (var r in rows)
        {
            if (r.ListeningScore.HasValue)
                r.ListeningScore = Math.Clamp(r.ListeningScore.Value, 0m, 9.0m);

            if (r.ReadingScore.HasValue)
                r.ReadingScore = Math.Clamp(r.ReadingScore.Value, 0m, 9.0m);

            if (r.WritingScore.HasValue)
                r.WritingScore = Math.Clamp(r.WritingScore.Value, 0m, 9.0m);

            if (r.SpeakingScore.HasValue)
                r.SpeakingScore = Math.Clamp(r.SpeakingScore.Value, 0m, 9.0m);

            r.Comment = null; // Xóa hết ghi chú học vụ
        }

        return await _repo.SaveClassGradeRowsAsync(classId, rows);
    }
}
