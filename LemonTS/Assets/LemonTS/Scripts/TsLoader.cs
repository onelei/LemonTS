using System;
using System.Collections.Generic;
using System.IO;
using Puerts;

namespace LemonTS
{
    public class TsLoader : ILoader
    {
        private string root = "";

        public TsLoader()
        {

        }

        public TsLoader(string root)
        {
            this.root = root;
        }

        public bool FileExists(string filepath)
        {
            return File.Exists(Path.Combine(root, filepath));
        }

        public string ReadFile(string filepath, out string debugpath)
        {
            debugpath = Path.Combine(root, filepath);
            return File.ReadAllText(debugpath);
        }
    }

}
