// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>"Создание" <see cref="OilfieldEntity"/>.</summary>
public class OilfieldCreateOne(OilfieldEntity dataIn) : EntityCreateOneOper<OilfieldEntity, OilfieldEntity>(dataIn)
{
}

/// <summary>"Создание" <see cref="OilfieldEntity"/> по списку.</summary>
public class OilfieldCreateMany(OilfieldEntity[] dataIn) : EntityCreateManyOper<OilfieldEntity, OilfieldEntity>(dataIn)
{
}

/// <summary>"Чтение" <see cref="OilfieldEntity"/>.</summary>
public class OilfieldReadOne(Guid dataIn) : EntityReadOneOper<OilfieldEntity, Guid>(dataIn)
{
}

/// <summary>"Чтение" <see cref="OilfieldEntity"/> по списку.</summary>
public class OilfieldReadMany(IReadOnlyCollection<Guid> dataIn) : EntityReadManyOper<OilfieldEntity, Guid>(dataIn)
{
}

/// <summary>"Изменение" <see cref="OilfieldEntity"/>.</summary>
public class OilfieldUpdateOne(OilfieldEntity dataIn) : EntityUpdateOneOper<OilfieldEntity, OilfieldEntity>(dataIn)
{
}

/// <summary>"Изменение" <see cref="OilfieldEntity"/> по списку.</summary>
public class OilfieldUpdateMany(IReadOnlyCollection<OilfieldEntity> dataIn) : EntityUpdateManyOper<OilfieldEntity, OilfieldEntity>(dataIn)
{
}

/// <summary>"Удаление" <see cref="OilfieldEntity"/>.</summary>
public class OilfieldDeleteOne(Guid dataIn) : EntityDeleteOneOper<OilfieldEntity, Guid>(dataIn)
{
}

/// <summary>"Удаление" <see cref="OilfieldEntity"/> по списку.</summary>
public class OilfieldDeleteMany(IReadOnlyCollection<Guid> dataIn) : EntityDeleteManyOper<OilfieldEntity, Guid>(dataIn)
{
}
