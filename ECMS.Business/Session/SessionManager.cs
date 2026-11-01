using ECMS.Core.DTOs;

namespace ECMS.Business.Session;

public static class SessionManager
{
    private static UserSession? _currentUser;

    public static UserSession? CurrentUser => _currentUser;

    public static bool IsLoggedIn => _currentUser != null;

    public static void SetSession(UserSession session)
    {
        _currentUser = session;
    }

    public static void ClearSession()
    {
        _currentUser = null;
    }
}
