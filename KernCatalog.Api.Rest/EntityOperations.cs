namespace KernCatalog.Api.Rest;

/// <summary>
/// Операции с сущностью.
/// </summary>
public static class EntityOperations
{
    /// <summary>Создание.</summary>
    public const string Create = "create";
    /// <summary>Чтение.</summary>
    public const string Read = "read";
    /// <summary>Изменение.</summary>
    public const string Update = "update";
    /// <summary>Удаление.</summary>
    public const string Delete = "delete";

    /// <summary>Экспорт.</summary>
    public const string Export = "export";
    /// <summary>Импорт.</summary>
    public const string Import = "import";

    /// <summary>
    /// Слить.
    /// </summary>
    /// <param name="operList">Список операций.</param>
    /// <returns>Строка с разделителями.</returns>
    public static string Join(params string[] operList)
    {
        return string.Join(",", operList);
    }
}
