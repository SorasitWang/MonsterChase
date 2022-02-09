using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    private static UnityEngine.UI.Text txt;
    private static int _score ;
    public int Point{
        get{return _score;}
        set{_score = value;}
    }
    void Start()
    {
        txt = GetComponent<UnityEngine.UI.Text>();
        _score = 0;
        txt.text = _score.ToString();
        Debug.Log("socre"+txt.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void plusScore(){
        _score += 1;
        txt.text = _score.ToString();
    }
}

