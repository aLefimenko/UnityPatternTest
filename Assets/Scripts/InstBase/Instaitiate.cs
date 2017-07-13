using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Instaitiate:MonoBehaviour {
    protected int i;
    protected GameObject Menu;
    protected string type;
    protected Coroutine TimeForInst;

    protected virtual void InstObjectsOfType() { }

    protected virtual IEnumerator InstaitiateObjects() { return null; }

    protected virtual void Repeat() { }

    /*public void InstObjectsOfType()
    {
        TimeForInst=StartCoroutine(InstaitiateObjects(Prefab));
        Menu.SetActive(false);
    }

    IEnumerator InstaitiateObjects(GameObject objInstaitiate)
    {
        yield return new WaitForSeconds(1f);
        if (i == 15)
        {
            Debug.Log("wtf");
            StopCoroutine(TimeForInst);
            i = 0;
            Menu.SetActive(true);
        }
        else
        {
            Instantiate(objInstaitiate, objInstaitiate.transform.position, Quaternion.identity);
            i++;
            Repeat();
        }
        yield return new WaitForSeconds(1f);
    }

    private void Repeat()
    {
        StartCoroutine(InstaitiateObjects(Prefab));
    }*/
}
