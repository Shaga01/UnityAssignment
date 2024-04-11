using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    [SerializeField] BirdControlelr[] birdControlelrs;
    [SerializeField] float minBS;
    [SerializeField] float maxBS;

    private void Start()
    {
        StartCoroutine(BirdSpawnCour());
    }

    IEnumerator BirdSpawnCour()
    {
        while (true)
        {
            Instantiate(birdControlelrs[Random.Range(0, birdControlelrs.Length)]);
            yield return new WaitForSeconds(Random.Range(minBS, maxBS));
        }
    }
}
