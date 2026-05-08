// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>Запрос для действия "Создание" <see cref="OilfieldEntity"/>.</summary>
public interface IOilfieldCreateRequest : IEntityCreateCommand<OilfieldEntity, OilfieldEntity>
{
}

/// <summary>Запрос для действия "Чтение" <see cref="OilfieldEntity"/>.</summary>
public interface IOilfieldReadRequest : IEntityReadCommand<OilfieldEntity, Guid>
{
}

/// <summary>Запрос для действия "Изменение" <see cref="OilfieldEntity"/>.</summary>
public interface IOilfieldUpdateRequest : IEntityUpdateCommand<OilfieldEntity, OilfieldEntity>
{
}

/// <summary>Запрос для действия "Удаление" <see cref="OilfieldEntity"/>.</summary>
public interface IOilfieldDeleteRequest : IEntityDeleteCommand<OilfieldEntity, Guid>
{
}
