using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    
    private bool isPaused = false;
    
    void Start()
    {
        
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("pause");
            isPaused = !isPaused;
            pauseMenu.SetActive(isPaused);
        }
            
       /* 
        if (isPaused == false && Input.GetKeyDown( KeyCode.P))
        {
            pauseMenu.SetActive(true);
            isPaused = true;
        }
        
        if (isPaused == true && Input.GetKeyDown( KeyCode.P))
        {
            pauseMenu.SetActive(false);
            isPaused = false;
        }
        */
    }
}
