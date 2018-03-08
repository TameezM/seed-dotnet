﻿

using System.Collections.Generic;

namespace Allure.builder.attributes
{
    public class testDefinition
    {
        public string name { set; get; }
        public string description { set; get; }
        public string id { set; get; }
        public string epicName { set; get; }
        public string featureName { set; get; }
        public string storyName { set; get; }
        public List<link> listLinks { set; get; }
    }
}
