using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SaglikSistemi : MonoBehaviour
{

    public GameObject [] kalpler;
    public GameObject dusman;
    private int hayat;
    private bool olum;
    
    void Start()
    {
        hayat = kalpler.Length;
    }

   
    void Update()
    {
        if (olum==true)
        {
            Debug.Log("Öldünüz");
        }
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dusman")
        {
            Destroy(collision.gameObject);
            if (hayat >= 1)
            {
                hayat --;
                Destroy(kalpler[hayat].gameObject);

                if (hayat < 1)
                {
                    olum = true;
                    SceneManager.LoadScene("GameOverMenu");
                }
            }

        }
        if (collision.gameObject.tag=="su")
        {
            if (hayat>=3)
            {
                hayat -= 3;
                Destroy(kalpler[hayat].gameObject);
                
            }
            if (hayat==2)
            {
                hayat -= 2;
                Destroy(kalpler[hayat].gameObject);
               
            }
            if (hayat == 1)
            {
                hayat -= 1;
                Destroy(kalpler[hayat].gameObject);
                
            }
            if (hayat < 1)
            {
                olum = true;
                SceneManager.LoadScene("GameOverMenu");
                
            }
        }
       
    }
}
