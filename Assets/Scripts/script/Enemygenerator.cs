using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemygenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objetos;
    float tMin = 1, tMax = 3;
    void Start()
    {
        Invoke("GenerarObjeto", Random.Range(tMin, tMax));
    }

   public void GenerarObjeto()
    {
        Invoke("GenerarObjeto", Random.Range(tMin, tMax));
        int pos = Random.Range(0, objetos.Length);
        Instantiate(objetos[pos], transform.position, objetos[pos].transform.rotation);
    }
}
