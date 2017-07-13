using Assets.Scripts.Factory;
using Assets.Scripts.InstBase;
using Assets.Scripts.ObjectsFacilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class WorkingScript:MonoBehaviour
    {
        private Facility _facility=null;
        private SimpleFactory _factory=null;

        public void GetType(string _type)
        {
            _facility.GetObject(_type);
        }

        void Start()
        {
            this.gameObject.AddComponent<SimpleFactory>();
            SimpleFactory _factory = gameObject.GetComponent<SimpleFactory>();
            _facility = new Facility(_factory);
        }
    }
}
