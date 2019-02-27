using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace fifaCoinsBestEver.dte
{
    public abstract class AEnum
    {
        public string name { get; protected set; }
        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int value { get; protected set; }
        
        public static List<AEnum> findAll(Type type)
        {
            if(type != null && type.IsSubclassOf(typeof(AEnum))) return type.GetFields().Select(f => (AEnum) f.GetValue(null)).ToList();
            throw new System.ArgumentException();
        }
        public static AEnum FromString(string roleString, Type type)
        {
            return findAll(type).Single(r => String.Equals(r.name, roleString, StringComparison.OrdinalIgnoreCase));
        }
 
        public static AEnum FromValue(int value, Type type)
        {
            return findAll(type).Single(r => r.value == value);
        }
    }
}