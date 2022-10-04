using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public Destroyer D;


    int counter;

    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
   public void destroynow()
    {
        counter++;
        if (counter==5)
        {
            D.DestroySelectedObjects();
            counter = 0;
        }
    }
}
