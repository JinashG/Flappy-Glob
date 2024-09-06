using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    
    public float flapstrength;
    public Logicscript logic;
    public bool birdalive=true;

    AudioManager audiomanager;
    public void Awake()
    {
        audiomanager =GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true&& birdalive)
        {
            myRigidbody.velocity = Vector2.up * flapstrength;
            audiomanager.PlaySfx(audiomanager.jump);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        Destroy(gameObject);
        birdalive=false;
    }
}
