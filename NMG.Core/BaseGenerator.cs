using System.Collections.Generic;

namespace NMG.Core
{
    public abstract class BaseGenerator : IMappingGenerator
    {
        protected string filePath;
        protected List<string> tableNames;
        protected string nameSpace;
        protected string assemblyName;
        protected string sequenceName;
        protected ColumnDetails columnDetails;

        protected BaseGenerator(string filePath, List<string> tableNames, string nameSpace, string assemblyName, string sequenceName, ColumnDetails columnDetails)
        {
            this.filePath = filePath;
            this.tableNames = tableNames;
            this.nameSpace = nameSpace;
            this.assemblyName = assemblyName;
            this.sequenceName = sequenceName;
            this.columnDetails = columnDetails;
        } 

        public abstract void Generate();
    }
}