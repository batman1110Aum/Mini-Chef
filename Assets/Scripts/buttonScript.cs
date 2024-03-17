using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EasyTransition;
public class buttonScript : MonoBehaviour
{
    
   public void ChangeScene(int SceneIndex) {

        SceneManager.LoadScene(SceneIndex);
    }
}
