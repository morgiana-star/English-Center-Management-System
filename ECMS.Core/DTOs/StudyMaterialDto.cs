namespace ECMS.Core.DTOs;

public class StudyMaterialDto
{
    public int MaterialId { get; set; }
    public int CourseId { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Version { get; set; } = "1.0";
    public string FileType { get; set; } = "PDF";
    public string FileSize { get; set; } = string.Empty;
}
