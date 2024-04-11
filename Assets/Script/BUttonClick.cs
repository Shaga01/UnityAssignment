using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BUttonClick : MonoBehaviour
{
    [SerializeField] Button button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(buttonFunction);
        
    }

    public void buttonFunction()
    {
        Debug.Log("Button Clicked");
    }
}
