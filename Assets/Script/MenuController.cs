using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void level3()
    {

    }
}
