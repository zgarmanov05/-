using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    public GameObject collider1;
    public void reset()
    {
        WinScript cond = collider1.GetComponent<WinScript>();

        if(cond.wincond == true)
        {
            SceneManager.LoadScene("SSC");
            Time.timeScale = 1.0f;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1.0f;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
