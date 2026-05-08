// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>"Создание" <see cref="UbrEntity"/>.</summary>
public class UbrCreateOne(UbrEntity dataIn) : EntityCreateOneOper<UbrEntity, UbrEntity>(dataIn)
{
}

/// <summary>"Создание" <see cref="UbrEntity"/> по списку.</summary>
public class UbrCreateMany(UbrEntity[] dataIn) : EntityCreateManyOper<UbrEntity, UbrEntity>(dataIn)
{
}

/// <summary>"Чтение" <see cref="UbrEntity"/>.</summary>
public class UbrReadOne(Guid dataIn) : EntityReadOneOper<UbrEntity, Guid>(dataIn)
{
}

/// <summary>"Чтение" <see cref="UbrEntity"/> по списку.</summary>
public class UbrReadMany(IReadOnlyCollection<Guid> dataIn) : EntityReadManyOper<UbrEntity, Guid>(dataIn)
{
}

/// <summary>"Изменение" <see cref="UbrEntity"/>.</summary>
public class UbrUpdateOne(UbrEntity dataIn) : EntityUpdateOneOper<UbrEntity, UbrEntity>(dataIn)
{
}

/// <summary>"Изменение" <see cref="UbrEntity"/> по списку.</summary>
public class UbrUpdateMany(IReadOnlyCollection<UbrEntity> dataIn) : EntityUpdateManyOper<UbrEntity, UbrEntity>(dataIn)
{
}

/// <summary>"Удаление" <see cref="UbrEntity"/>.</summary>
public class UbrDeleteOne(Guid dataIn) : EntityDeleteOneOper<UbrEntity, Guid>(dataIn)
{
}

/// <summary>"Удаление" <see cref="UbrEntity"/> по списку.</summary>
public class UbrDeleteMany(IReadOnlyCollection<Guid> dataIn) : EntityDeleteManyOper<UbrEntity, Guid>(dataIn)
{
}
