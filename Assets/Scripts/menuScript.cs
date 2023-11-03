using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    public string newLvl1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startLvl1()
    {
        SceneManager.LoadScene(newLvl1);
    }

    public void startLvl2()
    {

    }

    public void quit()
    {
        Application.Quit();
    }
}
