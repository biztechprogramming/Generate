using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate.Template
{
    public class ApiModelTemplate
    {
        string template = @"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApi.Models
{
    public class {ClassName}
    {
{% for column in VAllTabCols if column.TABLE_NAME == TableName %}
        public {{column.DATA_TYPE.ToString()}} {{column.COLUMN_NAME | ProperCase}} { get; set; }
{% endfor %}
    }
}";
        public string Output(string className, string tableName, string insertColumns)
        {
            return template.Replace("{ClassName}", className).Replace("{TableName}", tableName).Replace("{InsertColumns}", insertColumns);
        }
    }
}
