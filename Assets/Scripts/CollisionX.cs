using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionX : MonoBehaviour
{
    
    public GameObject player;
    public GameObject altin;
    public Text txt;
    public float saydir = 0;
    public Text Skor;
    public AudioSource collectablesAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="altin")
        {
            Destroy(collision.gameObject);
            saydir++;
            collectablesAudio = GetComponent<AudioSource>();
            collectablesAudio.Play();

        }
        txt.text = saydir.ToString();
        
        if (saydir > PlayerPrefs.GetFloat("Rekor"))
        {
            PlayerPrefs.SetFloat("Rekor", saydir);
        }
    }
}
