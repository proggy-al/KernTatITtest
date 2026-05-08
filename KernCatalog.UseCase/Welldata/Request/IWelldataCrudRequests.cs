// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>Запрос для действия "Создание" <see cref="WelldataEntity"/>.</summary>
public interface IWelldataCreateRequest : IEntityCreateCommand<WelldataEntity, WelldataEntity>
{
}

/// <summary>Запрос для действия "Чтение" <see cref="WelldataEntity"/>.</summary>
public interface IWelldataReadRequest : IEntityReadCommand<WelldataEntity, Guid>
{
}

/// <summary>Запрос для действия "Изменение" <see cref="WelldataEntity"/>.</summary>
public interface IWelldataUpdateRequest : IEntityUpdateCommand<WelldataEntity, WelldataEntity>
{
}

/// <summary>Запрос для действия "Удаление" <see cref="WelldataEntity"/>.</summary>
public interface IWelldataDeleteRequest : IEntityDeleteCommand<WelldataEntity, Guid>
{
}
