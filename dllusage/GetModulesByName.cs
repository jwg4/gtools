using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using log4net;

namespace dllusage
{
    public class GetModulesByName : GetModulesByPath
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public GetModulesByName()
            : base(resource.IDS_ModulesByName)
        {
        }

        protected override string GetDisplayNameFromModuleName(string moduleName)
        {
            string filename = Path.GetFileName(moduleName);
            string directory = Path.GetDirectoryName(moduleName);

            return string.Format("{0} in {1}", filename, directory);
        }
    }
}
