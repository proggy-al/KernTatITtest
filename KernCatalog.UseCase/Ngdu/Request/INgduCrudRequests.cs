// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>Запрос для действия "Создание" <see cref="NgduEntity"/>.</summary>
public interface INgduCreateRequest : IEntityCreateCommand<NgduEntity, NgduEntity>
{
}

/// <summary>Запрос для действия "Чтение" <see cref="NgduEntity"/>.</summary>
public interface INgduReadRequest : IEntityReadCommand<NgduEntity, Guid>
{
}

/// <summary>Запрос для действия "Изменение" <see cref="NgduEntity"/>.</summary>
public interface INgduUpdateRequest : IEntityUpdateCommand<NgduEntity, NgduEntity>
{
}

/// <summary>Запрос для действия "Удаление" <see cref="NgduEntity"/>.</summary>
public interface INgduDeleteRequest : IEntityDeleteCommand<NgduEntity, Guid>
{
}
