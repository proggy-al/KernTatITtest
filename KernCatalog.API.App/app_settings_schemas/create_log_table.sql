do language plpgsql $$
declare
  x_schema_name varchar := 'sdk_log';
  x_table_name varchar := 'log';
  x_owner varchar := 'postgres';

  x_sql_pattern varchar := '
CREATE TABLE %1$s.%2$s (
  uid UUID NOT NULL,
  parent_uid UUID,
  date_time TIMESTAMP(6) WITHOUT TIME ZONE NOT NULL,
  severity VARCHAR(100) NOT NULL,
  message TEXT NOT NULL,
  properties JSONB NOT NULL,
  CONSTRAINT %2$s__pk PRIMARY KEY(uid),
  CONSTRAINT %2$s__fk__%2$s_parent FOREIGN KEY (parent_uid)
    REFERENCES %1$s.%2$s(uid)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION
    NOT DEFERRABLE
) ;

ALTER TABLE %1$s.%2$s
  ALTER COLUMN uid SET STATISTICS 0;

ALTER TABLE %1$s.%2$s
  ALTER COLUMN parent_uid SET STATISTICS 0;

ALTER TABLE %1$s.%2$s
  ALTER COLUMN date_time SET STATISTICS 0;

ALTER TABLE %1$s.%2$s
  ALTER COLUMN message SET STATISTICS 0;

COMMENT ON TABLE %1$s.%2$s
IS ''Лог.'';

COMMENT ON COLUMN %1$s.%2$s.uid
IS ''Глобальный уникальный идентификатор.'';

COMMENT ON COLUMN %1$s.%2$s.parent_uid
IS ''Предок.'';

COMMENT ON COLUMN %1$s.%2$s.date_time
IS ''Дата и время возникновения.'';

COMMENT ON COLUMN %1$s.%2$s.severity
IS ''Уровень лога.'';

COMMENT ON COLUMN %1$s.%2$s.message
IS ''Сообщение.'';

COMMENT ON COLUMN %1$s.%2$s.properties
IS ''Свойства.'';

CREATE INDEX %2$s__idx__parent_uid ON %1$s.%2$s
  USING btree (parent_uid);

ALTER TABLE %1$s.%2$s
  OWNER TO %3$s;

ALTER TABLE %1$s.%2$s
  ALTER COLUMN message SET STORAGE PLAIN;

ALTER TABLE %1$s.%2$s
  ALTER COLUMN properties SET STORAGE PLAIN;
  ';
  
  x_sql_text varchar;
begin
  if exists (
    select
      1
    from
      pg_catalog.pg_tables 
    where
      schemaname = x_schema_name
      and tablename = x_table_name
  ) then
  	raise notice 'Таблица %.% уже существует.', x_schema_name, x_table_name;
  else
    x_sql_text := format(x_sql_pattern, x_schema_name, x_table_name, x_owner);
    execute x_sql_text;
    raise notice 'Таблица %.% создана.', x_schema_name, x_table_name;
  end if;
end
$$;