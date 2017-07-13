using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.ScriptsObjects
{
    class SphereScript:MonoBehaviour
    {
        private ParticleSystem Explos;
        private GameObject ObjectExplos;
        void Start()
        {
            ObjectExplos = GameObject.FindGameObjectWithTag("explosion");
            Explos = ObjectExplos.GetComponent<ParticleSystem>();
            Explos.Stop();
        }
        void OnTriggerEnter(Collider colliderPlane)
        {
            ObjectExplos.transform.position = transform.position;
            Explos.Play();
            Destroy(gameObject,0.5f);
        }
    }
}
