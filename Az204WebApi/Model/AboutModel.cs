﻿using System;

namespace Az204WebApi.Model
{
    public class AboutModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ContactModel Contact { get; set; }
    }
}
