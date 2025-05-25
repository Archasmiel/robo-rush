using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void ActivateLevelScene() {
        SceneManager.LoadScene(1);
    }

    public void ActivateInfiniteScene() {
        SceneManager.LoadScene(2);
    }

}
