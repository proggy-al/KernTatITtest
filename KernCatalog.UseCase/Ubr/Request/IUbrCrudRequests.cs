// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>Запрос для действия "Создание" <see cref="UbrEntity"/>.</summary>
public interface IUbrCreateRequest : IEntityCreateCommand<UbrEntity, UbrEntity>
{
}

/// <summary>Запрос для действия "Чтение" <see cref="UbrEntity"/>.</summary>
public interface IUbrReadRequest : IEntityReadCommand<UbrEntity, Guid>
{
}

/// <summary>Запрос для действия "Изменение" <see cref="UbrEntity"/>.</summary>
public interface IUbrUpdateRequest : IEntityUpdateCommand<UbrEntity, UbrEntity>
{
}

/// <summary>Запрос для действия "Удаление" <see cref="UbrEntity"/>.</summary>
public interface IUbrDeleteRequest : IEntityDeleteCommand<UbrEntity, Guid>
{
}
