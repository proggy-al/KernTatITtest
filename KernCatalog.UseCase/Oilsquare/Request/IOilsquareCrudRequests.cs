// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>Запрос для действия "Создание" <see cref="OilsquareEntity"/>.</summary>
public interface IOilsquareCreateRequest : IEntityCreateCommand<OilsquareEntity, OilsquareEntity>
{
}

/// <summary>Запрос для действия "Чтение" <see cref="OilsquareEntity"/>.</summary>
public interface IOilsquareReadRequest : IEntityReadCommand<OilsquareEntity, Guid>
{
}

/// <summary>Запрос для действия "Изменение" <see cref="OilsquareEntity"/>.</summary>
public interface IOilsquareUpdateRequest : IEntityUpdateCommand<OilsquareEntity, OilsquareEntity>
{
}

/// <summary>Запрос для действия "Удаление" <see cref="OilsquareEntity"/>.</summary>
public interface IOilsquareDeleteRequest : IEntityDeleteCommand<OilsquareEntity, Guid>
{
}
