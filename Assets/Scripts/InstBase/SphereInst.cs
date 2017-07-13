using Assets.Scripts.ScriptsObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.InstBase
{
    class SphereInst : Instaitiate
    {
        private Vector3 positionOfInst;

        void Start()
        {
            positionOfInst= new Vector3(0, 10.25f, 7.74f);

            i = 0;
            Menu = GameObject.FindGameObjectWithTag("menu");
            Menu.SetActive(false);
            InstObjectsOfType();
            type = "sphere";
            i = 0;

        }

        protected override void InstObjectsOfType()
        {
            TimeForInst = StartCoroutine(InstaitiateObjects());
            
        }

        protected override IEnumerator InstaitiateObjects()
        {
            GameObject _objectInst = GameObject.CreatePrimitive(PrimitiveType.Sphere); 
            _objectInst.AddComponent<SphereScript>();
            _objectInst.AddComponent<Rigidbody>();
            _objectInst.transform.position = positionOfInst;
            yield return new WaitForSeconds(1f);
            if (i == 15)
            {
                StopCoroutine(TimeForInst);
                i = 0;
                Menu.SetActive(true);
            }
            else
            {
                i++;
                Repeat();
            }
        }

        protected override void Repeat()
        {
            StartCoroutine(InstaitiateObjects());
        }
    }
}
