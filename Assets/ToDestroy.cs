using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDestroy : MonoBehaviour
{

    public GameObject SlectionPrefab;
    GameObject NewSelection;
    public bool IsSelected;



    private void OnMouseDown()
    {
        if(NewSelection==null)
        {
            NewSelection = Instantiate(SlectionPrefab, transform.position, Quaternion.identity);
            NewSelection.transform.SetParent(gameObject.transform);
            NewSelection.SetActive(false);
        }
        IsSelected =true;

        if(IsSelected)
        {
            NewSelection.SetActive(true);
            GameManager.Instance.destroynow();
        }
        else
        {
            NewSelection.SetActive(false);

        }
    }
}
