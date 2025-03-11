using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private List<AudioSource> sources;
    [SerializeField] private float minTimeForSound;
    int index = 0;
    private float lastTime = -999;
    private List<GameObject> inside;
    private bool started = false;

    private void Start()
    {
        inside = new List<GameObject>();
        StartCoroutine(WaitForStart());
    }

    private IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(.1f);
        started = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (started && Time.time - lastTime > minTimeForSound)
        {
            lastTime = Time.time;
            sources[index].pitch = UnityEngine.Random.Range(.85f, 1.15f);
            sources[index].Play();
            index++;
            index = index % sources.Count;
        }
    }
}
