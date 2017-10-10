namespace CodeTools.Util
{
    using System;

    public enum DBType  
    {
        MySql = 0,
        SqlService = 2
    }

    public class FieldProperty
    {
        public string FildName { get; set; }
        public string TypeName { get; set; }
        public string IsNull { get; set; }
    }

    
}

