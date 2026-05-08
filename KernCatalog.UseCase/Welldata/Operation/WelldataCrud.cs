// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>"Создание" <see cref="WelldataEntity"/>.</summary>
public class WelldataCreateOne(WelldataEntity dataIn) : EntityCreateOneOper<WelldataEntity, WelldataEntity>(dataIn)
{
}

/// <summary>"Создание" <see cref="WelldataEntity"/> по списку.</summary>
public class WelldataCreateMany(WelldataEntity[] dataIn) : EntityCreateManyOper<WelldataEntity, WelldataEntity>(dataIn)
{
}

/// <summary>"Чтение" <see cref="WelldataEntity"/>.</summary>
public class WelldataReadOne(Guid dataIn) : EntityReadOneOper<WelldataEntity, Guid>(dataIn)
{
}

/// <summary>"Чтение" <see cref="WelldataEntity"/> по списку.</summary>
public class WelldataReadMany(IReadOnlyCollection<Guid> dataIn) : EntityReadManyOper<WelldataEntity, Guid>(dataIn)
{
}

/// <summary>"Изменение" <see cref="WelldataEntity"/>.</summary>
public class WelldataUpdateOne(WelldataEntity dataIn) : EntityUpdateOneOper<WelldataEntity, WelldataEntity>(dataIn)
{
}

/// <summary>"Изменение" <see cref="WelldataEntity"/> по списку.</summary>
public class WelldataUpdateMany(IReadOnlyCollection<WelldataEntity> dataIn) : EntityUpdateManyOper<WelldataEntity, WelldataEntity>(dataIn)
{
}

/// <summary>"Удаление" <see cref="WelldataEntity"/>.</summary>
public class WelldataDeleteOne(Guid dataIn) : EntityDeleteOneOper<WelldataEntity, Guid>(dataIn)
{
}

/// <summary>"Удаление" <see cref="WelldataEntity"/> по списку.</summary>
public class WelldataDeleteMany(IReadOnlyCollection<Guid> dataIn) : EntityDeleteManyOper<WelldataEntity, Guid>(dataIn)
{
}
