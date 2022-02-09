using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField]
    private GameObject[] characters;

    private int _charIdx;
    public int CharIdx{
        get{ return _charIdx;}
        set{ _charIdx = value;}
    }
    public static GameManager instance;

    void Awake(){
    if (instance==null){
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    else{
        Destroy(gameObject);
    }
}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() {
        SceneManager.sceneLoaded += OneLvevelFinishedLoading;
    }
     private void OnDisble() {
        SceneManager.sceneLoaded -= OneLvevelFinishedLoading;
    }
    void OneLvevelFinishedLoading(Scene scene,LoadSceneMode mode){
        if (scene.name=="SampleScene"){
            Instantiate(characters[CharIdx]);
        }
    }
}
