using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using UnityEngine;
using Assets.Scripts.ScriptsObjects;

namespace Assets.Scripts.InstBase
{
    class CylinderInst: Instaitiate
    {

        private Vector3 positionOfInst;

        void Start()
        {
            positionOfInst = new Vector3(0, 10.25f, 7.74f);
            Menu = GameObject.FindGameObjectWithTag("menu");
            Menu.SetActive(false);
            InstObjectsOfType();
            type = "cylinder";
            i = 0;

        }

        protected override void InstObjectsOfType()
        {
            TimeForInst = StartCoroutine(InstaitiateObjects());

        }

        protected override IEnumerator InstaitiateObjects()
        {
            GameObject _objectInst = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            _objectInst.AddComponent<CylinderScript>();
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
