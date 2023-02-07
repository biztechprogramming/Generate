using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate
{
    public class DapTemplate
    {
        string template = @"using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using Data.Base;
using Data.Entities;
 
namespace Data.Entities
{
    public partial class {ClassName}Dap : GenericBaseDap<{ClassName}>
    {
        public {ClassName}Dap()
        {
        }
        public {ClassName}Dap(BaseDap dapProvider)
        {
            if (dapProvider != null &&
                dapProvider.ConnectionContainer != null &&
                dapProvider.ConnectionContainer.Connection != null)
            {
                LeaveOpen = dapProvider.LeaveOpen;
                ConnectionContainer = dapProvider.ConnectionContainer;
            }
        }
        public {ClassName}Dap(ConnectionContainer connectionContainer, bool leaveOpen)
        {
            if (connectionContainer != null &&
                connectionContainer.Connection != null)
            {
                LeaveOpen = leaveOpen;
                ConnectionContainer = connectionContainer;
            }
        }

        public override {ClassName} Map(dynamic result){			
            return new {ClassName}
            {
                {Properties}
            };
        }
		
        public IEnumerable<{ClassName}> All()
        {
            return Query<{ClassName}>(SqlSelectCommand, buffered: false);
        }

        public List<{ClassName}> GetTop(int count)
        {
            var queryResult = Query<{ClassName}>(string.Format(""SELECT * FROM {1} WHERE ROWNUM<={0}, count, SqlTableName));
            return queryResult as List<{ClassName}> ?? queryResult.ToList();
        }

        public {ClassName} GetById(Decimal Id)
        {
            return Query <{ClassName}> (SqlSelectCommand + "" WHERE ID=:Id"", new { Id = Id }).FirstOrDefault();
        }

        public decimal GetNextSequence()
        {
            return Query(""SELECT SEQ_{ClassName}.NEXTVAL as ID FROM DUAL"").FirstOrDefault().ID;
        }

        public void Insert({ClassName} model)
        {
            Execute(SqlInsertCommand, model);
        }

        public void Insert(IEnumerable<{ClassName}> models)
        {
            Execute(SqlInsertCommand, models);
        }

        public void Delete(Decimal Id)
        {
            Execute(SqlDeleteCommand, new { Id = Id });
        }

        public void Update({ClassName} model)
        {
            Execute(SqlUpdateCommand, model);
        }

        public void Update(IEnumerable<{ClassName}> models)
        {
            Execute(SqlUpdateCommand, models);
        }

        { GetByMethods}

        public const string SqlTableName = ""{TableName}"";
        public const string SqlSelectCommand = ""SELECT * FROM "" + SqlTableName;
        public const string SqlInsertCommand = ""INSERT INTO "" + SqlTableName + "" ({InsertColumns}) VALUES ({InsertValues})"";
        public const string SqlUpdateCommand = ""UPDATE "" + SqlTableName + "" SET {UpdateColumns} WHERE ID=:Id"";
        public const string SqlDeleteCommand = ""DELETE FROM "" + SqlTableName + "" WHERE ID=:Id"";
		
	}

}";

        public string Output(string className, string tableName, string insertColumns)
        {
            return template.Replace("{ClassName}", className).Replace("{TableName}", tableName).Replace("{InsertColumns}", insertColumns);
        }
    }
}
