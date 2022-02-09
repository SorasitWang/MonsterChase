using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
   public void Home(){
       SceneManager.LoadScene("Menu");
   }
    public void Re(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
