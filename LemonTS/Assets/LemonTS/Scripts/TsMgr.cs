using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puerts;
using System;
using System.IO;

namespace LemonTS
{
    public class TsMgr : MonoBehaviour
    {
        public static string TsInitFilePath = "TsInit.js";

        public static JsEnv jsEnv;
        public static TsLoader loader = new TsLoader();

        public delegate void ts_func_object(object args);

        public static void Init()
        {
            //jsEnv.Eval("require('QuickStart')");
            loader = new TsLoader(Application.dataPath + "/TsProject/");
            jsEnv = new JsEnv(loader);
            ExecuteFile(TsInitFilePath);
        }

        public static void ExecuteFile(string filename)
        {
            if (loader.FileExists(filename))
            {
                string debugPath;
                var context = loader.ReadFile(filename, out debugPath);
                Eval(context, debugPath);
            }
            else
            {
                throw new InvalidProgramException("can not find " + filename);
            }
        }

        public static void Eval(string chunk, string chunkName = "chunk")
        {
            jsEnv.Eval(chunk, chunkName);
        }

        public static void EvalAction(string func_name, object value)
        {
            var func = jsEnv.Eval<ts_func_object>(func_name);
            if (func != null)
            {
                func(value);
            }
        }

    }
}