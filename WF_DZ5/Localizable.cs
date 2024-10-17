using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WF_DZ5
{
    public class Localizable
    {
        public ResourceManager? resourceManager { get; set; }

        private Localizable() { }

        public Localizable(ResourceManager resourceManager)
        {
            this.resourceManager = resourceManager;
        }

        public void ChangeLanguage(Label label, string localizableString, params string[] args) 
        {
            label.Text = string.Format(resourceManager?.GetString(localizableString)!, args);
        }
        public void ChangeLanguage(Label label, string localizableString)
        {
            label.Text = resourceManager?.GetString(localizableString);
        }

        public string LocalizableString(string localizableString, params string[] args) 
        {
            return string.Format(resourceManager?.GetString(localizableString)!, args);
        }
        public string LocalizableString(string localizableString)
        {
            return resourceManager?.GetString(localizableString)!;
        }
    }
}
