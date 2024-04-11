using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class SplineHolder : MonoBehaviour
{
    [SerializeField] SplineContainer[] allSplines;
    public static SplineHolder Instance;
    private void Awake()
    {
     if (Instance == null)
        {
            Instance = this;
        }   
    }

    public SplineContainer GetRandomSpline() => allSplines[Random.Range(0,allSplines.Length-1)];
  
}
