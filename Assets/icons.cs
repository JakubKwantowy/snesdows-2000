using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icons : MonoBehaviour
{
    public string action;

    private bool dobsod;
    // Start is called before the first frame update
    void Start()
    {
        GameObject start_menu = GameObject.Find("start_menu");
        GameObject start_menu_shutdown = GameObject.Find("start_menu/shutdown");
        start_menu.transform.localScale = new Vector3(0,0,0);
        start_menu_shutdown.transform.localScale = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKey(KeyCode.Escape) && dobsod){
            Application.Quit();
        }
    }

    IEnumerator iloveyou()
    {
        AudioSource snd = GetComponent<AudioSource>();
        snd.Play();
        yield return new WaitForSeconds(5);
        GameObject dialog_iloveyou = GameObject.Find("dialog_iloveyou");
        dialog_iloveyou.transform.localScale = new Vector3(2,2,1);
        snd = dialog_iloveyou.GetComponent<AudioSource>();
        snd.Play();
    }

    IEnumerator ending()
    {
        AudioSource snd = GetComponent<AudioSource>();
        snd.Play();
        yield return new WaitForSeconds(5);
        Debug.Log("END");
        Application.Quit();
    }

    void OnMouseDown(){
        if (action == "start")
        {
            GameObject start_menu = GameObject.Find("start_menu");
            GameObject start_menu_shutdown = GameObject.Find("start_menu/shutdown");

            if(start_menu.transform.localScale.x > 0f){
                start_menu.transform.localScale = new Vector3(0,0,0);
                start_menu_shutdown.transform.localScale = new Vector3(0,0,0);
            }else{
                start_menu.transform.localScale = new Vector3(1,1,1);
                start_menu_shutdown.transform.localScale = new Vector3(1,1,1);
            }
        }if (action == "start/shutdown"){
            Application.Quit();
        }if (action == "welcome/ok"){
            GameObject dialog_welcome = GameObject.Find("dialog_welcome");
            GameObject dialog_welcome_ok = GameObject.Find("dialog_welcome/btn_ok");
            Destroy(dialog_welcome, 10);
            Destroy(dialog_welcome_ok, 1);
        }if (action == "recycle"){
            GameObject dialog_recycle1 = GameObject.Find("dialog_recycle");
            dialog_recycle1.transform.localScale = new Vector3(2,2,1);
            AudioSource snd = GetComponent<AudioSource>();
            snd.Play();
        }if (action == "recycle/exit"){
            GameObject dialog_recycle2 = GameObject.Find("dialog_recycle");
            dialog_recycle2.transform.localScale = new Vector3(0,0,0);
        }if(action == "recycle/iloveyou"){
            StartCoroutine("iloveyou");
        }if(action == "iloveyou/no"){
            Cursor.visible = false;
            GameObject dialog_iloveyou = GameObject.Find("dialog_iloveyou");
            dialog_iloveyou.transform.localScale = new Vector3(0,0,0);
            GameObject bsod = GameObject.Find("bsod");
            bsod.transform.localScale = new Vector3(0.925f,0.925f,1);
            bsod.GetComponent<AudioSource>().Play();
            dobsod = true;
        }if(action == "iloveyou/yes"){
            GameObject dialog_iloveyou = GameObject.Find("dialog_iloveyou");
            GameObject end = GameObject.Find("end");
            dialog_iloveyou.transform.localScale = new Vector3(0,0,0);
            end.transform.localScale = new Vector3(1,1,1);
            StartCoroutine(ending());
        }if(action == "playsnd"){
            GetComponent<AudioSource>().Play();
        }
    }
}
