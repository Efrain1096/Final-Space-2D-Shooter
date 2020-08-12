using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The purpose of this script is to destroy the clone prefabs that appear after being instantiated for about 5 seconds.

public class DestroyPrefabClone : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(SelfDestruct());
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
