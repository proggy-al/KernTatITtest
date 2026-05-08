// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>"Создание" <see cref="OilsquareEntity"/>.</summary>
public class OilsquareCreateOne(OilsquareEntity dataIn) : EntityCreateOneOper<OilsquareEntity, OilsquareEntity>(dataIn)
{
}

/// <summary>"Создание" <see cref="OilsquareEntity"/> по списку.</summary>
public class OilsquareCreateMany(OilsquareEntity[] dataIn) : EntityCreateManyOper<OilsquareEntity, OilsquareEntity>(dataIn)
{
}

/// <summary>"Чтение" <see cref="OilsquareEntity"/>.</summary>
public class OilsquareReadOne(Guid dataIn) : EntityReadOneOper<OilsquareEntity, Guid>(dataIn)
{
}

/// <summary>"Чтение" <see cref="OilsquareEntity"/> по списку.</summary>
public class OilsquareReadMany(IReadOnlyCollection<Guid> dataIn) : EntityReadManyOper<OilsquareEntity, Guid>(dataIn)
{
}

/// <summary>"Изменение" <see cref="OilsquareEntity"/>.</summary>
public class OilsquareUpdateOne(OilsquareEntity dataIn) : EntityUpdateOneOper<OilsquareEntity, OilsquareEntity>(dataIn)
{
}

/// <summary>"Изменение" <see cref="OilsquareEntity"/> по списку.</summary>
public class OilsquareUpdateMany(IReadOnlyCollection<OilsquareEntity> dataIn) : EntityUpdateManyOper<OilsquareEntity, OilsquareEntity>(dataIn)
{
}

/// <summary>"Удаление" <see cref="OilsquareEntity"/>.</summary>
public class OilsquareDeleteOne(Guid dataIn) : EntityDeleteOneOper<OilsquareEntity, Guid>(dataIn)
{
}

/// <summary>"Удаление" <see cref="OilsquareEntity"/> по списку.</summary>
public class OilsquareDeleteMany(IReadOnlyCollection<Guid> dataIn) : EntityDeleteManyOper<OilsquareEntity, Guid>(dataIn)
{
}
