using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{

    public enum SceneType {
        Scene_Title = 0,
        Scene_Game,
        Scene_Result,
    }

    [SerializeField]
    private SceneType moveToScene = SceneType.Scene_Title;

    private List<string> sceneList = new List<string>{
        "TitleScene",
        "GameScene",
        "ResultScene",
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {

        SceneManager.LoadScene(sceneList[(int)moveToScene]);

    }
    
    

}
