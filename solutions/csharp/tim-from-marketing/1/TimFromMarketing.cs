static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string departmentBadge = department ?? "OWNER";
        return id == null ? $"{name} - {departmentBadge.ToUpper()}" 
            : $"[{id}] - {name} - {departmentBadge.ToUpper()}";
    }
}
