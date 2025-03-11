using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateNames : MonoBehaviour
{
    [SerializeField] private GameObject nameCard;
    [SerializeField] private Transform pivotPoint;
    [SerializeField] private int numNames;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numNames; i++)
        {
            GameObject g = Instantiate(nameCard, pivotPoint.position, Quaternion.Euler(0,0,360f * ((float)i / numNames)));
            g.transform.SetParent(transform, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
