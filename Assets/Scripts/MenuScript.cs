using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    void Start()
    {
        
    }
    
    public void OyunaBasla()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        SceneManager.LoadScene("SampleScene");

    }
    public void Ayarlar()
    {

    }
    public void OyunuKapat()
    {
        Debug.Log("Çıkış yapıldı.");
        Application.Quit();
        
    }
    public void TekrarOyna()
    {

    }
    public void anaMenu()
    {
        SceneManager.LoadScene("BaslangicMenu");
    }

   
}
