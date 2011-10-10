using System;
using NMG.Core.Domain;
using NMG.Core.TextFormatter;

namespace NMG.Core.Generator
{
    public abstract class AbstractGenerator : IGenerator
    {
        protected Table Table;
        protected string assemblyName;
        protected string filePath;
        protected string nameSpace;
        protected string sequenceName;
        protected string tableName;
		protected const string TABS = "\t\t\t";
    	protected string ClassNamePrefix { get; set;}

        protected AbstractGenerator(string filePath, string tableName, string nameSpace, string assemblyName,
                                    string sequenceName, Table table, ApplicationPreferences appPrefs)
        {
            this.filePath = filePath;
            this.tableName = tableName;
            this.nameSpace = nameSpace;
            this.assemblyName = assemblyName;
            this.sequenceName = sequenceName;
            Table = table;
            Formatter = TextFormatterFactory.GetTextFormatter(appPrefs);
        }


        public bool UsesSequence
        {
            get
            {
                return !String.IsNullOrEmpty(sequenceName);
            }
        }

        #region IGenerator Members

        public ITextFormatter Formatter { get; set; }

        public abstract void Generate();

        #endregion
    }
}