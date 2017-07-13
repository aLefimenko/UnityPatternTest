using Assets.Scripts.InstBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Factory
{
    class SimpleFactory:MonoBehaviour
    {
        public GameObject prefabSphere;

        void Start()
        {
            prefabSphere = GameObject.FindGameObjectWithTag("prefabSphere");
        }

        public Instaitiate GetObjects(string type)
        {
            gameObject.AddComponent<Instaitiate>();
            Instaitiate instObject= gameObject.GetComponent<Instaitiate>();
            switch (type)
            {
                case "sphere":
                    gameObject.AddComponent<SphereInst>();
                    instObject = gameObject.GetComponent<SphereInst>();
                    break;
                case "cube":
                    gameObject.AddComponent<CubeInst>();
                    instObject = gameObject.GetComponent<CubeInst>();
                    break;
                case "cylinder":
                    gameObject.AddComponent<CylinderInst>();
                    instObject = gameObject.GetComponent<CylinderInst>();
                    break;
            }
            return instObject;
        }
    }
}
