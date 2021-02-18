using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {

        public static T Instance { get; private set; }


        public static bool IsInitialized
        {
            get { return Instance != null; }
        }
        // Start is called before the first frame update 
        void Start()
        {
            Instance = (T)this;
        }

        // Update is called once per frame
        void Update()
        {

        }

        protected virtual void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }
    }
