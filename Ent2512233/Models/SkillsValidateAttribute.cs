﻿namespace Ent2512233.Models
{
    internal class SkillsValidateAttribute : Attribute
    {
        public string[] Allowed { get; set; }
        public string ErrorMessage { get; set; }
    }
}