using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAniController : MonoBehaviour {

	//小猫 的Ani
    private Animator Ani;
	//小猫
    public GameObject AniObj;
	//声音片段
    public AudioClip[] AuClip;

    [SerializeField]
    private GameObject Grass;//草
	void Start () {
		//获得小猫的Animator
        Ani = AniObj.GetComponent<Animator>();
		//添加声音播放
        gameObject.GetComponent<AudioSource>().clip = AuClip[0];
		//程序开始  把草设置为不可见
        Grass.SetActive(false);
        //gameObject.GetComponent<AudioSource>().Play();

    }
	//Walk按钮事件
    public void Walking()
    {
        Ani.SetBool("walk",true );//播放walk动画，不播放  eat 和 sound 动画
        Ani.SetBool("eat",false );
        Ani.SetBool("sound",false );
		
        gameObject.GetComponent<AudioSource>().clip = AuClip[0];
        gameObject.GetComponent<AudioSource>().Play();//播放声音
        Grass.SetActive(false);//把草设置为不可见
    }
	//sound 按钮事件
    public void Sounding()
    {
        Ani.SetBool("walk", false );
        Ani.SetBool("eat", false);
        Ani.SetBool("sound", true );//播放sound动画，不播放  eat 和  walk动画
        gameObject.GetComponent<AudioSource>().clip = AuClip[1];//播放数组中的第二个声音片段
        gameObject.GetComponent<AudioSource>().Play();//播放声音
        Grass.SetActive(false);//把草设置为不可见
    }
	//eat按钮事件
    public void Eating()
    {
        Ani.SetBool("walk", false );
        Ani.SetBool("eat", true );
        Ani.SetBool("sound", false);
        gameObject.GetComponent<AudioSource>().clip = AuClip[0];
        gameObject.GetComponent<AudioSource>().Play();//播放声音
        Grass.SetActive(true );//把草设置可见
    }
	//quit 按钮事件  退出程序
    public void ExitGame()
    {

        Application.Quit();

    }

}
