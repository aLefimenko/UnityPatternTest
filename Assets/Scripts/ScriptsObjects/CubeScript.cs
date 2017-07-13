using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.ScriptsObjects
{
    class CubeScript:MonoBehaviour
    {
        private Rigidbody rigid;
        private bool trigEnter = false;
        private Vector3 positionEnd;
        void Start()
        {
            rigid = gameObject.GetComponent<Rigidbody>();
            positionEnd = new Vector3(0, 10.25f, -5f);
        }
        void OnTriggerEnter(Collider colliderPlane)
        {
            rigid.isKinematic = true;
            trigEnter = true;
            Destroy(gameObject,3f);
        }

        void Update()
        {
            if(trigEnter)
            {
                this.transform.Translate( positionEnd* Time.deltaTime);
            }
        }
    }
}
