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
    public static string Email { get; set; } = string.Empty;
    public static string Phone { get; set; } = string.Empty;
    public static string JobTitle { get; set; } = string.Empty;
    public static string CreatedDate { get; set; } = string.Empty;
    public static string LastLogin { get; set; } = string.Empty;
    public static HashSet<string> Permissions { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public static Dictionary<string, string> ModuleAccessLevels { get; set; } = new(StringComparer.OrdinalIgnoreCase);

    public static bool IsReadOnlyModule(string moduleKey)
    {
        if (RoleCode == "ROLE_ADMIN") return false;
        if (ModuleAccessLevels.TryGetValue(moduleKey, out string? access))
        {
            return access.Contains("Chỉ xem", StringComparison.OrdinalIgnoreCase);
        }
        return false;
    }

    public static bool HasFullAccountAccess()
    {
        if (RoleCode == "ROLE_ADMIN") return true;
        return ModuleAccessLevels.TryGetValue("Accounts", out string? access)
            && !access.Contains("Không", StringComparison.OrdinalIgnoreCase);
    }

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
