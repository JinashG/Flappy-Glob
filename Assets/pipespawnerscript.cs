using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnerscript : MonoBehaviour
{
    public GameObject pipe;
    public ParticleSystem particle;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightoffset =10;
    // Start is called before the first frame update
    void Start()
    {
        particle.Play();
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
        {
           //Debug.Log("pipe deleted"+Time.deltaTime);
            timer +=Time.deltaTime*0.85f;
            
        }
        else     
        {
            spawnpipe();
            timer = 0;
        }
    }

    void spawnpipe()
    {
        float lowestPoint = transform.position.y - heightoffset;
        float highestPoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x+5,Random.Range(lowestPoint,highestPoint),0),transform.rotation);
    }
}
