using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private ToDestroy[] objecsttodestroy;



    // Start is called before the first frame update
    void Start()
    {
        objecsttodestroy = FindObjectsOfType<ToDestroy>();
    }

   public void DestroySelectedObjects()
    {
        foreach(ToDestroy guy in objecsttodestroy)
        {
            if(guy != null & guy.IsSelected)
            {
                Destroy(guy.gameObject);
            }
        }
    }
}
