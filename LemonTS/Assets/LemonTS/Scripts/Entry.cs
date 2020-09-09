using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LemonTS
{

    public class Entry : BaseBehavior
    {
        private void Awake()
        {
            CacheGameObject.AddComponent<DontDestroyOnLoad>();
        }

        // Start is called before the first frame update
        void Start()
        {
            TsMgr.Init();
        }

        // Update is called once per frame
        void Update()
        {
           // EventMgr.Send("TimeMgr.Update", Time.realtimeSinceStartup);
        }
    }
}