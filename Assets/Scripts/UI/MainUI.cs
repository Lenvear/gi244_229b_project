using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] 
    private GameObject selectionMarker;
    public GameObject SelectionMarker {get { return selectionMarker; } }
    
    public static MainUI instance;
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
