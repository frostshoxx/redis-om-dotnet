﻿namespace NRedisPlus.RediSearch.Attributes
{
    public class IndexedAttribute : SearchFieldAttribute
    {
        public override SearchFieldType SearchFieldType => SearchFieldType.INDEXED;
        public char Separator { get; set; } = ',';
        public bool CaseSensitive { get; set; } = false;
    }
}