using System;
using System.Collections.Generic;
using System.Text;

namespace API.Attributes
{
    // ReSharper disable once ClassNeverInstantiated.Global
    /// <summary>
    ///     Attribute to associate class with corresponding Database table name.
    ///     All IParsable classes must use this.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class InfTable : Attribute
    {
        /// <summary>
        /// </summary>
        /// <param name="tableName">The Database table name</param>
        public InfTable(string tableName)
        {
            Name = tableName;
        }

        /// <summary>
        /// </summary>
        /// <param name="tableName">The Database table name</param>
        /// <param name="filterColumnName">
        ///     The Name of the column to filter on.
        ///     (This column name will be used in InfData.GetAll etc)
        /// </param>
        public InfTable(string tableName, string filterColumnName)
        {
            Name = tableName;
            Filter = filterColumnName;
        }

        /// <summary>
        ///     Gets the database table name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        ///     Gets the column name used for filtering by some InfCore methods.
        /// </summary>
        public string Filter { get; private set; }
    }
}
