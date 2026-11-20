using System;
using System.Collections.Generic;

namespace ECMS.UI;

public static class AppSession
{
    public static int UserId { get; set; } = 1;
    public static string Username { get; set; } = "admin";
    public static string FullName { get; set; } = "Trần Minh Quân";
    public static string RoleCode { get; set; } = "ROLE_ADMIN";
    public static string RoleName { get; set; } = "Admin";
    public static string SignerTitle { get; set; } = "GIÁM ĐỐC TRUNG TÂM";
    public static string Email { get; set; } = "minhquan.admin@ecms.edu.vn";
    public static string Phone { get; set; } = "0912 345 678";
    public static string JobTitle { get; set; } = "Giám đốc điều hành & Quản trị hệ thống";
    public static string CreatedDate { get; set; } = "01/01/2024";
    public static string LastLogin { get; set; } = "16/11/2026 08:30";
    public static HashSet<string> Permissions { get; set; } = new(StringComparer.OrdinalIgnoreCase);

    public static string GetSignerRoleTitle()
    {
        return RoleCode switch
        {
            "ROLE_ADMIN" => "GIÁM ĐỐC TRUNG TÂM",
            "ROLE_AA" or "ROLE_ACADEMIC" => "TRƯỞNG BỘ PHẬN ĐÀO TẠO",
            "ROLE_TEA" or "ROLE_TEACHER" => "GIÁO VIÊN PHỤ TRÁCH",
            "ROLE_MGR" => "QUẢN LÝ TRUNG TÂM",
            "ROLE_ACC" => "KẾ TOÁN TRƯỞNG",
            "ROLE_EC" => "TƯ VẤN TUYỂN SINH",
            _ => "ĐẠI DIỆN TRUNG TÂM"
        };
    }
}
