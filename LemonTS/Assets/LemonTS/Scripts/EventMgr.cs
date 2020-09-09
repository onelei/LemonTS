using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LemonTS
{
    public class EventMgr 
    {
        public static void Send(string func_name, float value)
        {
            TsMgr.EvalAction(func_name, value);
        }

        public static void Send(string func_name, string value)
        {
            TsMgr.EvalAction(func_name, value);
        }

        public static void Send(string func_name, GameObject value)
        {
            TsMgr.EvalAction(func_name, value);
        }

        public static void Send(string func_name, object value)
        {
            TsMgr.EvalAction(func_name, value);
        }
    }
}