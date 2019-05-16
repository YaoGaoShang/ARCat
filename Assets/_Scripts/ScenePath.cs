
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenePath : MonoBehaviour {
    //跳转场景的名字
    public string sceneName;
    /// <summary>
    /// 跳转场景按钮事件
    /// </summary>
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
