using Assets.Scripts.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.ObjectsFacilities
{
    class Facility
    {

        private SimpleFactory _factory;

       /* void Start()
        {
            _factory = gameObject.GetComponent<SimpleFactory>();
        }*/

        public Facility ( SimpleFactory factory)
        {
            _factory = factory;
        }

        public Instaitiate GetObject(string type)
        {
            Instaitiate instObject = _factory.GetObjects(type);
            return instObject;

        }
    }
}
