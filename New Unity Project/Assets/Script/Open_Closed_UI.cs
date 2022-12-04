using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open_Closed_UI : MonoBehaviour
{
    private bool clickflg = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //クリックしたとき
    public void click()
    {
        if(clickflg == true)
        {
            GetComponent<PanelSlider>().SlideOut();
            clickflg = false;
        }
        else
        {
            GetComponent<PanelSlider>().SlideIn();
            clickflg = true;
        }
        
    }

    //マウスカーソルを乗せたとき
    public void MouseHover()
    {
        GetComponent<Image>().color = new Color32 (0, 255, 0, 100);
    }

    //マウスカーソルを乗せてないとき
    public void NotMouseHover()
    {
        GetComponent<Image>().color = new Color32 (0, 0, 0, 0);
    }
}
